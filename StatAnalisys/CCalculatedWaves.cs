﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace StatAnalisys
{
    public enum typeCrossing { ZDC, ZUC};
    public struct waveData
    {
        public typeCrossing type;
        public double amplMax;
        public double amplMin;
        public double totalHeight;
        public double sec;
        public double verticalAsummetry;
        public double[] horizontalAsymmetry;
        public double[] nullPoint;
        public double trough;
        public double ridge;
        public double rms;
    }
    public struct probability
    {
        public double H;
        public double experP;
        public double teorP;
        public double crestP;
        public double troughP;
    };
    struct heights
    {
        public double significantHeight;
        public double heightOneThird;
        public double sigma;
    };

    struct rogueWave
    {
        public int num;
        public int count;
        public List<double> points;
        public List<double> h;
    }

    class CCalculatedWaves
    {
        public List<CSingleWave> waves = new  List<CSingleWave>();
        public double generalSighHZUC, generalSighHZDC;
        public int generalCountRogueWavesZDC, generalCountRogueWavesZUC;
        public List<rogueWave> rougeWaves = new List<rogueWave>();
        public int countRogueWavesZDC, countRogueWavesZUC;
        public int countRogueWaves = 0;
        public double generallShiftCloudsVertZDC, generallShiftCloudsVertZUC, generallShiftCloudsHorZDC, generallShiftCloudsHorZUC;

        public CSingleWave this[int index]
        {
            get
            {
                return waves.ElementAt(index);
            }

            private set {}
        }

        public void calculateDatas(double[] arrT, double[][] arrS)
        {
            int i;
            generalSighHZUC = generalSighHZDC = 0;
            generalCountRogueWavesZDC = generalCountRogueWavesZUC = 0;
            countRogueWavesZDC = countRogueWavesZUC = 0;
            generallShiftCloudsVertZDC = generallShiftCloudsVertZUC = generallShiftCloudsHorZDC = generallShiftCloudsHorZUC = 0;
            List<double> listZDCH = new List<double>();
            List<double> listZUCH = new List<double>();

            for (i = 0; i < arrS.Count(); i++)
            {

                CSingleWave wave = new CSingleWave();

                if (wave.calculateSingleWave(arrT, arrS[i]))
                {
                    countRogueWavesZUC += findRougeWaves(wave.listHeihtsZDC, 2 * wave.heightsZDC.significantHeight, i, typeCrossing.ZDC, wave);
                    countRogueWavesZDC += findRougeWaves(wave.listHeihtsZUC, 2 * wave.heightsZUC.significantHeight, i, typeCrossing.ZUC, wave);

                    wave.rogueWave = countRogueWavesZUC + countRogueWavesZDC;
                    waves.Add(wave);

                    listZDCH.AddRange(wave.listHeihtsZDC);
                    listZUCH.AddRange(wave.listHeihtsZUC);
                    generallShiftCloudsVertZDC += wave.shiftCloudsVertZDC;
                    generallShiftCloudsVertZUC += wave.shiftCloudsVertZUC;
                    generallShiftCloudsHorZDC += wave.shiftCloudsHorZDC;
                    generallShiftCloudsHorZUC += wave.shiftCloudsHorZUC;
                }
            }

            countRogueWaves = countRogueWavesZDC + countRogueWavesZUC;

            
            //We should calculate sighificiant heights and rogue waves from all waves together in the whole file
            /*if (listZUCH.Count() != 0 && listZDCH.Count() != 0)
            {
                CSingleWave wave = new CSingleWave();
                generalSighHZUC = wave.significantHeights(listZUCH);
                generalSighHZDC = wave.significantHeights(listZDCH);
                generalCountRogueWavesZUC = findRougeWaves(listZUCH, 2 * generalSighHZUC, -1, typeCrossing.ZUC, wave);
                generalCountRogueWavesZDC = findRougeWaves(listZDCH, 2 * generalSighHZDC, -1, typeCrossing.ZDC, wave);
                generallShiftCloudsVertZDC /= waves.Count();
                generallShiftCloudsVertZUC /= waves.Count();
                generallShiftCloudsHorZDC /= waves.Count();
                generallShiftCloudsHorZUC /= waves.Count();
            }*/
        }
        int findRougeWaves(List<double> listHeights, double twiseSignH, int numberWave, typeCrossing type, CSingleWave wave)
        {
            //numberWave = -1 is a specified index for calculating number of rogue waves from all file

            int countRogueWave = 0;
            int k = 0;

            for (int i = 0; i < listHeights.Count(); i++)
            {
                if (listHeights[i] > twiseSignH)
                {
                    countRogueWave++;

                    if (rougeWaves.Exists(x => x.num == numberWave))
                    {
                        rogueWave rWave = rougeWaves.Find(x => x.num == numberWave);
                        rWave.count += 1;

                        k = findWaveIndex(listHeights[i], i, wave);

                        calculateRogueWave(k, wave, ref rWave);

                        int ind = rougeWaves.FindIndex(x => x.num == numberWave);

                        rougeWaves[ind] = rWave;
                    }
                    else 
                    {
                        rogueWave rWave;

                        rWave.num = numberWave;
                        rWave.count = 1;
                        rWave.points = new List<double>();
                        rWave.h = new List<double>();

                        k = findWaveIndex(listHeights[i], i, wave);
                        
                        calculateRogueWave(k, wave, ref rWave);

                        rougeWaves.Add(rWave);
                    }
                }
            }
            return countRogueWave;
        }

        private void calculateRogueWave(int k, CSingleWave wave, ref rogueWave rWave)
        {
            rWave.points.Add(wave.calculatingWaves[k].nullPoint[0]);

            if (wave.calculatingWaves[k].type == typeCrossing.ZDC)
            {
                rWave.points.Add(wave.calculatingWaves[k].trough);
                rWave.h.Add(wave.calculatingWaves[k].amplMin);
            }
            else
            {
                rWave.points.Add(wave.calculatingWaves[k].ridge);
                rWave.h.Add(wave.calculatingWaves[k].amplMax);
            }

            rWave.points.Add(wave.calculatingWaves[k].nullPoint[1]);

            if (wave.calculatingWaves[k].type == typeCrossing.ZDC)
            {
                rWave.points.Add(wave.calculatingWaves[k].ridge);
                rWave.h.Add(wave.calculatingWaves[k].amplMax);
            }
            else
            {
                rWave.points.Add(wave.calculatingWaves[k].trough);
                rWave.h.Add(wave.calculatingWaves[k].amplMin);
            }

            rWave.points.Add(wave.calculatingWaves[k].nullPoint[2]);        
        }

        private int findWaveIndex(double h, int i, CSingleWave wave)
        {
            int k = 0;

            if (wave.calculatingWaves[2*i].totalHeight == h)
            {
                k = 2*i;
            }
            else if (2 * i + 1 < wave.calculatingWaves.Count() && wave.calculatingWaves[2 * i + 1].totalHeight == h)
            {
                k = 2 * i + 1;
            }
            else if (2 * i - 1 > -1 && wave.calculatingWaves[2 * i - 1].totalHeight == h)
            {
                k = 2*i - 1;
            }

            return k;
        }
    }

    class CSingleWave
    {
        public const int T = 20;
        List<waveData> listCalculatedDatas = new List<waveData>();
        heights listHeightsZDC;
        heights listHeightsZUC;
        public double[][] cloudsVertZDC, cloudsVertZUC, cloudsHorZDC, cloudsHorZUC;
        public double shiftCloudsVertZDC, shiftCloudsVertZUC, shiftCloudsHorZDC, shiftCloudsHorZUC;
        public List<probability> listProbabilitiesZDC = new List<probability>();
        public List<probability> listProbabilitiesZUC = new List<probability>();
        public List<double> listSighificiantPeriods = new List<double>();
        public List<waveData> calculatingWaves = new List<waveData>();

        public List<double> listHeihtsZDC = new List<double>();
        public List<double> listHeihtsZUC = new List<double>();
        public List<double> listCrestAZDC = new List<double>();
        public List<double> listCrestAZUC = new List<double>();
        public List<double> listThroughAZDC = new List<double>();
        public List<double> listThroughAZUC = new List<double>();
        public List<double> listRmsZDC = new List<double>();
        public List<double> listRmsZUC = new List<double>();
        public int rogueWave = 0;
        double midCrestHorZDC, midThroughHorZDC, midCrestHorZUC, midThroughHorZUC;

        //double midCloudsZDCVertAsum, midCloudsZUCVertAsum, midCloudsZDCHorAsum, midCloudsZUCHorAsum;
        public List<waveData> calculatedDatas
        {
            get
            {
                return listCalculatedDatas;
            }
        }
        public heights heightsZDC
        {
            get
            {
                return listHeightsZDC;
            }
        }
        public heights heightsZUC
        {
            get
            {
                return listHeightsZUC;
            }
        }
        public List<probability> probabilitiesZDC
        {
            get
            {
                return listProbabilitiesZDC;
            }
        }
        public List<probability> probabilitiesZUC
        {
            get
            {
                return listProbabilitiesZUC;
            }
        }

        public List<double> sighificiantPeriods
        {
            get
            {
                return listSighificiantPeriods;
            }
        }

        public int interval
        {
            get
            {
                return T;
            }
        }
        void quickSort(List<double> a, int l, int r)
        {
            double temp;
            double x = a[l + (r - l) / 2];

            int i = l;
            int j = r;

            while (i <= j)
            {
                while (a[i] < x) i++;
                while (a[j] > x) j--;
                if (i <= j)
                {
                    temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                    i++;
                    j--;
                }
            }
            if (i < r) quickSort(a, i, r);

            if (l < j) quickSort(a, l, j);
        }

        double getNullPoint(double firstPointX, double firstPointY, double secondPointX, double secondPointY)
        {
            return ((secondPointX * firstPointY - firstPointX * secondPointY) / (firstPointY - secondPointY));
        }
        void amplMax(double waveParametresSec, double waveParametresShift, ref waveData wave, double amplMax)
        {
            if (waveParametresShift > amplMax)
            {
                wave.amplMax = waveParametresShift;
                wave.ridge = waveParametresSec;
            }
        }

        void amplMin(double waveParametresSec, double waveParametresShift, ref waveData wave, double amplMin)
        {
            if (waveParametresShift < amplMin)
            {
                wave.amplMin = waveParametresShift;
                wave.trough = waveParametresSec;
            }
        }

        waveData getSingleWave(int i, typeCrossing type, double[] arrT, double[] arrS)
        {
            int k = 0;
            double tmp, rms = 0;
            double countRMS = 0;
            int sizeT = arrT.Count();
            double currentPointSec, currentPointShift;
            waveData wave = new waveData();
            wave.nullPoint = new double[3];
            wave.horizontalAsymmetry = new double[2];
            wave.type = type;

            double nullPoint = getNullPoint(arrT[i], arrS[i], arrT[i + 1], arrS[i + 1]);
            wave.nullPoint[k] = nullPoint;
            wave.amplMax = 0;
            wave.amplMin = 0;
            currentPointSec = wave.nullPoint.ElementAt(k++);
            currentPointShift = 0;

            while (k < 3)
            {
                amplMax(currentPointSec, currentPointShift, ref wave, wave.amplMax);
                amplMin(currentPointSec, currentPointShift, ref wave, wave.amplMin);
                if (i < sizeT - 1 && (currentPointShift * arrS[i + 1] < 0))
                {
                    wave.nullPoint[k++] = getNullPoint(currentPointSec, currentPointShift, arrT[i + 1], arrS[i + 1]);
                }

                if (++i >= sizeT && k != 3)
                    return new waveData();
                
                rms += Math.Pow(Math.Abs(arrS[i]), 2);
                countRMS++;
                currentPointSec = arrT[i];
                currentPointShift = arrS[i];
            }

            wave.verticalAsummetry = Math.Abs(wave.amplMax / wave.amplMin);

            if (wave.verticalAsummetry > 100)
            {
                Console.WriteLine();
            }
            wave.horizontalAsymmetry[0] = wave.nullPoint[1] - wave.nullPoint[0];
            wave.horizontalAsymmetry[1] = wave.nullPoint[2] - wave.nullPoint[1];
            //wave.horizontalAsymmetry = (wave.nullPoint[1] - wave.nullPoint[0]) / (wave.nullPoint[2] - wave.nullPoint[1]);
            wave.totalHeight = Math.Abs(wave.amplMax) + Math.Abs(wave.amplMin);

            wave.rms = Math.Sqrt(rms/countRMS);

            return wave;
        }

        public double sigma(List<double> listRMS)
        {
            double mid = 0;
            double s = 0;

            if (listRMS.Count() > 0)
            {
                foreach (double d in listRMS)
                {
                    mid += d*d;
                }

                return Math.Sqrt(mid / listRMS.Count());
            }

            return Double.NaN;
        }

        public double significantHeights(List<double> listRMS)
        {
            double s = 4.04 * sigma(listRMS);
            return s;
        }

        double heightOneThird(List<double> listHeights)
        {
            int size = 0;
            double heightSignificant = 0;
            List<double> heights = new List<double>(listHeights);
            int N = heights.Count();

            size = 2 * (N / 3);

            if (N > 1)
            {
                quickSort(heights, 0, (int)N - 1);
            }

            double tmp = N - size;

            for(int i = size; i < N; i++)
            {
                heightSignificant += heights[i];
            }

            return (heightSignificant/(N - size));
        }

        double setSigma(List<double> listHeights)
        {
            return sigma(listHeights);
        }

        void setHeights(List<double> listHeihtsZDC, List<double> listHeihtsZUC, List<double> listRmsZDC, List<double> listRmsZUC)
        {
            heights zuc = new heights();
            heights zdc = new heights();

            zdc.significantHeight = significantHeights(listRmsZDC);
            zdc.heightOneThird = heightOneThird(listHeihtsZDC);
            zdc.sigma = setSigma(listRmsZDC);
            listHeightsZDC = zdc;

            zuc.significantHeight = significantHeights(listRmsZUC);
            zuc.heightOneThird = heightOneThird(listHeihtsZUC);
            zuc.sigma = setSigma(listRmsZUC);
            listHeightsZUC = zuc;

        }

        /*void calculateMiddleAsummetry()
        {
            midCloudsZDCVertAsum /= listRmsZDC.Count();
            midCloudsZUCVertAsum /= listRmsZUC.Count();
            midCloudsZDCHorAsum /= listRmsZDC.Count();
            midCloudsZUCHorAsum /= listRmsZUC.Count();
        }*/

        List<double> calculateClouds()
        {
            cloudsVertZDC = new double[calculatingWaves.Count()][];
            cloudsHorZDC = new double[calculatingWaves.Count()][];
            cloudsVertZUC = new double[calculatingWaves.Count()][];
            cloudsHorZUC = new double[calculatingWaves.Count()][];

            shiftCloudsHorZUC = 0;
            shiftCloudsHorZDC = 0;
            shiftCloudsVertZUC = 0;
            shiftCloudsVertZDC = 0;
            double x, y;
            int i = 0;
            double midCrestAZDC, midThroughAZDC, midCrestAZUC, midThroughAZUC;
            midCrestAZDC = midThroughAZDC = midCrestAZUC = midThroughAZUC = 0;

            for (int k = 0; k < listCrestAZDC.Count(); k++)
            {
                midCrestAZDC += listCrestAZDC[k];
                midThroughAZDC += listThroughAZDC[k];
            }

            midCrestAZUC /= listCrestAZDC.Count();
            midThroughAZDC /= listCrestAZDC.Count();

            for (int k = 0; k < listCrestAZUC.Count(); k++)
            {
                midCrestAZUC += listCrestAZUC[k];
                midThroughAZUC += listThroughAZUC[k];
            }

            midCrestAZUC /= listCrestAZUC.Count();
            midThroughAZUC /= listCrestAZUC.Count();

            foreach (waveData wave in calculatingWaves)
            {
                cloudsVertZDC[i] = new double[2];
                cloudsHorZDC[i] = new double[2];
                cloudsVertZUC[i] = new double[2];
                cloudsHorZUC[i] = new double[2];

                switch (wave.type)
                {
                    case typeCrossing.ZDC:
                        x = wave.totalHeight / listHeightsZDC.heightOneThird;
                        //y = Math.Sign(wave.verticalAsummetry - 1) * Math.Pow(wave.verticalAsummetry, Math.Sign(wave.verticalAsummetry - 1));//y = Math.Sign(wave.verticalAsummetry - 1) * wave.verticalAsummetry;
                        y = (Math.Abs(wave.amplMax / midCrestAZDC) - Math.Abs(wave.amplMin / midCrestAZDC)) / (Math.Abs(wave.amplMax / midCrestAZDC) + Math.Abs(wave.amplMin / midCrestAZDC));
                        cloudsVertZDC[i][0] = x;
                        cloudsVertZDC[i][1] = y;
                        shiftCloudsVertZDC += y;
                        //y = Math.Sign(wave.horizontalAsymmetry - 1) * wave.horizontalAsymmetry;
                        //y = Math.Sign(wave.horizontalAsymmetry - 1) * Math.Pow(wave.horizontalAsymmetry, Math.Sign(wave.horizontalAsymmetry - 1));
                        y = (Math.Abs(wave.horizontalAsymmetry[1] / midCrestHorZDC) - Math.Abs(wave.horizontalAsymmetry[0] / midThroughHorZDC)) / (Math.Abs(wave.horizontalAsymmetry[1] / midCrestHorZDC) + Math.Abs(wave.horizontalAsymmetry[0] / midThroughHorZDC));
                        cloudsHorZDC[i][0] = x;
                        cloudsHorZDC[i][1] = y;
                        shiftCloudsHorZDC += y;
                        break;

                    case typeCrossing.ZUC:
                        x = wave.totalHeight / listHeightsZUC.heightOneThird;

                        y = (Math.Abs(wave.amplMax / midCrestAZUC) - Math.Abs(wave.amplMin / midCrestAZUC)) / (Math.Abs(wave.amplMax / midCrestAZUC) + Math.Abs(wave.amplMin / midCrestAZUC));
                        //y = Math.Sign(wave.verticalAsummetry - 1) * Math.Pow(wave.verticalAsummetry, Math.Sign(wave.verticalAsummetry - 1));
                        //y = Math.Sign(wave.verticalAsummetry - 1) * wave.verticalAsummetry;
                        cloudsVertZUC[i][0] = x;
                        cloudsVertZUC[i][1] = y;
                        shiftCloudsVertZUC += y;
                        //y = Math.Sign(wave.horizontalAsymmetry - 1) * Math.Pow(wave.horizontalAsymmetry, Math.Sign(wave.horizontalAsymmetry - 1));
                        //y = Math.Sign(wave.horizontalAsymmetry - 1) * wave.horizontalAsymmetry;
                        y = (Math.Abs(wave.horizontalAsymmetry[0] / midCrestHorZUC) - Math.Abs(wave.horizontalAsymmetry[1] / midThroughHorZUC)) / (Math.Abs(wave.horizontalAsymmetry[0] / midCrestHorZUC) + Math.Abs(wave.horizontalAsymmetry[1] / midThroughHorZUC));
                        cloudsHorZUC[i][0] = x;
                        cloudsHorZUC[i][1] = y;
                        shiftCloudsHorZUC += y;
                        break;
                }

                i++;
            }

            shiftCloudsHorZUC /= i;
            shiftCloudsHorZDC /= i;
            shiftCloudsVertZUC /= i;
            shiftCloudsVertZDC /= i;

            return new List<double>() { shiftCloudsHorZUC, shiftCloudsHorZDC, shiftCloudsVertZUC, shiftCloudsVertZDC };
        }

        public bool calculateSingleWave(double[] arrT, double[] arrS)
        {
            waveData newWave;
            //midCloudsZDCVertAsum = midCloudsZUCVertAsum = midCloudsZDCHorAsum = midCloudsZUCHorAsum = 0;

            midCrestHorZDC = midThroughHorZDC = midCrestHorZUC = midThroughHorZUC = 0;

            for (int i = 0; i < arrT.Count(); i++)
            {
                if (arrS[i] * arrS[i + 1] < 0)
                {
                    typeCrossing type;

                    if(arrS[i] > 0)
                    {
                        type = typeCrossing.ZDC;
                    }
                    else
                    {
                        type = typeCrossing.ZUC;
                    }

                    newWave = getSingleWave(i, type, arrT, arrS);

                    if(newWave.totalHeight == 0.0)
                    {
                        setHeights(listHeihtsZDC, listHeihtsZUC, listRmsZDC, listRmsZUC);
                        calculateMiddleHorAsummetry();
                        calculateProbabilities();
                        calculateSighificiantPeriods();
                        calculateClouds();

                        return true;
                    }

                    if (newWave.type == typeCrossing.ZDC)
                    {
                        listHeihtsZDC.Add(newWave.totalHeight);
                        listCrestAZDC.Add(newWave.amplMax);
                        listThroughAZDC.Add(-newWave.amplMin);
                        listRmsZDC.Add(newWave.rms);
                        midCrestHorZDC += newWave.horizontalAsymmetry[0];
                        midThroughHorZDC += newWave.horizontalAsymmetry[1];
                        //midCloudsZDCVertAsum += newWave.verticalAsummetry;
                        //midCloudsZDCHorAsum += newWave.horizontalAsymmetry;
                    }
                    else
                    {
                        listHeihtsZUC.Add(newWave.totalHeight);
                        listCrestAZUC.Add(newWave.amplMax);
                        listThroughAZUC.Add(-newWave.amplMin);
                        listRmsZUC.Add(newWave.rms);
                        midCrestHorZUC += newWave.horizontalAsymmetry[0];
                        midThroughHorZUC += newWave.horizontalAsymmetry[1];
                        //midCloudsZUCVertAsum += newWave.verticalAsummetry;
                        //midCloudsZUCHorAsum += newWave.horizontalAsymmetry;
                    }

                    calculatingWaves.Add(newWave);
                }
            }

            //calculateProbabilities();
            //calculateSighificiantPeriods();
            return true;
        }

        void calculateMiddleHorAsummetry()
        {
            midCrestHorZDC /= listRmsZDC.Count();
            midThroughHorZDC /= listRmsZDC.Count();
            midCrestHorZUC /= listRmsZUC.Count();
            midThroughHorZUC /= listRmsZUC.Count();
        }

        void calculateSighificiantPeriods()
        {
            int i = 0;
            int time = T;
            double sumT = 0.0;

            foreach (waveData w in calculatingWaves)
            {
                if (w.nullPoint[2] < time)
                {
                    sumT += w.nullPoint[2] - w.nullPoint[0];
                    i += 1;
                }
                else
                {
                    sighificiantPeriods.Add(sumT / i);
                    i = 0;
                    sumT = 0;
                    time += T;
                }
            }
        }
        void calculateProbabilities()
        {
            setListProbabilities(listHeihtsZDC, listCrestAZDC, listThroughAZDC, typeCrossing.ZDC);
            setListProbabilities(listHeihtsZUC, listCrestAZUC, listThroughAZUC, typeCrossing.ZUC);
        }
        private void setListProbabilities(List<double> listH, List<double> listCA,
                                         List<double> listTA, typeCrossing type)
        {
            probability obj;
            double waveFrequency, signH, N;
            heights h;

            List<double> listHeights = new List<double>(listH);
            List<double> listCrestA = new List<double>(listCA);
            List<double> listThroughA = new List<double>(listTA);

            N = listHeights.Count();

            if (type == typeCrossing.ZDC)
            {
                h = listHeightsZDC;
            }
            else
            {
                h = listHeightsZUC;
            }

            if (N > 1)
            {
                quickSort(listHeights, 0, (int)N - 1);
            }

            if (listCrestA.Count() > 1)
            {
                quickSort(listCrestA, 0, listCrestA.Count() - 1);
            }
            
            if (listThroughA.Count() > 1)
            {
                quickSort(listThroughA, 0, listThroughA.Count() - 1);
            }

            for(int i = 0; i < N; i++)
            {
                //signH = Math.Pow(h.significantHeight,2);
                waveFrequency = (N-i)/N;
                obj.H = listHeights[i];
                obj.experP = waveFrequency;
                //obj.experP = Math.Exp(-2 * Math.Pow(listHeights[i] / h.significantHeight, 2));//  /Hs
                //obj.teorP = exp(-obj.H * obj.H/(8*h.at(type).sigma * h.at(type).sigma));
                obj.crestP = Math.Exp(-2 * Math.Pow(2.0 * listCrestA[i]/h.significantHeight, 2));
                obj.troughP = Math.Exp(-2 * Math.Pow(2.0 * listThroughA[i] / h.significantHeight, 2));//A/As Hs/2
                obj.teorP = Math.Exp(-obj.H * obj.H / (8.0 * h.sigma * h.sigma));

                if (type == typeCrossing.ZDC)
                {
                    listProbabilitiesZDC.Add(obj);
                }
                else
                {
                    listProbabilitiesZUC.Add(obj);
                }
            }
        }

    }
}

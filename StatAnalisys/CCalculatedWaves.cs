using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatAnalisys
{
    public enum typeCrossing { ZDC, ZUC};
    struct waveData
    {
        public typeCrossing type;
        public double amplMax;
        public double amplMin;
        public double totalHeight;
        public double sec;
        public double verticalAsummetry;
        public double horizontalAsymmetry;
        public double[] nullPoint;
        public double trough;
        public double ridge;
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

    class CCalculatedWaves
    {
        List<CSingleWave> waves = new  List<CSingleWave>();
        public CSingleWave this[int index]
        { 
            get
            {
                return waves.ElementAt(index);
            }
        }

        public void calculateDatas(double[] arrT, double[][] arrS)
        {
            for (int i = 0; i < arrS.Count(); i++)
            {
                CSingleWave wave = new CSingleWave();
                if (wave.calculateSingleWave(arrT, arrS[i]))
                {
                    waves.Add(wave);
                }
            }
        }
    }

    class CSingleWave
    {
        List<waveData> listCalculatedDatas = new List<waveData>();
        heights listHeightsZDC;
        heights listHeightsZUC;
        public List<probability> listProbabilitiesZDC = new List<probability>();
        public List<probability> listProbabilitiesZUC = new List<probability>();
        public List<waveData> calculatingWaves = new List<waveData>();

        public List<double> listHeihtsZDC = new List<double>();
        public List<double> listHeihtsZUC = new List<double>();
        public List<double> listCrestAZDC = new List<double>();
        public List<double> listCrestAZUC = new List<double>();
        public List<double> listThroughAZDC = new List<double>();
        public List<double> listThroughAZUC = new List<double>();

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
            if (i < r)
                quickSort(a, i, r);

            if (l < j)
                quickSort(a, l, j);
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
            int sizeT = arrT.Count();
            double currentPointSec, currentPointShift;
            waveData wave = new waveData();
            wave.nullPoint = new double[3];
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

                currentPointSec = arrT[i];
                currentPointShift = arrS[i];
            }
            wave.verticalAsummetry = Math.Abs(wave.amplMax / wave.amplMin);
            wave.horizontalAsymmetry = (wave.nullPoint[1] - wave.nullPoint[0]) / (wave.nullPoint[2] - wave.nullPoint[1]);
            wave.totalHeight = Math.Abs(wave.amplMax) + Math.Abs(wave.amplMin);

            if (wave.type == typeCrossing.ZDC)
            {
                listHeihtsZDC.Add(wave.totalHeight);
                listCrestAZDC.Add(wave.amplMax);
                listThroughAZDC.Add(-wave.amplMin);
            }
            else
            {
                listHeihtsZUC.Add(wave.totalHeight);
                listCrestAZUC.Add(wave.amplMax);
                listThroughAZUC.Add(-wave.amplMin);
            }
            return wave;
        }
        double significantHeights(List<double> listHeights)
        {
            double tmp = listHeights.Count();
            double tmpHeight = 0;
            double heightSignificant = 0;

            for (int i = 0; i < listHeights.Count(); i++)
            {
                tmpHeight = listHeights[i];
                heightSignificant += tmpHeight;
            }

            tmp = heightSignificant / listHeights.Count();
            return Math.Sqrt(4.04 * heightSignificant / listHeights.Count());
        }

        double heightOneThird(List<double> listHeights)
        {
            int size = 0;
            double heightSignificant = 0;
            size = 2 * (listHeights.Count()/3);
            double tmp = listHeights.Count() - size;
            /*if (listHeights.Count() > 1)
            {
                quickSort(listHeights, 0, listHeights.Count() - 1);
            }*/

            for(int i = size; i < listHeights.Count(); i++)
            {
                heightSignificant += listHeights[i];
            }
            return (heightSignificant/(listHeights.Count() - size));
        }

        double setSigma(List<double> listHeights, double sighificiantHeight)
        {
            //float tmp = listHeights.count();
            double sigma = 0;
            //if sign heights != 0
            for(int i = 0; i < listHeights.Count(); i++)
            {
                sigma += Math.Sqrt(Math.Pow(listHeights[i] - sighificiantHeight, 2));
            }
            return (sigma/listHeights.Count());

        }
        void setHeights(List<double> listHeihtsZDC, List<double> listHeihtsZUC)
        {
            heights zuc, zdc;

            zuc = new heights();
            zdc = new heights();
            zdc.significantHeight = significantHeights(listHeihtsZDC);
            zdc.heightOneThird = heightOneThird(listHeihtsZDC);
            zdc.sigma = setSigma(listHeihtsZDC, zdc.heightOneThird);
            listHeightsZDC = zdc;

            zuc.significantHeight = significantHeights(listHeihtsZUC);
            zuc.heightOneThird = heightOneThird(listHeihtsZUC);
            zuc.sigma = setSigma(listHeihtsZUC, zuc.heightOneThird);
            listHeightsZUC = zuc;

        }
        public bool calculateSingleWave(double[] arrT, double[] arrS)
        {
            waveData newWave;

            for (int i = 0; i < arrT.Count() - 1; i++)
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
                        setHeights(listHeihtsZDC, listHeihtsZUC);
                        calculateProbabilities();
                        return true;
                    }
                    calculatingWaves.Add(newWave);
                }
            }

            calculateProbabilities();
            return true;
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
                signH = Math.Pow(h.significantHeight,2);
                waveFrequency = (N-i)/N;
                obj.H = listHeights[i];
                obj.experP = waveFrequency;
                //obj.teorP = exp(-obj.H * obj.H/(8*h.at(type).sigma * h.at(type).sigma));
                obj.crestP = Math.Exp(- 2 * Math.Pow(2 * listCrestA[i]/h.significantHeight, 2));
                obj.troughP = Math.Exp(-2 * Math.Pow(2 * listThroughA[i] / h.significantHeight, 2));
                obj.teorP = Math.Exp(-obj.H * obj.H / (8 * h.sigma * h.sigma));

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

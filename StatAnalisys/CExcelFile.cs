using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelLibrary.CompoundDocumentFormat;
using ExcelLibrary.SpreadSheet;
using System.Windows.Forms;

namespace StatAnalisys
{
    class CExcelFile
    {
        void fillCellBackround(List<Cell> listCells, System.Drawing.Color color)
        {
            foreach (Cell c in listCells)
            {
                c.Style = new CellStyle(color);
            }
        }

        public bool saveXLS(Dictionary<string, CCalculatedWaves> dictionaryFiles)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XLS file|*.xls";
            saveFileDialog.Title = "Save XLS file";
            DialogResult result = saveFileDialog.ShowDialog();
            saveFileDialog.RestoreDirectory = true;

            Workbook workbook = new Workbook();
            Worksheet worksheetGeneral = new Worksheet("In the all records in file");
            Worksheet worksheetForeach = new Worksheet("In the each record of file");

            if (result == DialogResult.OK)
            {
                if (saveFileDialog.FileName != "")
                {
                    try
                    {
                        if (saveFileDialog.CheckPathExists)
                        {
                            //create new xls file
                            string file = saveFileDialog.FileName;

                            worksheetGeneral.Cells[0, 1] = new Cell("In the all records in file");
                            worksheetForeach.Cells[0, 1] = new Cell("In the each record of file");
                            int rowGeneral, rowForeach;
                            rowGeneral = rowForeach = 2;

                            worksheetGeneral.Cells.ColumnWidth[1, 2] = 9000;
                            worksheetForeach.Cells.ColumnWidth[1, 2] = 9000;

                            foreach (KeyValuePair<string, CCalculatedWaves> p in dictionaryFiles)
                            {
                                //worksheetGeneral
                                worksheetGeneral.Cells[rowGeneral, 1] = new Cell("File");
                                worksheetGeneral.Cells[rowGeneral, 2] = new Cell(p.Key);

                                worksheetGeneral.Cells[rowGeneral + 4, 1] = new Cell("Significiant Heights");
                                worksheetGeneral.Cells[rowGeneral + 4, 2] = new Cell("zero-up-crossing wave");
                                worksheetGeneral.Cells[rowGeneral + 5, 2] = new Cell("zero-down-crossing wave");
                                worksheetGeneral.Cells[rowGeneral + 4, 3] = new Cell((double)p.Value.generalSighHZUC);
                                worksheetGeneral.Cells[rowGeneral + 5, 3] = new Cell((double)p.Value.generalSighHZDC);

                                worksheetGeneral.Cells[rowGeneral + 7, 1] = new Cell("Count Rogue Waves");
                                worksheetGeneral.Cells[rowGeneral + 7, 2] = new Cell("zero-up-crossing wave");
                                worksheetGeneral.Cells[rowGeneral + 8, 2] = new Cell("zero-down-crossing wave");
                                worksheetGeneral.Cells[rowGeneral + 9, 2] = new Cell("Generally");
                                worksheetGeneral.Cells[rowGeneral + 7, 3] = new Cell((short)p.Value.generalCountRogueWavesZUC);
                                worksheetGeneral.Cells[rowGeneral + 8, 3] = new Cell((short)p.Value.generalCountRogueWavesZDC);
                                worksheetGeneral.Cells[rowGeneral + 9, 3] = new Cell((short)(p.Value.generalCountRogueWavesZUC + p.Value.generalCountRogueWavesZDC));


                                worksheetGeneral.Cells[rowForeach + 11, 1] = new Cell("Clouds for Vertical Asymmetry");
                                worksheetGeneral.Cells[rowForeach + 11, 2] = new Cell("zero-up-crossing wave");
                                worksheetGeneral.Cells[rowForeach + 12, 2] = new Cell("zero-down-crossing wave");
                                worksheetGeneral.Cells[rowForeach + 14, 1] = new Cell("Clouds for Horizontal Asymmetry");
                                worksheetGeneral.Cells[rowForeach + 14, 2] = new Cell("zero-up-crossing wave");
                                worksheetGeneral.Cells[rowForeach + 15, 2] = new Cell("zero-down-crossing wave");
                                worksheetGeneral.Cells[rowForeach + 11, 3] = new Cell((p.Value.generallShiftCloudsVertZUC > 0) ? "+" : "-");
                                worksheetGeneral.Cells[rowForeach + 12, 3] = new Cell((p.Value.generallShiftCloudsVertZDC > 0) ? "+" : "-");
                                worksheetGeneral.Cells[rowForeach + 14, 3] = new Cell((p.Value.generallShiftCloudsHorZUC > 0) ? "+" : "-");
                                worksheetGeneral.Cells[rowForeach + 15, 3] = new Cell((p.Value.generallShiftCloudsHorZDC > 0) ? "+" : "-");

                                //worksheetForeach
                                worksheetForeach.Cells[rowForeach, 1] = new Cell("File");
                                worksheetForeach.Cells[rowForeach, 2] = new Cell(p.Key);

                                worksheetForeach.Cells[rowForeach + 4, 1] = new Cell("Count Rogue Waves");
                                worksheetForeach.Cells[rowForeach + 4, 2] = new Cell("zero-up-crossing wave");
                                worksheetForeach.Cells[rowForeach + 5, 2] = new Cell("zero-down-crossing wave");
                                worksheetForeach.Cells[rowForeach + 6, 2] = new Cell("Generally");
                                worksheetForeach.Cells[rowForeach + 4, 3] = new Cell((short)p.Value.countRogueWavesZUC);
                                worksheetForeach.Cells[rowForeach + 5, 3] = new Cell((short)p.Value.countRogueWavesZDC);
                                worksheetForeach.Cells[rowForeach + 6, 3] = new Cell((short)(p.Value.countRogueWavesZDC + p.Value.countRogueWavesZUC));

                                worksheetForeach.Cells[rowForeach + 8, 1] = new Cell("Wave number");

                                worksheetForeach.Cells[rowForeach + 10, 1] = new Cell("Significiant Height");
                                worksheetForeach.Cells[rowForeach + 10, 2] = new Cell("zero-up-crossing wave");
                                worksheetForeach.Cells[rowForeach + 11, 2] = new Cell("zero-down-crossing wave");

                                worksheetForeach.Cells[rowForeach + 13, 1] = new Cell("Height one third of highest waves");
                                worksheetForeach.Cells[rowForeach + 13, 2] = new Cell("zero-up-crossing wave");
                                worksheetForeach.Cells[rowForeach + 14, 2] = new Cell("zero-down-crossing wave");

                                worksheetForeach.Cells[rowForeach + 16, 1] = new Cell("Clouds for Vertical Asymmetry");
                                worksheetForeach.Cells[rowForeach + 16, 2] = new Cell("zero-up-crossing wave");
                                worksheetForeach.Cells[rowForeach + 17, 2] = new Cell("zero-down-crossing wave");
                                worksheetForeach.Cells[rowForeach + 18, 1] = new Cell("Clouds for Horizontal Asymmetry");
                                worksheetForeach.Cells[rowForeach + 18, 2] = new Cell("zero-up-crossing wave");
                                worksheetForeach.Cells[rowForeach + 19, 2] = new Cell("zero-down-crossing wave");


                                for (int i = 0; i < p.Value.waves.Count(); i++)
                                {
                                    worksheetForeach.Cells[rowForeach + 8, i + 3] = new Cell((short)i);

                                    worksheetForeach.Cells[rowForeach + 10, i + 3] = new Cell((double)p.Value.waves[i].heightsZUC.significantHeight);
                                    worksheetForeach.Cells[rowForeach + 13, i + 3] = new Cell((double)p.Value.waves[i].heightsZUC.heightOneThird);
                                    worksheetForeach.Cells[rowForeach + 11, i + 3] = new Cell((double)p.Value.waves[i].heightsZDC.significantHeight);
                                    worksheetForeach.Cells[rowForeach + 14, i + 3] = new Cell((double)p.Value.waves[i].heightsZDC.heightOneThird);

                                    worksheetForeach.Cells[rowForeach + 16, i + 3] = new Cell((p.Value.waves[i].shiftCloudsVertZUC > 0) ? "+" : "-");
                                    worksheetForeach.Cells[rowForeach + 18, i + 3] = new Cell((p.Value.waves[i].shiftCloudsHorZUC > 0) ? "+" : "-");
                                    worksheetForeach.Cells[rowForeach + 17, i + 3] = new Cell((p.Value.waves[i].shiftCloudsVertZDC > 0) ? "+" : "-");
                                    worksheetForeach.Cells[rowForeach + 19, i + 3] = new Cell((p.Value.waves[i].shiftCloudsHorZDC > 0) ? "+" : "-"); 
                                }

                                rowForeach += 23;
                                rowGeneral += 18;
                            }

                            workbook.Worksheets.Add(worksheetGeneral);
                            workbook.Worksheets.Add(worksheetForeach);
                            workbook.Save(file);

                            Workbook book = Workbook.Load(file);
                            Worksheet sheet = book.Worksheets[0];

                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Given Path does not exist");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            return true;
        }
    }
}

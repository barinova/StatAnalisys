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
            Worksheet worksheet = new Worksheet("First Sheet");

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
                            int row = 0;
                            
                            foreach (KeyValuePair<string, CCalculatedWaves> p in dictionaryFiles)
                            {
                                worksheet.Cells[row, 1] = new Cell("File");
                                worksheet.Cells[row, 2] = new Cell(p.Key);

                                worksheet.Cells[row + 2, 1] = new Cell("In the all records in file");

                                worksheet.Cells[row + 4, 1] = new Cell("Significiant Heights");
                                worksheet.Cells[row + 4, 2] = new Cell("zero-up-crossing wave");
                                worksheet.Cells[row + 5, 2] = new Cell("zero-down-crossing wave");
                                worksheet.Cells[row + 4, 3] = new Cell((decimal)p.Value.generalSighHZUC);
                                worksheet.Cells[row + 5, 3] = new Cell((decimal)p.Value.generalSighHZDC);

                                worksheet.Cells[row + 7, 1] = new Cell("Count Rogue Waves");
                                worksheet.Cells[row + 7, 2] = new Cell("zero-up-crossing wave");
                                worksheet.Cells[row + 8, 2] = new Cell("zero-down-crossing wave");
                                worksheet.Cells[row + 9, 2] = new Cell("Generally");
                                worksheet.Cells[row + 7, 3] = new Cell((short)p.Value.generalCountRogueWavesZUC);
                                worksheet.Cells[row + 8, 3] = new Cell((short)p.Value.generalCountRogueWavesZDC);
                                worksheet.Cells[row + 9, 3] = new Cell((short)(p.Value.generalCountRogueWavesZUC + p.Value.generalCountRogueWavesZDC));

                                worksheet.Cells[row + 11, 1] = new Cell("In the each record of file");

                                worksheet.Cells[row + 14, 1] = new Cell("Count Rogue Waves");
                                worksheet.Cells[row + 14, 2] = new Cell("zero-up-crossing wave");
                                worksheet.Cells[row + 15, 2] = new Cell("zero-down-crossing wave");
                                worksheet.Cells[row + 16, 2] = new Cell("Generally");
                                worksheet.Cells[row + 14, 3] = new Cell((short)p.Value.countRogueWavesZUC);
                                worksheet.Cells[row + 15, 3] = new Cell((short)p.Value.countRogueWavesZDC);
                                worksheet.Cells[row + 16, 3] = new Cell((short)(p.Value.countRogueWavesZDC + p.Value.countRogueWavesZUC));

                                worksheet.Cells[row + 18, 0] = new Cell("Wave number");

                                worksheet.Cells[row + 20, 1] = new Cell("Significiant Height");
                                worksheet.Cells[row + 20, 2] = new Cell("zero-up-crossing wave");
                                worksheet.Cells[row + 21, 2] = new Cell("zero-down-crossing wave");

                                worksheet.Cells[row + 23, 1] = new Cell("Height one third of highest waves");
                                worksheet.Cells[row + 23, 2] = new Cell("zero-up-crossing wave");
                                worksheet.Cells[row + 24, 2] = new Cell("zero-down-crossing wave");

                                worksheet.Cells[row + 26, 1] = new Cell("Clouds for Vertical Asymmetry");
                                worksheet.Cells[row + 26, 2] = new Cell("zero-up-crossing wave");
                                worksheet.Cells[row + 27, 2] = new Cell("zero-down-crossing wave");
                                worksheet.Cells[row + 28, 1] = new Cell("Clouds for Horizontal Asymmetry");
                                worksheet.Cells[row + 28, 2] = new Cell("zero-up-crossing wave");
                                worksheet.Cells[row + 29, 2] = new Cell("zero-down-crossing wave");


                                for (int i = 0; i < p.Value.waves.Count(); i++)
                                {
                                    worksheet.Cells[row + 18, i + 3] = new Cell((short)i);

                                    worksheet.Cells[row + 20, i + 3] = new Cell((decimal)p.Value.waves[i].heightsZUC.significantHeight);
                                    worksheet.Cells[row + 23, i + 3] = new Cell((decimal)p.Value.waves[i].heightsZUC.heightOneThird);
                                    worksheet.Cells[row + 21, i + 3] = new Cell((decimal)p.Value.waves[i].heightsZDC.significantHeight);
                                    worksheet.Cells[row + 24, i + 3] = new Cell((decimal)p.Value.waves[i].heightsZDC.heightOneThird);

                                    worksheet.Cells[row + 26, i + 3] = new Cell((p.Value.waves[i].shiftCloudsVertZUC > 0) ? "+" : "-");
                                    worksheet.Cells[row + 28, i + 3] = new Cell((p.Value.waves[i].shiftCloudsHorZUC > 0) ? "+" : "-");
                                    worksheet.Cells[row + 27, i + 3] = new Cell((p.Value.waves[i].shiftCloudsVertZDC > 0) ? "+" : "-");
                                    worksheet.Cells[row + 29, i + 3] = new Cell((p.Value.waves[i].shiftCloudsHorZDC > 0) ? "+" : "-"); 
                                }
                                row += 32;
                            }

                            workbook.Worksheets.Add(worksheet);
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

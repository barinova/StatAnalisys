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
        public bool saveXLS(Dictionary<string, CCalculatedWaves> dictionaryFiles)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XLS file|*.xls";
            saveFileDialog.Title = "Save XLS file";
            DialogResult result = saveFileDialog.ShowDialog();
            saveFileDialog.RestoreDirectory = true;

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
                            Workbook workbook = new Workbook();
                            Worksheet worksheet = new Worksheet("First Sheet");
                            int row = 0;
                            
                            foreach (KeyValuePair<string, CCalculatedWaves> p in dictionaryFiles)
                            {
                                worksheet.Cells[row++, 1] = new Cell("File");
                                worksheet.Cells[row, 2] = new Cell(p.Key);
                                worksheet.Cells[row++, 1] = new Cell("Count Rogue Wave");
                                worksheet.Cells[row, 2] = new Cell((short)p.Value.countRogueWave);

                                worksheet.Cells[row++, 0] = new Cell("Number");

                                worksheet.Cells[row + 2, 0] = new Cell("Significiant Height of zero-up-crossing wave");
                                worksheet.Cells[row + 3, 0] = new Cell("Height of one third of zero-up-crossing wave");
                                worksheet.Cells[row + 4, 0] = new Cell("Significiant Height of zero-down-crossing wave");
                                worksheet.Cells[row + 5, 0] = new Cell("Height of one third of zero-down-crossing wave");

                                worksheet.Cells[row + 7, 0] = new Cell("Clouds for Vertical - zero-up-crossing wave");
                                worksheet.Cells[row + 8, 0] = new Cell("Clouds for Horizontal - zero-up-crossing wave");
                                worksheet.Cells[row + 9, 0] = new Cell("Clouds for Vertical - zero-down-crossing wave");
                                worksheet.Cells[row + 10, 0] = new Cell("Clouds for Horizontal - zero-down-crossing wave");

                                for (int i = 0; i < p.Value.waves.Count(); i++)
                                {
                                    worksheet.Cells[row, i + 2] = new Cell((short)i);

                                    worksheet.Cells[row + 2, i + 2] = new Cell((decimal)p.Value.waves[i].heightsZUC.significantHeight);
                                    worksheet.Cells[row + 3, i + 2] = new Cell((decimal)p.Value.waves[i].heightsZUC.heightOneThird);
                                    worksheet.Cells[row + 4, i + 2] = new Cell((decimal)p.Value.waves[i].heightsZDC.significantHeight);
                                    worksheet.Cells[row + 5, i + 2] = new Cell((decimal)p.Value.waves[i].heightsZDC.heightOneThird);

                                    worksheet.Cells[row + 7, i + 2] = new Cell((decimal)p.Value.waves[i].cloudsVertZUC[i][1]);
                                    worksheet.Cells[row + 8, i + 2] = new Cell((decimal)p.Value.waves[i].cloudsHorZUC[i][1]);
                                    worksheet.Cells[row + 9, i + 2] = new Cell((decimal)p.Value.waves[i].cloudsVertZDC[i][1]);
                                    worksheet.Cells[row + 10, i + 2] = new Cell((decimal)p.Value.waves[i].cloudsHorZDC[i][1]); 
                                }

                                row += 15;
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

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
                                worksheet.Cells[row + 1, 1] = new Cell("Count Rogue Waves ZUC");
                                worksheet.Cells[row + 2, 1] = new Cell("Count Rogue Waves ZUC");
                                worksheet.Cells[row + 1, 2] = new Cell((short)p.Value.countRogueWavesZUC);
                                worksheet.Cells[row + 2, 2] = new Cell((short)p.Value.countRogueWavesZDC);
                                worksheet.Cells[row + 3, 1] = new Cell("Count Rogue Waves");
                                worksheet.Cells[row + 3, 2] = new Cell((short)p.Value.countRogueWavesZDC);
                                worksheet.Cells[row + 4, 1] = new Cell("Significiant HeightsZUC");
                                worksheet.Cells[row + 4, 2] = new Cell((decimal)p.Value.midSignificiantHeightsZUC);
                                worksheet.Cells[row + 5, 1] = new Cell("Significiant Heights ZDC");
                                worksheet.Cells[row + 5, 2] = new Cell((decimal)p.Value.midSignificiantHeightsZDC);


                                worksheet.Cells[row + 7, 0] = new Cell("Wave number");

                                worksheet.Cells[row + 9, 0] = new Cell("Significiant Height of zero-up-crossing wave");
                                worksheet.Cells[row + 10, 0] = new Cell("Height of one third of zero-up-crossing wave");
                                worksheet.Cells[row + 11, 0] = new Cell("Significiant Height of zero-down-crossing wave");
                                worksheet.Cells[row + 12, 0] = new Cell("Height of one third of zero-down-crossing wave");

                                worksheet.Cells[row + 14, 0] = new Cell("Clouds for Vertical - zero-up-crossing wave");
                                worksheet.Cells[row + 15, 0] = new Cell("Clouds for Horizontal - zero-up-crossing wave");
                                worksheet.Cells[row + 16, 0] = new Cell("Clouds for Vertical - zero-down-crossing wave");
                                worksheet.Cells[row + 17, 0] = new Cell("Clouds for Horizontal - zero-down-crossing wave");

                                for (int i = 0; i < p.Value.waves.Count(); i++)
                                {
                                    worksheet.Cells[row, i + 2] = new Cell((short)i);

                                    worksheet.Cells[row + 9, i + 2] = new Cell((decimal)p.Value.waves[i].heightsZUC.significantHeight);
                                    worksheet.Cells[row + 10, i + 2] = new Cell((decimal)p.Value.waves[i].heightsZUC.heightOneThird);
                                    worksheet.Cells[row + 11, i + 2] = new Cell((decimal)p.Value.waves[i].heightsZDC.significantHeight);
                                    worksheet.Cells[row + 12, i + 2] = new Cell((decimal)p.Value.waves[i].heightsZDC.heightOneThird);

                                    worksheet.Cells[row + 14, i + 2] = new Cell((p.Value.waves[i].shiftCloudsVertZDC > 0) ? "+" : "-");
                                    worksheet.Cells[row + 15, i + 2] = new Cell((p.Value.waves[i].shiftCloudsHorZUC > 0) ? "+" : "-");
                                    worksheet.Cells[row + 16, i + 2] = new Cell((p.Value.waves[i].shiftCloudsVertZDC > 0) ? "+" : "-");
                                    worksheet.Cells[row + 17, i + 2] = new Cell((p.Value.waves[i].shiftCloudsHorZDC > 0) ? "+" : "-"); 
                                }

                                fillCellBackround(new List<Cell>() { worksheet.Cells[row, 1], worksheet.Cells[row, 2] }, System.Drawing.Color.OrangeRed);
                                fillCellBackround(new List<Cell>() { worksheet.Cells[row + 1, 1], worksheet.Cells[row + 2, 1], worksheet.Cells[row + 3, 1] ,
                                    worksheet.Cells[row + 4, 1], worksheet.Cells[row + 5, 1], worksheet.Cells[row + 7, 0], worksheet.Cells[row + 9, 0], 
                                    worksheet.Cells[row + 10, 0], worksheet.Cells[row + 11, 0], worksheet.Cells[row + 12, 0],worksheet.Cells[row + 14, 0], 
                                    worksheet.Cells[row + 15, 0], worksheet.Cells[row + 16, 0], worksheet.Cells[row + 17, 0]}, System.Drawing.Color.Yellow);
                                
                                row += 20;
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

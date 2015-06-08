using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatAnalisys
{
    public partial class CLoadedFilesForm : Form
    {
        public CLoadedFilesForm(List<string> strs)
        {
            InitializeComponent();
            dataGridViewLoadedFiles.ColumnCount = 1;
            dataGridViewLoadedFiles.Columns[0].Width = 230;
            dataGridViewLoadedFiles.Columns[0].Name = "File";

            foreach (string str in strs)
            {
                dataGridViewLoadedFiles.Rows.Add(new string[] { str });
            }

            this.Show();
        }

        private void dataGridViewLoadedFiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string fileName = dataGridViewLoadedFiles.CurrentCell.Value.ToString();

            if (!String.IsNullOrEmpty(fileName))
            {
                this.Cursor = Cursors.WaitCursor;
                CallBackFileSelected.callbackFileSelectedEventHandler(fileName);

                this.Cursor = Cursors.Default;
            }

            this.Close();
        }
    }
}

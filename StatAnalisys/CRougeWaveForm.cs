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
    public partial class CRougeWaveForm : Form
    {
        public CRougeWaveForm()
        {
            InitializeComponent();
            tableLayoutPanelRougeWaves.AutoSize = true;
            tableLayoutPanelRougeWaves.RowCount = 1;
            tableLayoutPanelRougeWaves.ColumnCount = 2;
            tableLayoutPanelRougeWaves.Controls.Add(new Label() { Text = "Wave's number" }, 0, tableLayoutPanelRougeWaves.RowCount - 1);
            tableLayoutPanelRougeWaves.Controls.Add(new Label() { Text = "Found rouge waves" }, 1, tableLayoutPanelRougeWaves.RowCount - 1);

        }

        public void addRow(int number, int count)
        {
            int row = tableLayoutPanelRougeWaves.RowCount;
            tableLayoutPanelRougeWaves.RowCount = row + 1;
            tableLayoutPanelRougeWaves.Controls.Add(new Label() { Text = number.ToString()}, 0, row);
            tableLayoutPanelRougeWaves.Controls.Add(new Label() { Text = count.ToString()}, 1, row);
        }

    }
}

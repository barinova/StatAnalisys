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
        }

        public void addRow(string txt)
        {
            listBoxRougeWaves.Items.Add(txt);
        }
    }
}

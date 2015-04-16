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
    public partial class CRougeWaveForm : BaseForm
    {
        public CRougeWaveForm()
        {
            InitializeComponent();

            this.listViewRogueWaves.Columns.Add("Index", -2, HorizontalAlignment.Left);
            this.listViewRogueWaves.Columns.Add("Number of founded waves", -2, HorizontalAlignment.Left);
            this.listViewRogueWaves.View = View.Details;
        }

        public void addRow(string index, string numberFoundWaves)
        {
            ListViewItem item = new ListViewItem(new[] { index, numberFoundWaves });
            this.listViewRogueWaves.Items.Add(item);
        }

        private void listViewRogueWaves_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ListView)
            {
                ListView.SelectedListViewItemCollection item = (sender as ListView).SelectedItems;

                if (item.Count > 0)
                {
                    CallBackMy.callbackEventHandler(item[0].Text);
                }
            }
        }
    }
}

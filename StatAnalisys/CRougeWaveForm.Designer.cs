namespace StatAnalisys
{
    partial class CRougeWaveForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanelRougeWaves = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tableLayoutPanelRougeWaves
            // 
            this.tableLayoutPanelRougeWaves.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanelRougeWaves.ColumnCount = 1;
            this.tableLayoutPanelRougeWaves.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRougeWaves.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanelRougeWaves.Name = "tableLayoutPanelRougeWaves";
            this.tableLayoutPanelRougeWaves.RowCount = 1;
            this.tableLayoutPanelRougeWaves.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRougeWaves.Size = new System.Drawing.Size(461, 238);
            this.tableLayoutPanelRougeWaves.TabIndex = 0;
            this.tableLayoutPanelRougeWaves.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelRougeWaves_Paint);
            // 
            // CRougeWaveForm
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(492, 262);
            this.Controls.Add(this.tableLayoutPanelRougeWaves);
            this.Name = "CRougeWaveForm";
            this.Text = "Rouge waves";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRougeWaves;
    }
}
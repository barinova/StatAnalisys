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
            this.listViewRogueWaves = new System.Windows.Forms.ListView();
            this.labelRogueWavesNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewRogueWaves
            // 
            this.listViewRogueWaves.Location = new System.Drawing.Point(12, 33);
            this.listViewRogueWaves.Name = "listViewRogueWaves";
            this.listViewRogueWaves.Size = new System.Drawing.Size(185, 406);
            this.listViewRogueWaves.TabIndex = 4;
            this.listViewRogueWaves.UseCompatibleStateImageBehavior = false;
            this.listViewRogueWaves.SelectedIndexChanged += new System.EventHandler(this.listViewRogueWaves_SelectedIndexChanged);
            // 
            // labelRogueWavesNumber
            // 
            this.labelRogueWavesNumber.AutoSize = true;
            this.labelRogueWavesNumber.Location = new System.Drawing.Point(12, 9);
            this.labelRogueWavesNumber.Name = "labelRogueWavesNumber";
            this.labelRogueWavesNumber.Size = new System.Drawing.Size(0, 13);
            this.labelRogueWavesNumber.TabIndex = 5;
            // 
            // CRougeWaveForm
            // 
            this.ClientSize = new System.Drawing.Size(338, 455);
            this.Controls.Add(this.labelRogueWavesNumber);
            this.Controls.Add(this.listViewRogueWaves);
            this.Name = "CRougeWaveForm";
            this.Text = "Rouge waves";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewRogueWaves;
        private System.Windows.Forms.Label labelRogueWavesNumber;
    }
}
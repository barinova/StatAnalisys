namespace StatAnalisys
{
    partial class CLoadedFilesForm
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
            this.dataGridViewLoadedFiles = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoadedFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLoadedFiles
            // 
            this.dataGridViewLoadedFiles.AllowUserToAddRows = false;
            this.dataGridViewLoadedFiles.AllowUserToDeleteRows = false;
            this.dataGridViewLoadedFiles.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewLoadedFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLoadedFiles.Location = new System.Drawing.Point(12, 19);
            this.dataGridViewLoadedFiles.Name = "dataGridViewLoadedFiles";
            this.dataGridViewLoadedFiles.ReadOnly = true;
            this.dataGridViewLoadedFiles.Size = new System.Drawing.Size(279, 231);
            this.dataGridViewLoadedFiles.TabIndex = 0;
            this.dataGridViewLoadedFiles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLoadedFiles_CellContentClick);
            // 
            // CLoadedFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 262);
            this.Controls.Add(this.dataGridViewLoadedFiles);
            this.Name = "CLoadedFilesForm";
            this.Text = "CLoadedFilesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoadedFiles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLoadedFiles;
    }
}
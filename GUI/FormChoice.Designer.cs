
namespace GUI
{
    partial class FormChoice
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
            this.groupBoxChoice = new System.Windows.Forms.GroupBox();
            this.comboBoxChoice = new System.Windows.Forms.ComboBox();
            this.groupBoxPath = new System.Windows.Forms.GroupBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.labelFile = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxChoice.SuspendLayout();
            this.groupBoxPath.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxChoice
            // 
            this.groupBoxChoice.Controls.Add(this.comboBoxChoice);
            this.groupBoxChoice.Location = new System.Drawing.Point(39, 37);
            this.groupBoxChoice.Name = "groupBoxChoice";
            this.groupBoxChoice.Size = new System.Drawing.Size(280, 106);
            this.groupBoxChoice.TabIndex = 0;
            this.groupBoxChoice.TabStop = false;
            this.groupBoxChoice.Text = "&Select the source of data:";
            // 
            // comboBoxChoice
            // 
            this.comboBoxChoice.FormattingEnabled = true;
            this.comboBoxChoice.Items.AddRange(new object[] {
            "File",
            "Manual"});
            this.comboBoxChoice.Location = new System.Drawing.Point(22, 45);
            this.comboBoxChoice.Name = "comboBoxChoice";
            this.comboBoxChoice.Size = new System.Drawing.Size(230, 24);
            this.comboBoxChoice.TabIndex = 0;
            this.comboBoxChoice.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBoxPath
            // 
            this.groupBoxPath.Controls.Add(this.buttonBrowse);
            this.groupBoxPath.Controls.Add(this.textBoxFile);
            this.groupBoxPath.Controls.Add(this.labelFile);
            this.groupBoxPath.Enabled = false;
            this.groupBoxPath.Location = new System.Drawing.Point(40, 168);
            this.groupBoxPath.Name = "groupBoxPath";
            this.groupBoxPath.Size = new System.Drawing.Size(279, 77);
            this.groupBoxPath.TabIndex = 1;
            this.groupBoxPath.TabStop = false;
            this.groupBoxPath.Text = "&Choose path to a file:";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBrowse.Location = new System.Drawing.Point(224, 36);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(37, 23);
            this.buttonBrowse.TabIndex = 2;
            this.buttonBrowse.Text = "...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // textBoxFile
            // 
            this.textBoxFile.Location = new System.Drawing.Point(51, 36);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.ReadOnly = true;
            this.textBoxFile.Size = new System.Drawing.Size(167, 22);
            this.textBoxFile.TabIndex = 1;
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.Location = new System.Drawing.Point(14, 36);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(34, 17);
            this.labelFile.TabIndex = 0;
            this.labelFile.Text = "&File:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "txt";
            this.openFileDialog.Filter = "Text files (*.txt)|*.txt";
            this.openFileDialog.InitialDirectory = "D:\\Vsite\\seminar";
            // 
            // FormChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 284);
            this.Controls.Add(this.groupBoxPath);
            this.Controls.Add(this.groupBoxChoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChoice";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Word Sorter";
            this.groupBoxChoice.ResumeLayout(false);
            this.groupBoxPath.ResumeLayout(false);
            this.groupBoxPath.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxChoice;
        private System.Windows.Forms.ComboBox comboBoxChoice;
        private System.Windows.Forms.GroupBox groupBoxPath;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}
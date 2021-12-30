
namespace GUI
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonSort = new System.Windows.Forms.Button();
            this.groupBoxLanguages = new System.Windows.Forms.GroupBox();
            this.comboBoxLanguages = new System.Windows.Forms.ComboBox();
            this.groupBoxInsert = new System.Windows.Forms.GroupBox();
            this.textBoxWordList = new System.Windows.Forms.TextBox();
            this.textBoxSortedList = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxLanguages.SuspendLayout();
            this.groupBoxInsert.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonSort);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxLanguages);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxInsert);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBoxSortedList);
            this.splitContainer1.Panel2.Controls.Add(this.buttonClear);
            this.splitContainer1.Size = new System.Drawing.Size(594, 426);
            this.splitContainer1.SplitterDistance = 257;
            this.splitContainer1.TabIndex = 3;
            // 
            // buttonSort
            // 
            this.buttonSort.Enabled = false;
            this.buttonSort.Location = new System.Drawing.Point(159, 378);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(69, 27);
            this.buttonSort.TabIndex = 5;
            this.buttonSort.Text = "&Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // groupBoxLanguages
            // 
            this.groupBoxLanguages.Controls.Add(this.comboBoxLanguages);
            this.groupBoxLanguages.Location = new System.Drawing.Point(16, 285);
            this.groupBoxLanguages.Name = "groupBoxLanguages";
            this.groupBoxLanguages.Size = new System.Drawing.Size(225, 69);
            this.groupBoxLanguages.TabIndex = 4;
            this.groupBoxLanguages.TabStop = false;
            this.groupBoxLanguages.Text = "&Select a language";
            // 
            // comboBoxLanguages
            // 
            this.comboBoxLanguages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLanguages.FormattingEnabled = true;
            this.comboBoxLanguages.Items.AddRange(new object[] {
            "Chinese",
            "Croatian",
            "Dutch",
            "English",
            "French",
            "German",
            "Italian",
            "Japanese",
            "Korean",
            "Spanish"});
            this.comboBoxLanguages.Location = new System.Drawing.Point(14, 30);
            this.comboBoxLanguages.Name = "comboBoxLanguages";
            this.comboBoxLanguages.Size = new System.Drawing.Size(198, 24);
            this.comboBoxLanguages.TabIndex = 1;
            this.comboBoxLanguages.SelectedIndexChanged += new System.EventHandler(this.comboBoxLanguages_SelectedIndexChanged);
            // 
            // groupBoxInsert
            // 
            this.groupBoxInsert.Controls.Add(this.textBoxWordList);
            this.groupBoxInsert.Location = new System.Drawing.Point(15, 15);
            this.groupBoxInsert.Name = "groupBoxInsert";
            this.groupBoxInsert.Size = new System.Drawing.Size(226, 246);
            this.groupBoxInsert.TabIndex = 3;
            this.groupBoxInsert.TabStop = false;
            this.groupBoxInsert.Text = "&Insert words here:";
            // 
            // textBoxWordList
            // 
            this.textBoxWordList.Location = new System.Drawing.Point(6, 21);
            this.textBoxWordList.Multiline = true;
            this.textBoxWordList.Name = "textBoxWordList";
            this.textBoxWordList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxWordList.Size = new System.Drawing.Size(214, 216);
            this.textBoxWordList.TabIndex = 1;
            // 
            // textBoxSortedList
            // 
            this.textBoxSortedList.Location = new System.Drawing.Point(14, 30);
            this.textBoxSortedList.Multiline = true;
            this.textBoxSortedList.Name = "textBoxSortedList";
            this.textBoxSortedList.ReadOnly = true;
            this.textBoxSortedList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSortedList.Size = new System.Drawing.Size(299, 324);
            this.textBoxSortedList.TabIndex = 1;
            // 
            // buttonClear
            // 
            this.buttonClear.Enabled = false;
            this.buttonClear.Location = new System.Drawing.Point(239, 375);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(74, 30);
            this.buttonClear.TabIndex = 0;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Word Sorting";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxLanguages.ResumeLayout(false);
            this.groupBoxInsert.ResumeLayout(false);
            this.groupBoxInsert.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxLanguages;
        private System.Windows.Forms.GroupBox groupBoxInsert;
        private System.Windows.Forms.TextBox textBoxWordList;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.TextBox textBoxSortedList;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ComboBox comboBoxLanguages;
    }
}


namespace KonyvtarAsztaliKonzolos
{
    partial class FormBook
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
            this.label_Title = new System.Windows.Forms.Label();
            this.textBox_Title = new System.Windows.Forms.TextBox();
            this.textBox_Author = new System.Windows.Forms.TextBox();
            this.label_Author = new System.Windows.Forms.Label();
            this.label_PublishYear = new System.Windows.Forms.Label();
            this.numericUpDown_PublishYear = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_PageCount = new System.Windows.Forms.NumericUpDown();
            this.label_PageCount = new System.Windows.Forms.Label();
            this.button_Muvelet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PublishYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PageCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Location = new System.Drawing.Point(13, 73);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(26, 13);
            this.label_Title.TabIndex = 2;
            this.label_Title.Text = "Cím";
            // 
            // textBox_Title
            // 
            this.textBox_Title.Location = new System.Drawing.Point(11, 89);
            this.textBox_Title.Name = "textBox_Title";
            this.textBox_Title.Size = new System.Drawing.Size(626, 20);
            this.textBox_Title.TabIndex = 3;
            // 
            // textBox_Author
            // 
            this.textBox_Author.Location = new System.Drawing.Point(11, 157);
            this.textBox_Author.Name = "textBox_Author";
            this.textBox_Author.Size = new System.Drawing.Size(626, 20);
            this.textBox_Author.TabIndex = 5;
            // 
            // label_Author
            // 
            this.label_Author.AutoSize = true;
            this.label_Author.Location = new System.Drawing.Point(8, 141);
            this.label_Author.Name = "label_Author";
            this.label_Author.Size = new System.Drawing.Size(39, 13);
            this.label_Author.TabIndex = 4;
            this.label_Author.Text = "Szerző";
            // 
            // label_PublishYear
            // 
            this.label_PublishYear.AutoSize = true;
            this.label_PublishYear.Location = new System.Drawing.Point(12, 204);
            this.label_PublishYear.Name = "label_PublishYear";
            this.label_PublishYear.Size = new System.Drawing.Size(60, 13);
            this.label_PublishYear.TabIndex = 6;
            this.label_PublishYear.Text = "Kiadás éve";
            // 
            // numericUpDown_PublishYear
            // 
            this.numericUpDown_PublishYear.Location = new System.Drawing.Point(16, 229);
            this.numericUpDown_PublishYear.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown_PublishYear.Name = "numericUpDown_PublishYear";
            this.numericUpDown_PublishYear.Size = new System.Drawing.Size(95, 20);
            this.numericUpDown_PublishYear.TabIndex = 7;
            // 
            // numericUpDown_PageCount
            // 
            this.numericUpDown_PageCount.Location = new System.Drawing.Point(307, 229);
            this.numericUpDown_PageCount.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown_PageCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_PageCount.Name = "numericUpDown_PageCount";
            this.numericUpDown_PageCount.Size = new System.Drawing.Size(95, 20);
            this.numericUpDown_PageCount.TabIndex = 9;
            this.numericUpDown_PageCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_PageCount
            // 
            this.label_PageCount.AutoSize = true;
            this.label_PageCount.Location = new System.Drawing.Point(304, 204);
            this.label_PageCount.Name = "label_PageCount";
            this.label_PageCount.Size = new System.Drawing.Size(58, 13);
            this.label_PageCount.TabIndex = 8;
            this.label_PageCount.Text = "Oldal szám";
            // 
            // button_Muvelet
            // 
            this.button_Muvelet.Location = new System.Drawing.Point(823, 428);
            this.button_Muvelet.Name = "button_Muvelet";
            this.button_Muvelet.Size = new System.Drawing.Size(124, 32);
            this.button_Muvelet.TabIndex = 10;
            this.button_Muvelet.Text = "button1";
            this.button_Muvelet.UseVisualStyleBackColor = true;
            // 
            // FormBook
            // 
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1006, 512);
            this.Controls.Add(this.button_Muvelet);
            this.Controls.Add(this.numericUpDown_PageCount);
            this.Controls.Add(this.label_PageCount);
            this.Controls.Add(this.numericUpDown_PublishYear);
            this.Controls.Add(this.label_PublishYear);
            this.Controls.Add(this.textBox_Author);
            this.Controls.Add(this.label_Author);
            this.Controls.Add(this.textBox_Title);
            this.Controls.Add(this.label_Title);
            this.Name = "FormBook";
            this.Text = "FormBook";
            this.Load += new System.EventHandler(this.FormBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PublishYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PageCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.TextBox textBox_Title;
        private System.Windows.Forms.TextBox textBox_Author;
        private System.Windows.Forms.Label label_Author;
        private System.Windows.Forms.Label label_PublishYear;
        private System.Windows.Forms.NumericUpDown numericUpDown_PublishYear;
        private System.Windows.Forms.NumericUpDown numericUpDown_PageCount;
        private System.Windows.Forms.Label label_PageCount;
        private System.Windows.Forms.Button button_Muvelet;
    }
}
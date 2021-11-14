namespace WebUrlChecker
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
            this.ce_ComboBox1 = new Ce_ComboBox();
            this.txtBox1 = new TxtBox();
            this.ce_ComboBox2 = new Ce_ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ce_ComboBox1
            // 
            this.ce_ComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ce_ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ce_ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ce_ComboBox1.FormattingEnabled = true;
            this.ce_ComboBox1.ItemHeight = 18;
            this.ce_ComboBox1.Items.AddRange(new object[] {
            "http://",
            "https://"});
            this.ce_ComboBox1.Location = new System.Drawing.Point(12, 12);
            this.ce_ComboBox1.Name = "ce_ComboBox1";
            this.ce_ComboBox1.Size = new System.Drawing.Size(121, 24);
            this.ce_ComboBox1.TabIndex = 0;
            // 
            // txtBox1
            // 
            this.txtBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.txtBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtBox1.Location = new System.Drawing.Point(139, 13);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(195, 23);
            this.txtBox1.TabIndex = 1;
            this.txtBox1.Text = "enter a name here";
            // 
            // ce_ComboBox2
            // 
            this.ce_ComboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ce_ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ce_ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ce_ComboBox2.FormattingEnabled = true;
            this.ce_ComboBox2.ItemHeight = 18;
            this.ce_ComboBox2.Items.AddRange(new object[] {
            ".com",
            ".net",
            ".org",
            "more added soon"});
            this.ce_ComboBox2.Location = new System.Drawing.Point(340, 13);
            this.ce_ComboBox2.Name = "ce_ComboBox2";
            this.ce_ComboBox2.Size = new System.Drawing.Size(133, 24);
            this.ce_ComboBox2.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.richTextBox1.Location = new System.Drawing.Point(12, 42);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(322, 190);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "Information will be shown here";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InfoText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(340, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 189);
            this.button1.TabIndex = 4;
            this.button1.Text = "Check url";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(485, 244);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ce_ComboBox2);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.ce_ComboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Ce_ComboBox ce_ComboBox1;
        private TxtBox txtBox1;
        private Ce_ComboBox ce_ComboBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
    }
}


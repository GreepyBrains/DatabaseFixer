namespace DatabaseFixer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            label1 = new Label();
            ConvertButton = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            ReplaceCheckBox = new CheckBox();
            ToPlusCheckBox = new CheckBox();
            XTimeCheckBox = new CheckBox();
            GroupByCheckBox = new CheckBox();
            OrderByCheckBox = new CheckBox();
            label3 = new Label();
            ToDateRegexCheckBox = new CheckBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(32, 46);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(730, 386);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 18);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 1;
            label1.Text = "Paste old Database:";
            // 
            // ConvertButton
            // 
            ConvertButton.Location = new Point(792, 63);
            ConvertButton.Name = "ConvertButton";
            ConvertButton.Size = new Size(134, 45);
            ConvertButton.TabIndex = 2;
            ConvertButton.Text = "CONVERT\r\n==>";
            ConvertButton.UseVisualStyleBackColor = true;
            ConvertButton.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(948, 46);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(730, 386);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(933, 18);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 4;
            label2.Text = "New Database:";
            // 
            // ReplaceCheckBox
            // 
            ReplaceCheckBox.AutoSize = true;
            ReplaceCheckBox.Checked = true;
            ReplaceCheckBox.CheckState = CheckState.Checked;
            ReplaceCheckBox.Location = new Point(780, 114);
            ReplaceCheckBox.Name = "ReplaceCheckBox";
            ReplaceCheckBox.Size = new Size(137, 19);
            ReplaceCheckBox.TabIndex = 5;
            ReplaceCheckBox.Text = "Remove: \"or replace\"";
            ReplaceCheckBox.UseVisualStyleBackColor = true;
            // 
            // ToPlusCheckBox
            // 
            ToPlusCheckBox.AutoSize = true;
            ToPlusCheckBox.Checked = true;
            ToPlusCheckBox.CheckState = CheckState.Checked;
            ToPlusCheckBox.Location = new Point(780, 139);
            ToPlusCheckBox.Name = "ToPlusCheckBox";
            ToPlusCheckBox.Size = new Size(104, 19);
            ToPlusCheckBox.TabIndex = 6;
            ToPlusCheckBox.Text = "Replace: || to +";
            ToPlusCheckBox.UseVisualStyleBackColor = true;
            // 
            // XTimeCheckBox
            // 
            XTimeCheckBox.AutoSize = true;
            XTimeCheckBox.Checked = true;
            XTimeCheckBox.CheckState = CheckState.Checked;
            XTimeCheckBox.Location = new Point(780, 164);
            XTimeCheckBox.Name = "XTimeCheckBox";
            XTimeCheckBox.Size = new Size(162, 19);
            XTimeCheckBox.TabIndex = 7;
            XTimeCheckBox.Text = "Replace: XTIME > gfostest";
            XTimeCheckBox.UseVisualStyleBackColor = true;
            // 
            // GroupByCheckBox
            // 
            GroupByCheckBox.AutoSize = true;
            GroupByCheckBox.Checked = true;
            GroupByCheckBox.CheckState = CheckState.Checked;
            GroupByCheckBox.Location = new Point(780, 259);
            GroupByCheckBox.Name = "GroupByCheckBox";
            GroupByCheckBox.Size = new Size(150, 19);
            GroupByCheckBox.TabIndex = 8;
            GroupByCheckBox.Text = "Remove: group by lines";
            GroupByCheckBox.UseVisualStyleBackColor = true;
            // 
            // OrderByCheckBox
            // 
            OrderByCheckBox.AutoSize = true;
            OrderByCheckBox.Checked = true;
            OrderByCheckBox.CheckState = CheckState.Checked;
            OrderByCheckBox.Location = new Point(780, 284);
            OrderByCheckBox.Name = "OrderByCheckBox";
            OrderByCheckBox.Size = new Size(146, 19);
            OrderByCheckBox.TabIndex = 9;
            OrderByCheckBox.Text = "Remove: order by lines";
            OrderByCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(769, 216);
            label3.Name = "label3";
            label3.Size = new Size(173, 30);
            label3.TabIndex = 10;
            label3.Text = "Experimental:\r\n(Das hier löscht die ganze Zeile)";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // ToDateRegexCheckBox
            // 
            ToDateRegexCheckBox.AutoSize = true;
            ToDateRegexCheckBox.BackColor = SystemColors.Control;
            ToDateRegexCheckBox.ForeColor = Color.Red;
            ToDateRegexCheckBox.Location = new Point(780, 390);
            ToDateRegexCheckBox.Name = "ToDateRegexCheckBox";
            ToDateRegexCheckBox.Size = new Size(110, 19);
            ToDateRegexCheckBox.TabIndex = 11;
            ToDateRegexCheckBox.Text = "Regex: TO_DATE";
            ToDateRegexCheckBox.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(768, 317);
            label4.Name = "label4";
            label4.Size = new Size(162, 60);
            label4.TabIndex = 12;
            label4.Text = "REGEX:\r\n(Wird nicht funktionieren,\r\nbrauche mehr Datensätze für \r\nnen guten regex CAST)";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1689, 457);
            Controls.Add(label4);
            Controls.Add(ToDateRegexCheckBox);
            Controls.Add(label3);
            Controls.Add(OrderByCheckBox);
            Controls.Add(GroupByCheckBox);
            Controls.Add(XTimeCheckBox);
            Controls.Add(ToPlusCheckBox);
            Controls.Add(ReplaceCheckBox);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(ConvertButton);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Database Fixer";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button ConvertButton;
        private TextBox textBox2;
        private Label label2;
        private CheckBox ReplaceCheckBox;
        private CheckBox ToPlusCheckBox;
        private CheckBox XTimeCheckBox;
        private CheckBox GroupByCheckBox;
        private CheckBox OrderByCheckBox;
        private Label label3;
        private CheckBox ToDateRegexCheckBox;
        private Label label4;
    }
}

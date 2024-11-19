namespace WinFormsHW3
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
            components = new System.ComponentModel.Container();
            nameLabel = new Label();
            nameBox = new TextBox();
            summaLabel = new Label();
            numericSumma = new NumericUpDown();
            nameCategories = new Label();
            categoriesCombo = new ComboBox();
            addButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            TimerLabel = new Label();
            label2 = new Label();
            label1 = new Label();
            overallSumLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)numericSumma).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(13, 42);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(39, 15);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(82, 39);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(153, 23);
            nameBox.TabIndex = 1;
            // 
            // summaLabel
            // 
            summaLabel.AutoSize = true;
            summaLabel.Location = new Point(13, 74);
            summaLabel.Name = "summaLabel";
            summaLabel.Size = new Size(48, 15);
            summaLabel.TabIndex = 2;
            summaLabel.Text = "Summa";
            // 
            // numericSumma
            // 
            numericSumma.Location = new Point(82, 72);
            numericSumma.Name = "numericSumma";
            numericSumma.Size = new Size(153, 23);
            numericSumma.TabIndex = 3;
            // 
            // nameCategories
            // 
            nameCategories.AutoSize = true;
            nameCategories.Location = new Point(13, 108);
            nameCategories.Name = "nameCategories";
            nameCategories.Size = new Size(63, 15);
            nameCategories.TabIndex = 4;
            nameCategories.Text = "Categories";
            // 
            // categoriesCombo
            // 
            categoriesCombo.FormattingEnabled = true;
            categoriesCombo.Items.AddRange(new object[] { "Food", "Transport", "Entertaiment", "Buy", "Other" });
            categoriesCombo.Location = new Point(82, 105);
            categoriesCombo.Name = "categoriesCombo";
            categoriesCombo.Size = new Size(153, 23);
            categoriesCombo.TabIndex = 5;
            // 
            // addButton
            // 
            addButton.Location = new Point(160, 134);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 33);
            addButton.TabIndex = 6;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // TimerLabel
            // 
            TimerLabel.AutoSize = true;
            TimerLabel.Location = new Point(197, 9);
            TimerLabel.Name = "TimerLabel";
            TimerLabel.Size = new Size(0, 15);
            TimerLabel.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 9);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 9;
            label2.Text = "Current Time:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 143);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 7;
            // 
            // overallSumLabel
            // 
            overallSumLabel.AutoSize = true;
            overallSumLabel.Location = new Point(23, 152);
            overallSumLabel.Name = "overallSumLabel";
            overallSumLabel.Size = new Size(0, 15);
            overallSumLabel.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(overallSumLabel);
            Controls.Add(label2);
            Controls.Add(TimerLabel);
            Controls.Add(label1);
            Controls.Add(addButton);
            Controls.Add(categoriesCombo);
            Controls.Add(nameCategories);
            Controls.Add(numericSumma);
            Controls.Add(summaLabel);
            Controls.Add(nameBox);
            Controls.Add(nameLabel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericSumma).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private TextBox nameBox;
        private Label summaLabel;
        private NumericUpDown numericSumma;
        private Label nameCategories;
        private ComboBox categoriesCombo;
        private Button addButton;
        private System.Windows.Forms.Timer timer1;
        private Label TimerLabel;
        private Label label2;
        private Label label1;
        private Label overallSumLabel;
    }
}

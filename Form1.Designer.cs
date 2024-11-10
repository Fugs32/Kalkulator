namespace Kalkulator
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            textBox1 = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            buttonChangeToOpposite = new Button();
            buttonComma = new Button();
            buttonEqual = new Button();
            buttonAdd = new Button();
            buttonSubtract = new Button();
            buttonMultiply = new Button();
            buttonDivide = new Button();
            buttonBack = new Button();
            buttonCE = new Button();
            buttonC = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(textBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Size = new Size(500, 664);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(494, 59);
            label1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(494, 23);
            textBox1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(button1, 0, 3);
            tableLayoutPanel2.Controls.Add(button2, 1, 3);
            tableLayoutPanel2.Controls.Add(button3, 2, 3);
            tableLayoutPanel2.Controls.Add(button4, 0, 2);
            tableLayoutPanel2.Controls.Add(button5, 1, 2);
            tableLayoutPanel2.Controls.Add(button6, 2, 2);
            tableLayoutPanel2.Controls.Add(button7, 0, 1);
            tableLayoutPanel2.Controls.Add(button8, 1, 1);
            tableLayoutPanel2.Controls.Add(button9, 2, 1);
            tableLayoutPanel2.Controls.Add(button0, 1, 4);
            tableLayoutPanel2.Controls.Add(buttonChangeToOpposite, 0, 4);
            tableLayoutPanel2.Controls.Add(buttonComma, 2, 4);
            tableLayoutPanel2.Controls.Add(buttonEqual, 3, 4);
            tableLayoutPanel2.Controls.Add(buttonAdd, 3, 3);
            tableLayoutPanel2.Controls.Add(buttonSubtract, 3, 2);
            tableLayoutPanel2.Controls.Add(buttonMultiply, 3, 1);
            tableLayoutPanel2.Controls.Add(buttonDivide, 3, 0);
            tableLayoutPanel2.Controls.Add(buttonBack, 2, 0);
            tableLayoutPanel2.Controls.Add(buttonCE, 1, 0);
            tableLayoutPanel2.Controls.Add(buttonC, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 135);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(494, 526);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.PapayaWhip;
            button1.Dock = DockStyle.Fill;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(3, 318);
            button1.Name = "button1";
            button1.Size = new Size(117, 99);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.PapayaWhip;
            button2.Dock = DockStyle.Fill;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(126, 318);
            button2.Name = "button2";
            button2.Size = new Size(117, 99);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.PapayaWhip;
            button3.Dock = DockStyle.Fill;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(249, 318);
            button3.Name = "button3";
            button3.Size = new Size(117, 99);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.PapayaWhip;
            button4.Dock = DockStyle.Fill;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(3, 213);
            button4.Name = "button4";
            button4.Size = new Size(117, 99);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.PapayaWhip;
            button5.Dock = DockStyle.Fill;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(126, 213);
            button5.Name = "button5";
            button5.Size = new Size(117, 99);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.PapayaWhip;
            button6.Dock = DockStyle.Fill;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(249, 213);
            button6.Name = "button6";
            button6.Size = new Size(117, 99);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.PapayaWhip;
            button7.Dock = DockStyle.Fill;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(3, 108);
            button7.Name = "button7";
            button7.Size = new Size(117, 99);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.PapayaWhip;
            button8.Dock = DockStyle.Fill;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Location = new Point(126, 108);
            button8.Name = "button8";
            button8.Size = new Size(117, 99);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.PapayaWhip;
            button9.Dock = DockStyle.Fill;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Location = new Point(249, 108);
            button9.Name = "button9";
            button9.Size = new Size(117, 99);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button0
            // 
            button0.BackColor = Color.PapayaWhip;
            button0.Dock = DockStyle.Fill;
            button0.FlatAppearance.BorderSize = 0;
            button0.FlatStyle = FlatStyle.Flat;
            button0.Location = new Point(126, 423);
            button0.Name = "button0";
            button0.Size = new Size(117, 100);
            button0.TabIndex = 9;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += button0_Click;
            // 
            // buttonChangeToOpposite
            // 
            buttonChangeToOpposite.BackColor = SystemColors.ActiveBorder;
            buttonChangeToOpposite.Dock = DockStyle.Fill;
            buttonChangeToOpposite.FlatAppearance.BorderSize = 0;
            buttonChangeToOpposite.FlatStyle = FlatStyle.Flat;
            buttonChangeToOpposite.Location = new Point(3, 423);
            buttonChangeToOpposite.Name = "buttonChangeToOpposite";
            buttonChangeToOpposite.Size = new Size(117, 100);
            buttonChangeToOpposite.TabIndex = 10;
            buttonChangeToOpposite.Text = "+/-";
            buttonChangeToOpposite.UseVisualStyleBackColor = false;
            buttonChangeToOpposite.Click += buttonChangeToOpposite_Click;
            // 
            // buttonComma
            // 
            buttonComma.BackColor = SystemColors.ActiveBorder;
            buttonComma.Dock = DockStyle.Fill;
            buttonComma.FlatAppearance.BorderSize = 0;
            buttonComma.FlatStyle = FlatStyle.Flat;
            buttonComma.Location = new Point(249, 423);
            buttonComma.Name = "buttonComma";
            buttonComma.Size = new Size(117, 100);
            buttonComma.TabIndex = 11;
            buttonComma.Text = ",";
            buttonComma.UseVisualStyleBackColor = false;
            buttonComma.Click += buttonComma_Click;
            // 
            // buttonEqual
            // 
            buttonEqual.BackColor = SystemColors.HotTrack;
            buttonEqual.Dock = DockStyle.Fill;
            buttonEqual.FlatAppearance.BorderSize = 0;
            buttonEqual.FlatStyle = FlatStyle.Flat;
            buttonEqual.Location = new Point(372, 423);
            buttonEqual.Name = "buttonEqual";
            buttonEqual.Size = new Size(119, 100);
            buttonEqual.TabIndex = 12;
            buttonEqual.Text = "=";
            buttonEqual.UseVisualStyleBackColor = false;
            buttonEqual.Click += buttonEqual_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = SystemColors.ActiveBorder;
            buttonAdd.Dock = DockStyle.Fill;
            buttonAdd.FlatAppearance.BorderSize = 0;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Location = new Point(372, 318);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(119, 99);
            buttonAdd.TabIndex = 13;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonSubtract
            // 
            buttonSubtract.BackColor = SystemColors.ActiveBorder;
            buttonSubtract.Dock = DockStyle.Fill;
            buttonSubtract.FlatAppearance.BorderSize = 0;
            buttonSubtract.FlatStyle = FlatStyle.Flat;
            buttonSubtract.Location = new Point(372, 213);
            buttonSubtract.Name = "buttonSubtract";
            buttonSubtract.Size = new Size(119, 99);
            buttonSubtract.TabIndex = 14;
            buttonSubtract.Text = "-";
            buttonSubtract.UseVisualStyleBackColor = false;
            buttonSubtract.Click += buttonSubtract_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.BackColor = SystemColors.ActiveBorder;
            buttonMultiply.Dock = DockStyle.Fill;
            buttonMultiply.FlatAppearance.BorderSize = 0;
            buttonMultiply.FlatStyle = FlatStyle.Flat;
            buttonMultiply.Location = new Point(372, 108);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(119, 99);
            buttonMultiply.TabIndex = 15;
            buttonMultiply.Text = "*";
            buttonMultiply.UseVisualStyleBackColor = false;
            buttonMultiply.Click += buttonMultiply_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.BackColor = SystemColors.ActiveBorder;
            buttonDivide.Dock = DockStyle.Fill;
            buttonDivide.FlatAppearance.BorderSize = 0;
            buttonDivide.FlatStyle = FlatStyle.Flat;
            buttonDivide.Location = new Point(372, 3);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(119, 99);
            buttonDivide.TabIndex = 16;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = false;
            buttonDivide.Click += buttonDivide_Click;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = SystemColors.ActiveBorder;
            buttonBack.Dock = DockStyle.Fill;
            buttonBack.FlatAppearance.BorderSize = 0;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Location = new Point(249, 3);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(117, 99);
            buttonBack.TabIndex = 17;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonCE
            // 
            buttonCE.BackColor = SystemColors.ActiveBorder;
            buttonCE.Dock = DockStyle.Fill;
            buttonCE.FlatAppearance.BorderSize = 0;
            buttonCE.FlatStyle = FlatStyle.Flat;
            buttonCE.Location = new Point(126, 3);
            buttonCE.Name = "buttonCE";
            buttonCE.Size = new Size(117, 99);
            buttonCE.TabIndex = 18;
            buttonCE.Text = "CE";
            buttonCE.UseVisualStyleBackColor = false;
            buttonCE.Click += buttonCE_Click;
            // 
            // buttonC
            // 
            buttonC.BackColor = SystemColors.ActiveBorder;
            buttonC.Dock = DockStyle.Fill;
            buttonC.FlatAppearance.BorderSize = 0;
            buttonC.FlatStyle = FlatStyle.Flat;
            buttonC.Location = new Point(3, 3);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(117, 99);
            buttonC.TabIndex = 19;
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = false;
            buttonC.Click += buttonC_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 664);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            ShowIcon = false;
            Text = "Kalkulator";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox textBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button buttonChangeToOpposite;
        private Button buttonComma;
        private Button buttonEqual;
        private Button buttonAdd;
        private Button buttonSubtract;
        private Button buttonMultiply;
        private Button buttonDivide;
        private Button buttonBack;
        private Button buttonCE;
        private Button buttonC;
    }
}

namespace exemplo
{
    partial class X
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
            imputTextX = new TextBox();
            btnClick = new Button();
            labelTitle = new Label();
            labelOutPut = new Label();
            inputTextY = new TextBox();
            colorDialog1 = new ColorDialog();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button1 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // imputTextX
            // 
            imputTextX.Location = new Point(69, 65);
            imputTextX.Name = "imputTextX";
            imputTextX.Size = new Size(208, 31);
            imputTextX.TabIndex = 1;
            imputTextX.TextChanged += imputTextX_TextChanged;
            // 
            // btnClick
            // 
            btnClick.BackColor = Color.FromArgb(255, 127, 84);
            btnClick.Cursor = Cursors.Hand;
            btnClick.FlatAppearance.BorderColor = SystemColors.Window;
            btnClick.FlatAppearance.BorderSize = 3;
            btnClick.FlatStyle = FlatStyle.Flat;
            btnClick.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnClick.ForeColor = SystemColors.ButtonFace;
            btnClick.Location = new Point(28, 185);
            btnClick.Name = "btnClick";
            btnClick.Size = new Size(66, 66);
            btnClick.TabIndex = 3;
            btnClick.Text = " +";
            btnClick.TextAlign = ContentAlignment.TopLeft;
            btnClick.UseVisualStyleBackColor = false;
            btnClick.Click += onSomaClick;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelTitle.ForeColor = Color.Coral;
            labelTitle.Location = new Point(28, 19);
            labelTitle.MaximumSize = new Size(300, 65);
            labelTitle.MinimumSize = new Size(300, 65);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(300, 65);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Calculador:";
            labelTitle.Click += labelTitle_Click;
            // 
            // labelOutPut
            // 
            labelOutPut.AutoSize = true;
            labelOutPut.BackColor = Color.FromArgb(40, 42, 54);
            labelOutPut.ForeColor = Color.White;
            labelOutPut.Location = new Point(371, 65);
            labelOutPut.MaximumSize = new Size(400, 350);
            labelOutPut.MinimumSize = new Size(400, 350);
            labelOutPut.Name = "labelOutPut";
            labelOutPut.Padding = new Padding(10);
            labelOutPut.Size = new Size(400, 350);
            labelOutPut.TabIndex = 4;
            labelOutPut.Text = "...";
            labelOutPut.Visible = false;
            labelOutPut.Click += labelOutPut_Click;
            // 
            // inputTextY
            // 
            inputTextY.Location = new Point(69, 121);
            inputTextY.Name = "inputTextY";
            inputTextY.Size = new Size(208, 31);
            inputTextY.TabIndex = 2;
            inputTextY.TextChanged += inputTextY_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 127, 84);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = SystemColors.Window;
            button2.FlatAppearance.BorderSize = 3;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(136, 185);
            button2.Name = "button2";
            button2.Size = new Size(66, 66);
            button2.TabIndex = 5;
            button2.Text = " –";
            button2.TextAlign = ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 127, 84);
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = SystemColors.Window;
            button3.FlatAppearance.BorderSize = 3;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(248, 185);
            button3.Name = "button3";
            button3.Size = new Size(66, 66);
            button3.TabIndex = 6;
            button3.Text = "x";
            button3.TextAlign = ContentAlignment.TopCenter;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 127, 84);
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderColor = SystemColors.Window;
            button4.FlatAppearance.BorderSize = 3;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(28, 276);
            button4.Name = "button4";
            button4.Size = new Size(66, 66);
            button4.TabIndex = 7;
            button4.Text = "÷";
            button4.TextAlign = ContentAlignment.TopCenter;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 127, 84);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = SystemColors.Window;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(136, 276);
            button1.Name = "button1";
            button1.Size = new Size(66, 66);
            button1.TabIndex = 8;
            button1.Text = "x²";
            button1.TextAlign = ContentAlignment.TopRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(255, 127, 84);
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderColor = SystemColors.Window;
            button5.FlatAppearance.BorderSize = 3;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button5.ForeColor = SystemColors.ButtonFace;
            button5.Location = new Point(248, 276);
            button5.Name = "button5";
            button5.Size = new Size(66, 66);
            button5.TabIndex = 9;
            button5.Text = "√";
            button5.TextAlign = ContentAlignment.TopCenter;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(255, 127, 84);
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderColor = SystemColors.Window;
            button6.FlatAppearance.BorderSize = 3;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button6.ForeColor = SystemColors.ButtonFace;
            button6.Location = new Point(28, 372);
            button6.Name = "button6";
            button6.Size = new Size(66, 66);
            button6.TabIndex = 10;
            button6.Text = "%";
            button6.TextAlign = ContentAlignment.TopCenter;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(255, 127, 84);
            button7.Cursor = Cursors.Hand;
            button7.FlatAppearance.BorderColor = SystemColors.Window;
            button7.FlatAppearance.BorderSize = 3;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button7.ForeColor = SystemColors.ButtonFace;
            button7.Location = new Point(136, 372);
            button7.Name = "button7";
            button7.Size = new Size(66, 66);
            button7.TabIndex = 11;
            button7.Text = "01";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(255, 127, 84);
            button8.Cursor = Cursors.Hand;
            button8.FlatAppearance.BorderColor = SystemColors.Window;
            button8.FlatAppearance.BorderSize = 3;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button8.ForeColor = SystemColors.ButtonFace;
            button8.Location = new Point(248, 372);
            button8.Name = "button8";
            button8.Size = new Size(66, 66);
            button8.TabIndex = 10;
            button8.Text = "x^y";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(40, 42, 54);
            label1.Font = new Font("Segoe UI", 50F);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(398, 158);
            label1.MaximumSize = new Size(350, 150);
            label1.MinimumSize = new Size(350, 150);
            label1.Name = "label1";
            label1.Size = new Size(350, 150);
            label1.TabIndex = 12;
            label1.Text = "...";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Visible = false;
            label1.Click += label1_Click;
            // 
            // X
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(62, 83, 102);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(imputTextX);
            Controls.Add(inputTextY);
            Controls.Add(labelOutPut);
            Controls.Add(labelTitle);
            Controls.Add(btnClick);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "X";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox imputTextX;
        private Button btnClick;
        private Label labelTitle;
        private Label labelOutPut;
        private TextBox inputTextY;
        private ColorDialog colorDialog1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button1;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Label label1;
    }
}

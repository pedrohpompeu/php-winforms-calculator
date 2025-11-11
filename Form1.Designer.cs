namespace Exemplo
{
    partial class Operon
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
            inputTextX = new TextBox();
            labelTitle = new Label();
            labelOutput = new Label();
            btnSoma = new Button();
            inputTextY = new TextBox();
            labelX = new Label();
            label1 = new Label();
            btnSub = new Button();
            btnMult = new Button();
            btnRaiz = new Button();
            btnDobro = new Button();
            btnDiv = new Button();
            button6 = new Button();
            button7 = new Button();
            btnPorcent = new Button();
            labelResult = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // inputTextX
            // 
            inputTextX.BackColor = SystemColors.InactiveCaption;
            inputTextX.Font = new Font("Segoe UI", 12F);
            inputTextX.Location = new Point(70, 30);
            inputTextX.Margin = new Padding(2);
            inputTextX.Name = "inputTextX";
            inputTextX.Size = new Size(132, 29);
            inputTextX.TabIndex = 1;
            inputTextX.TextChanged += inputTextX_TextChanged;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelTitle.ForeColor = Color.FromArgb(191, 0, 255);
            labelTitle.Location = new Point(11, -4);
            labelTitle.Margin = new Padding(2, 0, 2, 0);
            labelTitle.MaximumSize = new Size(210, 39);
            labelTitle.MinimumSize = new Size(210, 39);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(210, 39);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Calculator";
            labelTitle.TextAlign = ContentAlignment.MiddleLeft;
            labelTitle.Click += labelTitle_Click;
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.BackColor = Color.Transparent;
            labelOutput.Font = new Font("Segoe UI", 12F);
            labelOutput.ForeColor = Color.FromArgb(191, 0, 255);
            labelOutput.Location = new Point(265, 30);
            labelOutput.Margin = new Padding(2, 0, 2, 0);
            labelOutput.MaximumSize = new Size(280, 150);
            labelOutput.MinimumSize = new Size(280, 210);
            labelOutput.Name = "labelOutput";
            labelOutput.Padding = new Padding(7, 12, 14, 6);
            labelOutput.Size = new Size(280, 210);
            labelOutput.TabIndex = 4;
            labelOutput.Text = "...";
            labelOutput.Visible = false;
            labelOutput.Click += labelOutput_Click;
            // 
            // btnSoma
            // 
            btnSoma.BackColor = Color.DarkViolet;
            btnSoma.Cursor = Cursors.Hand;
            btnSoma.FlatAppearance.BorderColor = Color.SlateBlue;
            btnSoma.FlatAppearance.BorderSize = 3;
            btnSoma.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnSoma.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnSoma.ForeColor = SystemColors.ButtonFace;
            btnSoma.Location = new Point(11, 139);
            btnSoma.Margin = new Padding(2);
            btnSoma.MaximumSize = new Size(66, 36);
            btnSoma.MinimumSize = new Size(66, 36);
            btnSoma.Name = "btnSoma";
            btnSoma.Padding = new Padding(4, 3, 4, 3);
            btnSoma.Size = new Size(66, 36);
            btnSoma.TabIndex = 3;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = false;
            btnSoma.Click += onSomaClick;
            // 
            // inputTextY
            // 
            inputTextY.BackColor = SystemColors.InactiveCaption;
            inputTextY.Font = new Font("Segoe UI", 12F);
            inputTextY.Location = new Point(70, 65);
            inputTextY.Margin = new Padding(2);
            inputTextY.Name = "inputTextY";
            inputTextY.Size = new Size(132, 29);
            inputTextY.TabIndex = 2;
            inputTextY.TextChanged += inputTextY_TextChanged;
            // 
            // labelX
            // 
            labelX.AutoSize = true;
            labelX.BackColor = Color.Transparent;
            labelX.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelX.ForeColor = Color.FromArgb(191, 0, 255);
            labelX.Location = new Point(20, 22);
            labelX.Margin = new Padding(2, 0, 2, 0);
            labelX.MaximumSize = new Size(46, 39);
            labelX.MinimumSize = new Size(46, 39);
            labelX.Name = "labelX";
            labelX.Size = new Size(46, 39);
            labelX.TabIndex = 5;
            labelX.Text = "X";
            labelX.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(191, 0, 255);
            label1.Location = new Point(20, 57);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.MaximumSize = new Size(46, 39);
            label1.MinimumSize = new Size(46, 39);
            label1.Name = "label1";
            label1.Size = new Size(46, 39);
            label1.TabIndex = 6;
            label1.Text = "Y";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnSub
            // 
            btnSub.BackColor = Color.DarkViolet;
            btnSub.Cursor = Cursors.Hand;
            btnSub.FlatAppearance.BorderColor = Color.SlateBlue;
            btnSub.FlatAppearance.BorderSize = 3;
            btnSub.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnSub.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnSub.ForeColor = SystemColors.ButtonFace;
            btnSub.Location = new Point(95, 139);
            btnSub.Margin = new Padding(2);
            btnSub.MaximumSize = new Size(66, 36);
            btnSub.MinimumSize = new Size(66, 36);
            btnSub.Name = "btnSub";
            btnSub.Padding = new Padding(4, 3, 4, 3);
            btnSub.Size = new Size(66, 36);
            btnSub.TabIndex = 7;
            btnSub.Text = "—";
            btnSub.UseVisualStyleBackColor = false;
            btnSub.Click += btnSub_Click;
            // 
            // btnMult
            // 
            btnMult.BackColor = Color.DarkViolet;
            btnMult.Cursor = Cursors.Hand;
            btnMult.FlatAppearance.BorderColor = Color.SlateBlue;
            btnMult.FlatAppearance.BorderSize = 3;
            btnMult.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnMult.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnMult.ForeColor = SystemColors.ButtonFace;
            btnMult.Location = new Point(181, 139);
            btnMult.Margin = new Padding(2);
            btnMult.MaximumSize = new Size(66, 36);
            btnMult.MinimumSize = new Size(66, 36);
            btnMult.Name = "btnMult";
            btnMult.Padding = new Padding(4, 3, 4, 3);
            btnMult.Size = new Size(66, 36);
            btnMult.TabIndex = 8;
            btnMult.Text = "X";
            btnMult.UseVisualStyleBackColor = false;
            btnMult.Click += btnMult_Click;
            // 
            // btnRaiz
            // 
            btnRaiz.BackColor = Color.DarkViolet;
            btnRaiz.Cursor = Cursors.Hand;
            btnRaiz.FlatAppearance.BorderColor = Color.SlateBlue;
            btnRaiz.FlatAppearance.BorderSize = 3;
            btnRaiz.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnRaiz.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnRaiz.ForeColor = SystemColors.ButtonFace;
            btnRaiz.Location = new Point(181, 184);
            btnRaiz.Margin = new Padding(2);
            btnRaiz.MaximumSize = new Size(66, 36);
            btnRaiz.MinimumSize = new Size(66, 36);
            btnRaiz.Name = "btnRaiz";
            btnRaiz.Padding = new Padding(4, 3, 4, 3);
            btnRaiz.Size = new Size(66, 36);
            btnRaiz.TabIndex = 11;
            btnRaiz.Text = "√ ";
            btnRaiz.UseVisualStyleBackColor = false;
            btnRaiz.Click += btnRaiz_Click;
            // 
            // btnDobro
            // 
            btnDobro.BackColor = Color.DarkViolet;
            btnDobro.Cursor = Cursors.Hand;
            btnDobro.FlatAppearance.BorderColor = Color.SlateBlue;
            btnDobro.FlatAppearance.BorderSize = 3;
            btnDobro.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnDobro.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnDobro.ForeColor = SystemColors.ButtonFace;
            btnDobro.Location = new Point(95, 184);
            btnDobro.Margin = new Padding(2);
            btnDobro.MaximumSize = new Size(66, 36);
            btnDobro.MinimumSize = new Size(66, 36);
            btnDobro.Name = "btnDobro";
            btnDobro.Padding = new Padding(4, 3, 4, 3);
            btnDobro.Size = new Size(66, 36);
            btnDobro.TabIndex = 10;
            btnDobro.Text = "X²";
            btnDobro.UseVisualStyleBackColor = false;
            btnDobro.Click += btnDobro_Click;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = Color.DarkViolet;
            btnDiv.Cursor = Cursors.Hand;
            btnDiv.FlatAppearance.BorderColor = Color.SlateBlue;
            btnDiv.FlatAppearance.BorderSize = 3;
            btnDiv.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnDiv.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnDiv.ForeColor = SystemColors.ButtonFace;
            btnDiv.Location = new Point(11, 184);
            btnDiv.Margin = new Padding(2);
            btnDiv.MaximumSize = new Size(66, 36);
            btnDiv.MinimumSize = new Size(66, 36);
            btnDiv.Name = "btnDiv";
            btnDiv.Padding = new Padding(4, 3, 4, 3);
            btnDiv.Size = new Size(66, 36);
            btnDiv.TabIndex = 9;
            btnDiv.Text = "÷";
            btnDiv.UseVisualStyleBackColor = false;
            btnDiv.Click += btnDiv_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.DarkViolet;
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderColor = Color.SlateBlue;
            button6.FlatAppearance.BorderSize = 3;
            button6.FlatAppearance.CheckedBackColor = Color.Transparent;
            button6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button6.ForeColor = SystemColors.ButtonFace;
            button6.Location = new Point(181, 226);
            button6.Margin = new Padding(2);
            button6.MaximumSize = new Size(66, 36);
            button6.MinimumSize = new Size(66, 36);
            button6.Name = "button6";
            button6.Padding = new Padding(4, 3, 4, 3);
            button6.Size = new Size(66, 36);
            button6.TabIndex = 14;
            button6.Text = "X^y";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.DarkViolet;
            button7.Cursor = Cursors.Hand;
            button7.FlatAppearance.BorderColor = Color.SlateBlue;
            button7.FlatAppearance.BorderSize = 3;
            button7.FlatAppearance.CheckedBackColor = Color.Transparent;
            button7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button7.ForeColor = SystemColors.ButtonFace;
            button7.Location = new Point(95, 226);
            button7.Margin = new Padding(2);
            button7.MaximumSize = new Size(66, 36);
            button7.MinimumSize = new Size(66, 36);
            button7.Name = "button7";
            button7.Padding = new Padding(4, 3, 4, 3);
            button7.Size = new Size(66, 36);
            button7.TabIndex = 13;
            button7.Text = "01010";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // btnPorcent
            // 
            btnPorcent.BackColor = Color.DarkViolet;
            btnPorcent.Cursor = Cursors.Hand;
            btnPorcent.FlatAppearance.BorderColor = Color.SlateBlue;
            btnPorcent.FlatAppearance.BorderSize = 3;
            btnPorcent.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnPorcent.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnPorcent.ForeColor = SystemColors.ButtonFace;
            btnPorcent.Location = new Point(11, 226);
            btnPorcent.Margin = new Padding(2);
            btnPorcent.MaximumSize = new Size(66, 36);
            btnPorcent.MinimumSize = new Size(66, 36);
            btnPorcent.Name = "btnPorcent";
            btnPorcent.Padding = new Padding(4, 3, 4, 3);
            btnPorcent.Size = new Size(66, 36);
            btnPorcent.TabIndex = 12;
            btnPorcent.Text = "%";
            btnPorcent.UseVisualStyleBackColor = false;
            btnPorcent.Click += btnPorcent_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.BackColor = Color.Transparent;
            labelResult.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            labelResult.ForeColor = Color.FromArgb(191, 0, 255);
            labelResult.Location = new Point(265, 85);
            labelResult.Margin = new Padding(1);
            labelResult.MaximumSize = new Size(280, 120);
            labelResult.MinimumSize = new Size(280, 120);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(280, 120);
            labelResult.TabIndex = 15;
            labelResult.Text = "000000";
            labelResult.TextAlign = ContentAlignment.MiddleCenter;
            labelResult.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSlateBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.SlateBlue;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatAppearance.CheckedBackColor = Color.Transparent;
            button1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(181, 97);
            button1.Margin = new Padding(2);
            button1.MaximumSize = new Size(66, 33);
            button1.MinimumSize = new Size(66, 33);
            button1.Name = "button1";
            button1.Padding = new Padding(4, 3, 4, 3);
            button1.Size = new Size(66, 33);
            button1.TabIndex = 16;
            button1.Text = "AC";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Operon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(560, 270);
            Controls.Add(button1);
            Controls.Add(inputTextX);
            Controls.Add(labelResult);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(btnPorcent);
            Controls.Add(btnRaiz);
            Controls.Add(btnDobro);
            Controls.Add(btnDiv);
            Controls.Add(btnMult);
            Controls.Add(btnSub);
            Controls.Add(label1);
            Controls.Add(labelX);
            Controls.Add(inputTextY);
            Controls.Add(btnSoma);
            Controls.Add(labelOutput);
            Controls.Add(labelTitle);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(2);
            Name = "Operon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Operon";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputTextX;
        private Label labelTitle;
        private Label labelOutput;
        private Button btnSoma;
        private TextBox inputTextY;
        private Label labelX;
        private Label label1;
        private Button btnSub;
        private Button btnMult;
        private Button btnRaiz;
        private Button btnDobro;
        private Button btnDiv;
        private Button button6;
        private Button button7;
        private Button btnPorcent;
        private Label labelResult;
        private Button button1;
    }
}

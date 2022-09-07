namespace SFRANCIOG_T1
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
            this.components = new System.ComponentModel.Container();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Tastatura = new System.Windows.Forms.GroupBox();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFactorial = new System.Windows.Forms.Button();
            this.btnModulo = new System.Windows.Forms.Button();
            this.btnEgal = new System.Windows.Forms.Button();
            this.btnImpartire = new System.Windows.Forms.Button();
            this.btnInmultire = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.Tastatura.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(12, 51);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(287, 42);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Tastatura
            // 
            this.Tastatura.Controls.Add(this.btnBackspace);
            this.Tastatura.Controls.Add(this.btn0);
            this.Tastatura.Controls.Add(this.btnCE);
            this.Tastatura.Controls.Add(this.btn9);
            this.Tastatura.Controls.Add(this.btn8);
            this.Tastatura.Controls.Add(this.btn7);
            this.Tastatura.Controls.Add(this.btn6);
            this.Tastatura.Controls.Add(this.btn5);
            this.Tastatura.Controls.Add(this.btn4);
            this.Tastatura.Controls.Add(this.btn3);
            this.Tastatura.Controls.Add(this.btn2);
            this.Tastatura.Controls.Add(this.btn1);
            this.Tastatura.Location = new System.Drawing.Point(12, 99);
            this.Tastatura.Name = "Tastatura";
            this.Tastatura.Size = new System.Drawing.Size(287, 337);
            this.Tastatura.TabIndex = 2;
            this.Tastatura.TabStop = false;
            this.Tastatura.Text = "Tastatura";
            // 
            // btnBackspace
            // 
            this.btnBackspace.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBackspace.Location = new System.Drawing.Point(186, 252);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(95, 79);
            this.btnBackspace.TabIndex = 8;
            this.btnBackspace.Text = "Backspace";
            this.btnBackspace.UseVisualStyleBackColor = false;
            this.btnBackspace.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn0.Location = new System.Drawing.Point(94, 252);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(86, 79);
            this.btn0.TabIndex = 7;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.valoareaNumerica);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCE.Location = new System.Drawing.Point(6, 252);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(82, 79);
            this.btnCE.TabIndex = 3;
            this.btnCE.Text = "C";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn9.Location = new System.Drawing.Point(186, 166);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(95, 80);
            this.btn9.TabIndex = 6;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.valoareaNumerica);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn8.Location = new System.Drawing.Point(94, 166);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(86, 80);
            this.btn8.TabIndex = 5;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.valoareaNumerica);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn7.Location = new System.Drawing.Point(6, 166);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(82, 80);
            this.btn7.TabIndex = 3;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.valoareaNumerica);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn6.Location = new System.Drawing.Point(186, 89);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(95, 71);
            this.btn6.TabIndex = 4;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.valoareaNumerica);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn5.Location = new System.Drawing.Point(94, 89);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(86, 71);
            this.btn5.TabIndex = 3;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.valoareaNumerica);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn4.Location = new System.Drawing.Point(3, 89);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(85, 71);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.valoareaNumerica);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn3.Location = new System.Drawing.Point(186, 18);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(95, 65);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.valoareaNumerica);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn2.Location = new System.Drawing.Point(94, 18);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(86, 65);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.valoareaNumerica);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn1.Location = new System.Drawing.Point(6, 18);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(85, 65);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.valoareaNumerica);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPlus.Location = new System.Drawing.Point(6, 21);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(106, 85);
            this.btnPlus.TabIndex = 3;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.operatia);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFactorial);
            this.groupBox1.Controls.Add(this.btnModulo);
            this.groupBox1.Controls.Add(this.btnEgal);
            this.groupBox1.Controls.Add(this.btnImpartire);
            this.groupBox1.Controls.Add(this.btnInmultire);
            this.groupBox1.Controls.Add(this.btnMinus);
            this.groupBox1.Controls.Add(this.btnPlus);
            this.groupBox1.Location = new System.Drawing.Point(306, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 413);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operatii";
            // 
            // btnFactorial
            // 
            this.btnFactorial.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFactorial.Location = new System.Drawing.Point(118, 199);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(105, 123);
            this.btnFactorial.TabIndex = 9;
            this.btnFactorial.Text = "x!";
            this.btnFactorial.UseVisualStyleBackColor = false;
            this.btnFactorial.Click += new System.EventHandler(this.factorial);
            // 
            // btnModulo
            // 
            this.btnModulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnModulo.Location = new System.Drawing.Point(6, 199);
            this.btnModulo.Name = "btnModulo";
            this.btnModulo.Size = new System.Drawing.Size(106, 123);
            this.btnModulo.TabIndex = 8;
            this.btnModulo.Text = "%";
            this.btnModulo.UseVisualStyleBackColor = false;
            this.btnModulo.Click += new System.EventHandler(this.operatia);
            // 
            // btnEgal
            // 
            this.btnEgal.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnEgal.Location = new System.Drawing.Point(6, 328);
            this.btnEgal.Name = "btnEgal";
            this.btnEgal.Size = new System.Drawing.Size(217, 79);
            this.btnEgal.TabIndex = 7;
            this.btnEgal.Text = "=";
            this.btnEgal.UseVisualStyleBackColor = false;
            this.btnEgal.Click += new System.EventHandler(this.btnEgal_Click);
            // 
            // btnImpartire
            // 
            this.btnImpartire.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnImpartire.Location = new System.Drawing.Point(118, 112);
            this.btnImpartire.Name = "btnImpartire";
            this.btnImpartire.Size = new System.Drawing.Size(105, 81);
            this.btnImpartire.TabIndex = 6;
            this.btnImpartire.Text = "/";
            this.btnImpartire.UseVisualStyleBackColor = false;
            this.btnImpartire.Click += new System.EventHandler(this.operatia);
            // 
            // btnInmultire
            // 
            this.btnInmultire.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInmultire.Location = new System.Drawing.Point(6, 112);
            this.btnInmultire.Name = "btnInmultire";
            this.btnInmultire.Size = new System.Drawing.Size(106, 81);
            this.btnInmultire.TabIndex = 5;
            this.btnInmultire.Text = "*";
            this.btnInmultire.UseVisualStyleBackColor = false;
            this.btnInmultire.Click += new System.EventHandler(this.operatia);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMinus.Location = new System.Drawing.Point(118, 21);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(105, 85);
            this.btnMinus.TabIndex = 4;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.operatia);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(550, 503);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Tastatura);
            this.Controls.Add(this.txtDisplay);
            this.Name = "Form1";
            this.Text = "Calculator - Sfranciog Tema1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.valoareaNumerica);
            this.Tastatura.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox Tastatura;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEgal;
        private System.Windows.Forms.Button btnImpartire;
        private System.Windows.Forms.Button btnInmultire;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnFactorial;
        private System.Windows.Forms.Button btnModulo;
    }
}


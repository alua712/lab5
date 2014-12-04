namespace ELALab5
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFactorial = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.btnPrime = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnTen = new System.Windows.Forms.Button();
            this.lblFactorial = new System.Windows.Forms.Label();
            this.lblPrime = new System.Windows.Forms.Label();
            this.lblSqrt = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFactorial
            // 
            this.btnFactorial.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnFactorial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFactorial.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactorial.Location = new System.Drawing.Point(214, 125);
            this.btnFactorial.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(192, 49);
            this.btnFactorial.TabIndex = 1;
            this.btnFactorial.Text = "Find factorial";
            this.btnFactorial.UseVisualStyleBackColor = false;
            this.btnFactorial.Click += new System.EventHandler(this.btnFactorial_Click);
            // 
            // closeButton
            // 
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Miramonte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.Red;
            this.closeButton.Location = new System.Drawing.Point(468, 12);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(40, 35);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // btnPrime
            // 
            this.btnPrime.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnPrime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrime.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrime.Location = new System.Drawing.Point(214, 186);
            this.btnPrime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPrime.Name = "btnPrime";
            this.btnPrime.Size = new System.Drawing.Size(192, 49);
            this.btnPrime.TabIndex = 3;
            this.btnPrime.Text = "Determine is prime?";
            this.btnPrime.UseVisualStyleBackColor = false;
            this.btnPrime.Click += new System.EventHandler(this.btnPrime_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSqrt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSqrt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqrt.Location = new System.Drawing.Point(214, 246);
            this.btnSqrt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(192, 49);
            this.btnSqrt.TabIndex = 4;
            this.btnSqrt.Text = "Find quadratic root";
            this.btnSqrt.UseVisualStyleBackColor = false;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnTen
            // 
            this.btnTen.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnTen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTen.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTen.Location = new System.Drawing.Point(214, 303);
            this.btnTen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTen.Name = "btnTen";
            this.btnTen.Size = new System.Drawing.Size(192, 49);
            this.btnTen.TabIndex = 5;
            this.btnTen.Text = "Find number in 10 power";
            this.btnTen.UseVisualStyleBackColor = false;
            this.btnTen.Click += new System.EventHandler(this.btnTen_Click);
            // 
            // lblFactorial
            // 
            this.lblFactorial.AutoSize = true;
            this.lblFactorial.Location = new System.Drawing.Point(46, 139);
            this.lblFactorial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFactorial.Name = "lblFactorial";
            this.lblFactorial.Size = new System.Drawing.Size(13, 20);
            this.lblFactorial.TabIndex = 6;
            this.lblFactorial.Text = " ";
            this.lblFactorial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrime
            // 
            this.lblPrime.AutoSize = true;
            this.lblPrime.Location = new System.Drawing.Point(44, 202);
            this.lblPrime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrime.Name = "lblPrime";
            this.lblPrime.Size = new System.Drawing.Size(13, 20);
            this.lblPrime.TabIndex = 7;
            this.lblPrime.Text = " ";
            this.lblPrime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSqrt
            // 
            this.lblSqrt.AutoSize = true;
            this.lblSqrt.Location = new System.Drawing.Point(44, 260);
            this.lblSqrt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSqrt.Name = "lblSqrt";
            this.lblSqrt.Size = new System.Drawing.Size(13, 20);
            this.lblSqrt.TabIndex = 8;
            this.lblSqrt.Text = " ";
            this.lblSqrt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(44, 317);
            this.lblTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(13, 20);
            this.lblTen.TabIndex = 9;
            this.lblTen.Text = " ";
            this.lblTen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbNumber
            // 
            this.tbNumber.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNumber.Font = new System.Drawing.Font("Lindsey", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumber.Location = new System.Drawing.Point(214, 76);
            this.tbNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(270, 30);
            this.tbNumber.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(414, 125);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 49);
            this.button1.TabIndex = 12;
            this.button1.Text = "Receive";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(521, 387);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblSqrt);
            this.Controls.Add(this.lblPrime);
            this.Controls.Add(this.lblFactorial);
            this.Controls.Add(this.btnTen);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnPrime);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.btnFactorial);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFactorial;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button btnPrime;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnTen;
        private System.Windows.Forms.Label lblFactorial;
        private System.Windows.Forms.Label lblPrime;
        private System.Windows.Forms.Label lblSqrt;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Button button1;
    }
}


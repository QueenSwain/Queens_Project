namespace Calculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.n1 = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n8 = new System.Windows.Forms.Button();
            this.n7 = new System.Windows.Forms.Button();
            this.nDot = new System.Windows.Forms.Button();
            this.n0 = new System.Windows.Forms.Button();
            this.nCancel = new System.Windows.Forms.Button();
            this.n9 = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(23, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(286, 41);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            // 
            // n1
            // 
            this.n1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.n1.Font = new System.Drawing.Font("Courier New", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n1.Location = new System.Drawing.Point(23, 94);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(67, 63);
            this.n1.TabIndex = 1;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = false;
            this.n1.Click += new System.EventHandler(this.btnClick_Event);
            // 
            // n2
            // 
            this.n2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.n2.Font = new System.Drawing.Font("Courier New", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n2.Location = new System.Drawing.Point(96, 94);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(67, 63);
            this.n2.TabIndex = 2;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = false;
            this.n2.Click += new System.EventHandler(this.btnClick_Event);
            // 
            // n3
            // 
            this.n3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.n3.Font = new System.Drawing.Font("Courier New", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n3.Location = new System.Drawing.Point(169, 94);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(67, 63);
            this.n3.TabIndex = 3;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = false;
            this.n3.Click += new System.EventHandler(this.btnClick_Event);
            // 
            // n4
            // 
            this.n4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.n4.Font = new System.Drawing.Font("Courier New", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n4.Location = new System.Drawing.Point(23, 163);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(67, 63);
            this.n4.TabIndex = 4;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = false;
            this.n4.Click += new System.EventHandler(this.btnClick_Event);
            // 
            // n5
            // 
            this.n5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.n5.Font = new System.Drawing.Font("Courier New", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n5.Location = new System.Drawing.Point(96, 163);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(67, 63);
            this.n5.TabIndex = 5;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = false;
            this.n5.Click += new System.EventHandler(this.btnClick_Event);
            // 
            // n8
            // 
            this.n8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.n8.Font = new System.Drawing.Font("Courier New", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n8.Location = new System.Drawing.Point(96, 232);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(67, 63);
            this.n8.TabIndex = 7;
            this.n8.Text = "8";
            this.n8.UseVisualStyleBackColor = false;
            this.n8.Click += new System.EventHandler(this.btnClick_Event);
            // 
            // n7
            // 
            this.n7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.n7.Font = new System.Drawing.Font("Courier New", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n7.Location = new System.Drawing.Point(23, 232);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(67, 63);
            this.n7.TabIndex = 6;
            this.n7.Text = "7";
            this.n7.UseVisualStyleBackColor = false;
            this.n7.Click += new System.EventHandler(this.btnClick_Event);
            // 
            // nDot
            // 
            this.nDot.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.nDot.Font = new System.Drawing.Font("Courier New", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nDot.Location = new System.Drawing.Point(96, 301);
            this.nDot.Name = "nDot";
            this.nDot.Size = new System.Drawing.Size(67, 63);
            this.nDot.TabIndex = 9;
            this.nDot.Text = ".";
            this.nDot.UseVisualStyleBackColor = false;
            this.nDot.Click += new System.EventHandler(this.nDot_Click);
            // 
            // n0
            // 
            this.n0.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.n0.Font = new System.Drawing.Font("Courier New", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n0.Location = new System.Drawing.Point(23, 301);
            this.n0.Name = "n0";
            this.n0.Size = new System.Drawing.Size(67, 63);
            this.n0.TabIndex = 8;
            this.n0.Text = "0";
            this.n0.UseVisualStyleBackColor = false;
            this.n0.Click += new System.EventHandler(this.btnClick_Event);
            // 
            // nCancel
            // 
            this.nCancel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.nCancel.Font = new System.Drawing.Font("Courier New", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nCancel.Location = new System.Drawing.Point(169, 301);
            this.nCancel.Name = "nCancel";
            this.nCancel.Size = new System.Drawing.Size(67, 63);
            this.nCancel.TabIndex = 12;
            this.nCancel.Text = "C";
            this.nCancel.UseVisualStyleBackColor = false;
            this.nCancel.Click += new System.EventHandler(this.nCancel_Click);
            // 
            // n9
            // 
            this.n9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.n9.Font = new System.Drawing.Font("Courier New", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n9.Location = new System.Drawing.Point(169, 232);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(67, 63);
            this.n9.TabIndex = 11;
            this.n9.Text = "9";
            this.n9.UseVisualStyleBackColor = false;
            this.n9.Click += new System.EventHandler(this.btnClick_Event);
            // 
            // n6
            // 
            this.n6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.n6.Font = new System.Drawing.Font("Courier New", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n6.Location = new System.Drawing.Point(169, 163);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(67, 63);
            this.n6.TabIndex = 10;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = false;
            this.n6.Click += new System.EventHandler(this.btnClick_Event);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEqual.Font = new System.Drawing.Font("Courier New", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.Location = new System.Drawing.Point(96, 370);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(67, 63);
            this.btnEqual.TabIndex = 13;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSub.Font = new System.Drawing.Font("Courier New", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.Location = new System.Drawing.Point(242, 301);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(67, 63);
            this.btnSub.TabIndex = 17;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Courier New", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(242, 232);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(67, 63);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // btnMul
            // 
            this.btnMul.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnMul.Font = new System.Drawing.Font("Courier New", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMul.Location = new System.Drawing.Point(242, 163);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(67, 63);
            this.btnMul.TabIndex = 15;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = false;
            this.btnMul.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDiv.Font = new System.Drawing.Font("Courier New", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Location = new System.Drawing.Point(242, 94);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(67, 63);
            this.btnDiv.TabIndex = 14;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 450);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.nCancel);
            this.Controls.Add(this.n9);
            this.Controls.Add(this.n6);
            this.Controls.Add(this.nDot);
            this.Controls.Add(this.n0);
            this.Controls.Add(this.n8);
            this.Controls.Add(this.n7);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button n1;
        private System.Windows.Forms.Button n2;
        private System.Windows.Forms.Button n3;
        private System.Windows.Forms.Button n4;
        private System.Windows.Forms.Button n5;
        private System.Windows.Forms.Button n8;
        private System.Windows.Forms.Button n7;
        private System.Windows.Forms.Button nDot;
        private System.Windows.Forms.Button n0;
        private System.Windows.Forms.Button nCancel;
        private System.Windows.Forms.Button n9;
        private System.Windows.Forms.Button n6;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnDiv;
    }
}


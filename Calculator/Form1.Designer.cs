namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button_0 = new System.Windows.Forms.Button();
            this.Button_Comma = new System.Windows.Forms.Button();
            this.Button_Plus = new System.Windows.Forms.Button();
            this.Button_Result = new System.Windows.Forms.Button();
            this.Button_Minus = new System.Windows.Forms.Button();
            this.Button_Reciprocal = new System.Windows.Forms.Button();
            this.Button_Percent = new System.Windows.Forms.Button();
            this.Button_Sqrt = new System.Windows.Forms.Button();
            this.Button_MMinus = new System.Windows.Forms.Button();
            this.Button_Multiply = new System.Windows.Forms.Button();
            this.Button_Divide = new System.Windows.Forms.Button();
            this.Button_PlusMinus = new System.Windows.Forms.Button();
            this.Button_MPlus = new System.Windows.Forms.Button();
            this.Button_6 = new System.Windows.Forms.Button();
            this.Button_CE = new System.Windows.Forms.Button();
            this.Button_C = new System.Windows.Forms.Button();
            this.Button_5 = new System.Windows.Forms.Button();
            this.Button_3 = new System.Windows.Forms.Button();
            this.Button_MR = new System.Windows.Forms.Button();
            this.Button_MS = new System.Windows.Forms.Button();
            this.Button_8 = new System.Windows.Forms.Button();
            this.Button_4 = new System.Windows.Forms.Button();
            this.Button_2 = new System.Windows.Forms.Button();
            this.Button_MC = new System.Windows.Forms.Button();
            this.Button_Remove = new System.Windows.Forms.Button();
            this.Button_7 = new System.Windows.Forms.Button();
            this.Button_9 = new System.Windows.Forms.Button();
            this.Button_1 = new System.Windows.Forms.Button();
            this.Label_Calculation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button_0
            // 
            this.Button_0.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_0.Location = new System.Drawing.Point(10, 228);
            this.Button_0.Name = "Button_0";
            this.Button_0.Size = new System.Drawing.Size(73, 30);
            this.Button_0.TabIndex = 0;
            this.Button_0.Text = "0";
            this.Button_0.UseVisualStyleBackColor = true;
            this.Button_0.Click += new System.EventHandler(this.Button_0_Click);
            // 
            // Button_Comma
            // 
            this.Button_Comma.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Comma.Location = new System.Drawing.Point(86, 228);
            this.Button_Comma.Name = "Button_Comma";
            this.Button_Comma.Size = new System.Drawing.Size(35, 30);
            this.Button_Comma.TabIndex = 1;
            this.Button_Comma.Text = ",";
            this.Button_Comma.UseVisualStyleBackColor = true;
            this.Button_Comma.Click += new System.EventHandler(this.Button_Comma_Click);
            // 
            // Button_Plus
            // 
            this.Button_Plus.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Plus.Location = new System.Drawing.Point(124, 228);
            this.Button_Plus.Name = "Button_Plus";
            this.Button_Plus.Size = new System.Drawing.Size(35, 30);
            this.Button_Plus.TabIndex = 2;
            this.Button_Plus.Text = "+";
            this.Button_Plus.UseVisualStyleBackColor = true;
            this.Button_Plus.Click += new System.EventHandler(this.Button_Plus_Click);
            // 
            // Button_Result
            // 
            this.Button_Result.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Result.Location = new System.Drawing.Point(162, 195);
            this.Button_Result.Name = "Button_Result";
            this.Button_Result.Size = new System.Drawing.Size(35, 63);
            this.Button_Result.TabIndex = 3;
            this.Button_Result.Text = "=";
            this.Button_Result.UseVisualStyleBackColor = true;
            this.Button_Result.Click += new System.EventHandler(this.Button_Result_Click);
            // 
            // Button_Minus
            // 
            this.Button_Minus.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Minus.Location = new System.Drawing.Point(124, 195);
            this.Button_Minus.Name = "Button_Minus";
            this.Button_Minus.Size = new System.Drawing.Size(35, 30);
            this.Button_Minus.TabIndex = 4;
            this.Button_Minus.Text = "-";
            this.Button_Minus.UseVisualStyleBackColor = true;
            this.Button_Minus.Click += new System.EventHandler(this.Button_Minus_Click);
            // 
            // Button_Reciprocal
            // 
            this.Button_Reciprocal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Reciprocal.Location = new System.Drawing.Point(162, 162);
            this.Button_Reciprocal.Name = "Button_Reciprocal";
            this.Button_Reciprocal.Size = new System.Drawing.Size(35, 30);
            this.Button_Reciprocal.TabIndex = 5;
            this.Button_Reciprocal.Text = "1/x";
            this.Button_Reciprocal.UseVisualStyleBackColor = true;
            this.Button_Reciprocal.Click += new System.EventHandler(this.Button_Reciprocal_Click);
            // 
            // Button_Percent
            // 
            this.Button_Percent.Enabled = false;
            this.Button_Percent.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Percent.Location = new System.Drawing.Point(162, 129);
            this.Button_Percent.Name = "Button_Percent";
            this.Button_Percent.Size = new System.Drawing.Size(35, 30);
            this.Button_Percent.TabIndex = 6;
            this.Button_Percent.Text = "%";
            this.Button_Percent.UseVisualStyleBackColor = true;
            this.Button_Percent.Click += new System.EventHandler(this.Button_Percent_Click);
            // 
            // Button_Sqrt
            // 
            this.Button_Sqrt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Sqrt.Location = new System.Drawing.Point(162, 96);
            this.Button_Sqrt.Name = "Button_Sqrt";
            this.Button_Sqrt.Size = new System.Drawing.Size(35, 30);
            this.Button_Sqrt.TabIndex = 7;
            this.Button_Sqrt.Text = "√";
            this.Button_Sqrt.UseVisualStyleBackColor = true;
            this.Button_Sqrt.Click += new System.EventHandler(this.Button_Sqrt_Click);
            // 
            // Button_MMinus
            // 
            this.Button_MMinus.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_MMinus.Location = new System.Drawing.Point(162, 63);
            this.Button_MMinus.Name = "Button_MMinus";
            this.Button_MMinus.Size = new System.Drawing.Size(35, 30);
            this.Button_MMinus.TabIndex = 8;
            this.Button_MMinus.Text = "M-";
            this.Button_MMinus.UseVisualStyleBackColor = true;
            this.Button_MMinus.Click += new System.EventHandler(this.Button_MMinus_Click);
            // 
            // Button_Multiply
            // 
            this.Button_Multiply.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Multiply.Location = new System.Drawing.Point(124, 162);
            this.Button_Multiply.Name = "Button_Multiply";
            this.Button_Multiply.Size = new System.Drawing.Size(35, 30);
            this.Button_Multiply.TabIndex = 9;
            this.Button_Multiply.Text = "∗";
            this.Button_Multiply.UseVisualStyleBackColor = true;
            this.Button_Multiply.Click += new System.EventHandler(this.Button_Multiply_Click);
            // 
            // Button_Divide
            // 
            this.Button_Divide.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Divide.Location = new System.Drawing.Point(124, 129);
            this.Button_Divide.Name = "Button_Divide";
            this.Button_Divide.Size = new System.Drawing.Size(35, 30);
            this.Button_Divide.TabIndex = 10;
            this.Button_Divide.Text = "/";
            this.Button_Divide.UseVisualStyleBackColor = true;
            this.Button_Divide.Click += new System.EventHandler(this.Button_Divide_Click);
            // 
            // Button_PlusMinus
            // 
            this.Button_PlusMinus.Enabled = false;
            this.Button_PlusMinus.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_PlusMinus.Location = new System.Drawing.Point(124, 96);
            this.Button_PlusMinus.Name = "Button_PlusMinus";
            this.Button_PlusMinus.Size = new System.Drawing.Size(35, 30);
            this.Button_PlusMinus.TabIndex = 11;
            this.Button_PlusMinus.Text = "±";
            this.Button_PlusMinus.UseVisualStyleBackColor = true;
            this.Button_PlusMinus.Click += new System.EventHandler(this.Button_PlusMinus_Click);
            // 
            // Button_MPlus
            // 
            this.Button_MPlus.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_MPlus.Location = new System.Drawing.Point(124, 63);
            this.Button_MPlus.Name = "Button_MPlus";
            this.Button_MPlus.Size = new System.Drawing.Size(35, 30);
            this.Button_MPlus.TabIndex = 12;
            this.Button_MPlus.Text = "M+";
            this.Button_MPlus.UseVisualStyleBackColor = true;
            this.Button_MPlus.Click += new System.EventHandler(this.Button_MPlus_Click);
            // 
            // Button_6
            // 
            this.Button_6.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_6.Location = new System.Drawing.Point(86, 162);
            this.Button_6.Name = "Button_6";
            this.Button_6.Size = new System.Drawing.Size(35, 30);
            this.Button_6.TabIndex = 17;
            this.Button_6.Text = "6";
            this.Button_6.UseVisualStyleBackColor = true;
            this.Button_6.Click += new System.EventHandler(this.Button_6_Click);
            // 
            // Button_CE
            // 
            this.Button_CE.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_CE.Location = new System.Drawing.Point(48, 96);
            this.Button_CE.Name = "Button_CE";
            this.Button_CE.Size = new System.Drawing.Size(35, 30);
            this.Button_CE.TabIndex = 16;
            this.Button_CE.Text = "CE";
            this.Button_CE.UseVisualStyleBackColor = true;
            this.Button_CE.Click += new System.EventHandler(this.Button_CE_Click);
            // 
            // Button_C
            // 
            this.Button_C.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_C.Location = new System.Drawing.Point(86, 96);
            this.Button_C.Name = "Button_C";
            this.Button_C.Size = new System.Drawing.Size(35, 30);
            this.Button_C.TabIndex = 15;
            this.Button_C.Text = "C";
            this.Button_C.UseVisualStyleBackColor = true;
            this.Button_C.Click += new System.EventHandler(this.Button_C_Click);
            // 
            // Button_5
            // 
            this.Button_5.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_5.Location = new System.Drawing.Point(48, 162);
            this.Button_5.Name = "Button_5";
            this.Button_5.Size = new System.Drawing.Size(35, 30);
            this.Button_5.TabIndex = 14;
            this.Button_5.Text = "5";
            this.Button_5.UseVisualStyleBackColor = true;
            this.Button_5.Click += new System.EventHandler(this.Button_5_Click);
            // 
            // Button_3
            // 
            this.Button_3.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_3.Location = new System.Drawing.Point(86, 195);
            this.Button_3.Name = "Button_3";
            this.Button_3.Size = new System.Drawing.Size(35, 30);
            this.Button_3.TabIndex = 13;
            this.Button_3.Text = "3";
            this.Button_3.UseVisualStyleBackColor = true;
            this.Button_3.Click += new System.EventHandler(this.Button_3_Click);
            // 
            // Button_MR
            // 
            this.Button_MR.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_MR.Location = new System.Drawing.Point(48, 63);
            this.Button_MR.Name = "Button_MR";
            this.Button_MR.Size = new System.Drawing.Size(35, 30);
            this.Button_MR.TabIndex = 22;
            this.Button_MR.Text = "MR";
            this.Button_MR.UseVisualStyleBackColor = true;
            this.Button_MR.Click += new System.EventHandler(this.Button_MR_Click);
            // 
            // Button_MS
            // 
            this.Button_MS.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_MS.Location = new System.Drawing.Point(86, 63);
            this.Button_MS.Name = "Button_MS";
            this.Button_MS.Size = new System.Drawing.Size(35, 30);
            this.Button_MS.TabIndex = 21;
            this.Button_MS.Text = "MS";
            this.Button_MS.UseVisualStyleBackColor = true;
            this.Button_MS.Click += new System.EventHandler(this.Button_MS_Click);
            // 
            // Button_8
            // 
            this.Button_8.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_8.Location = new System.Drawing.Point(48, 129);
            this.Button_8.Name = "Button_8";
            this.Button_8.Size = new System.Drawing.Size(35, 30);
            this.Button_8.TabIndex = 20;
            this.Button_8.Text = "8";
            this.Button_8.UseVisualStyleBackColor = true;
            this.Button_8.Click += new System.EventHandler(this.Button_8_Click);
            // 
            // Button_4
            // 
            this.Button_4.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_4.Location = new System.Drawing.Point(10, 162);
            this.Button_4.Name = "Button_4";
            this.Button_4.Size = new System.Drawing.Size(35, 30);
            this.Button_4.TabIndex = 19;
            this.Button_4.Text = "4";
            this.Button_4.UseVisualStyleBackColor = true;
            this.Button_4.Click += new System.EventHandler(this.Button_4_Click);
            // 
            // Button_2
            // 
            this.Button_2.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_2.Location = new System.Drawing.Point(48, 195);
            this.Button_2.Name = "Button_2";
            this.Button_2.Size = new System.Drawing.Size(35, 30);
            this.Button_2.TabIndex = 18;
            this.Button_2.Text = "2";
            this.Button_2.UseVisualStyleBackColor = true;
            this.Button_2.Click += new System.EventHandler(this.Button_2_Click);
            // 
            // Button_MC
            // 
            this.Button_MC.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_MC.Location = new System.Drawing.Point(10, 63);
            this.Button_MC.Name = "Button_MC";
            this.Button_MC.Size = new System.Drawing.Size(35, 30);
            this.Button_MC.TabIndex = 27;
            this.Button_MC.Text = "MC";
            this.Button_MC.UseVisualStyleBackColor = true;
            this.Button_MC.Click += new System.EventHandler(this.Button_MC_Click);
            // 
            // Button_Remove
            // 
            this.Button_Remove.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Remove.Location = new System.Drawing.Point(10, 96);
            this.Button_Remove.Name = "Button_Remove";
            this.Button_Remove.Size = new System.Drawing.Size(35, 30);
            this.Button_Remove.TabIndex = 26;
            this.Button_Remove.Text = "←";
            this.Button_Remove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_Remove.UseVisualStyleBackColor = true;
            this.Button_Remove.Click += new System.EventHandler(this.Button_Remove_Click);
            // 
            // Button_7
            // 
            this.Button_7.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_7.Location = new System.Drawing.Point(10, 129);
            this.Button_7.Name = "Button_7";
            this.Button_7.Size = new System.Drawing.Size(35, 30);
            this.Button_7.TabIndex = 25;
            this.Button_7.Text = "7";
            this.Button_7.UseVisualStyleBackColor = true;
            this.Button_7.Click += new System.EventHandler(this.Button_7_Click);
            // 
            // Button_9
            // 
            this.Button_9.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_9.Location = new System.Drawing.Point(86, 129);
            this.Button_9.Name = "Button_9";
            this.Button_9.Size = new System.Drawing.Size(35, 30);
            this.Button_9.TabIndex = 24;
            this.Button_9.Text = "9";
            this.Button_9.UseVisualStyleBackColor = true;
            this.Button_9.Click += new System.EventHandler(this.Button_9_Click);
            // 
            // Button_1
            // 
            this.Button_1.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_1.Location = new System.Drawing.Point(10, 195);
            this.Button_1.Name = "Button_1";
            this.Button_1.Size = new System.Drawing.Size(35, 30);
            this.Button_1.TabIndex = 23;
            this.Button_1.Text = "1";
            this.Button_1.UseVisualStyleBackColor = true;
            this.Button_1.Click += new System.EventHandler(this.Button_1_Click);
            // 
            // Label_Calculation
            // 
            this.Label_Calculation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label_Calculation.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Calculation.Location = new System.Drawing.Point(10, 10);
            this.Label_Calculation.Name = "Label_Calculation";
            this.Label_Calculation.Size = new System.Drawing.Size(187, 50);
            this.Label_Calculation.TabIndex = 28;
            this.Label_Calculation.Text = "0";
            this.Label_Calculation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 268);
            this.Controls.Add(this.Label_Calculation);
            this.Controls.Add(this.Button_MC);
            this.Controls.Add(this.Button_Remove);
            this.Controls.Add(this.Button_7);
            this.Controls.Add(this.Button_9);
            this.Controls.Add(this.Button_1);
            this.Controls.Add(this.Button_MR);
            this.Controls.Add(this.Button_MS);
            this.Controls.Add(this.Button_8);
            this.Controls.Add(this.Button_4);
            this.Controls.Add(this.Button_2);
            this.Controls.Add(this.Button_6);
            this.Controls.Add(this.Button_CE);
            this.Controls.Add(this.Button_C);
            this.Controls.Add(this.Button_5);
            this.Controls.Add(this.Button_3);
            this.Controls.Add(this.Button_MPlus);
            this.Controls.Add(this.Button_PlusMinus);
            this.Controls.Add(this.Button_Divide);
            this.Controls.Add(this.Button_Multiply);
            this.Controls.Add(this.Button_MMinus);
            this.Controls.Add(this.Button_Sqrt);
            this.Controls.Add(this.Button_Percent);
            this.Controls.Add(this.Button_Reciprocal);
            this.Controls.Add(this.Button_Minus);
            this.Controls.Add(this.Button_Result);
            this.Controls.Add(this.Button_Plus);
            this.Controls.Add(this.Button_Comma);
            this.Controls.Add(this.Button_0);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_0;
        private System.Windows.Forms.Button Button_Comma;
        private System.Windows.Forms.Button Button_Plus;
        private System.Windows.Forms.Button Button_Result;
        private System.Windows.Forms.Button Button_Minus;
        private System.Windows.Forms.Button Button_Reciprocal;
        private System.Windows.Forms.Button Button_Percent;
        private System.Windows.Forms.Button Button_Sqrt;
        private System.Windows.Forms.Button Button_MMinus;
        private System.Windows.Forms.Button Button_Multiply;
        private System.Windows.Forms.Button Button_Divide;
        private System.Windows.Forms.Button Button_PlusMinus;
        private System.Windows.Forms.Button Button_MPlus;
        private System.Windows.Forms.Button Button_6;
        private System.Windows.Forms.Button Button_CE;
        private System.Windows.Forms.Button Button_C;
        private System.Windows.Forms.Button Button_5;
        private System.Windows.Forms.Button Button_3;
        private System.Windows.Forms.Button Button_MR;
        private System.Windows.Forms.Button Button_MS;
        private System.Windows.Forms.Button Button_8;
        private System.Windows.Forms.Button Button_4;
        private System.Windows.Forms.Button Button_2;
        private System.Windows.Forms.Button Button_MC;
        private System.Windows.Forms.Button Button_Remove;
        private System.Windows.Forms.Button Button_7;
        private System.Windows.Forms.Button Button_9;
        private System.Windows.Forms.Button Button_1;
        private System.Windows.Forms.Label Label_Calculation;
    }
}


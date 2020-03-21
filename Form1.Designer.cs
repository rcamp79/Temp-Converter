namespace TempConvert2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonF = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.valueF = new System.Windows.Forms.TextBox();
            this.valueC = new System.Windows.Forms.TextBox();
            this.tempValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.buttonExit);
            this.groupBox1.Controls.Add(this.buttonClear);
            this.groupBox1.Controls.Add(this.buttonF);
            this.groupBox1.Controls.Add(this.buttonC);
            this.groupBox1.Controls.Add(this.valueF);
            this.groupBox1.Controls.Add(this.valueC);
            this.groupBox1.Controls.Add(this.tempValue);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(49, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(515, 240);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Location = new System.Drawing.Point(269, 198);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(100, 28);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClear.Location = new System.Drawing.Point(57, 198);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(100, 28);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clea&r";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // buttonF
            // 
            this.buttonF.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonF.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonF.Location = new System.Drawing.Point(269, 142);
            this.buttonF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonF.Name = "buttonF";
            this.buttonF.Size = new System.Drawing.Size(100, 28);
            this.buttonF.TabIndex = 5;
            this.buttonF.Text = "&Fahrenheit";
            this.buttonF.UseVisualStyleBackColor = false;
            this.buttonF.Click += new System.EventHandler(this.ButtonF_Click);
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonC.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonC.Location = new System.Drawing.Point(57, 142);
            this.buttonC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(100, 28);
            this.buttonC.TabIndex = 4;
            this.buttonC.Text = "&Celsius";
            this.buttonC.UseVisualStyleBackColor = false;
            this.buttonC.Click += new System.EventHandler(this.ButtonC_Click);
            // 
            // valueF
            // 
            this.valueF.Location = new System.Drawing.Point(248, 110);
            this.valueF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.valueF.Name = "valueF";
            this.valueF.Size = new System.Drawing.Size(132, 22);
            this.valueF.TabIndex = 3;
            // 
            // valueC
            // 
            this.valueC.Location = new System.Drawing.Point(43, 110);
            this.valueC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.valueC.Name = "valueC";
            this.valueC.Size = new System.Drawing.Size(132, 22);
            this.valueC.TabIndex = 2;
            // 
            // tempValue
            // 
            this.tempValue.Location = new System.Drawing.Point(248, 25);
            this.tempValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tempValue.Name = "tempValue";
            this.tempValue.Size = new System.Drawing.Size(132, 22);
            this.tempValue.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter a temperature:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(611, 304);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperature Converter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonF;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.TextBox valueF;
        private System.Windows.Forms.TextBox valueC;
        private System.Windows.Forms.TextBox tempValue;
        private System.Windows.Forms.Label label1;
    }
}


namespace FinalArduinoForm
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
            this.ONbutton = new System.Windows.Forms.Button();
            this.OFFbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.COMbutton = new System.Windows.Forms.Button();
            this.READbutton = new System.Windows.Forms.Button();
            this.LOOPREADcx = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ONbutton
            // 
            this.ONbutton.Location = new System.Drawing.Point(19, 43);
            this.ONbutton.Name = "ONbutton";
            this.ONbutton.Size = new System.Drawing.Size(75, 23);
            this.ONbutton.TabIndex = 0;
            this.ONbutton.Text = "On";
            this.ONbutton.UseVisualStyleBackColor = true;
            this.ONbutton.Click += new System.EventHandler(this.ONbtCLICK);
            // 
            // OFFbutton
            // 
            this.OFFbutton.Location = new System.Drawing.Point(100, 43);
            this.OFFbutton.Name = "OFFbutton";
            this.OFFbutton.Size = new System.Drawing.Size(75, 23);
            this.OFFbutton.TabIndex = 1;
            this.OFFbutton.Text = "Off";
            this.OFFbutton.UseVisualStyleBackColor = true;
            this.OFFbutton.Click += new System.EventHandler(this.OFFbtCLICK);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "ARDUINO CONTROL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(181, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // COMbutton
            // 
            this.COMbutton.Location = new System.Drawing.Point(19, 72);
            this.COMbutton.Name = "COMbutton";
            this.COMbutton.Size = new System.Drawing.Size(75, 23);
            this.COMbutton.TabIndex = 6;
            this.COMbutton.Text = "COMMIT";
            this.COMbutton.UseVisualStyleBackColor = true;
            this.COMbutton.Click += new System.EventHandler(this.COMbtCLICK);
            // 
            // READbutton
            // 
            this.READbutton.Location = new System.Drawing.Point(19, 102);
            this.READbutton.Name = "READbutton";
            this.READbutton.Size = new System.Drawing.Size(75, 23);
            this.READbutton.TabIndex = 7;
            this.READbutton.Text = "SingleRead";
            this.READbutton.UseVisualStyleBackColor = true;
            this.READbutton.Click += new System.EventHandler(this.READbtCLICK);
            // 
            // LOOPREADcx
            // 
            this.LOOPREADcx.AutoSize = true;
            this.LOOPREADcx.Location = new System.Drawing.Point(100, 106);
            this.LOOPREADcx.Name = "LOOPREADcx";
            this.LOOPREADcx.Size = new System.Drawing.Size(79, 17);
            this.LOOPREADcx.TabIndex = 8;
            this.LOOPREADcx.Text = "Loop Read";
            this.LOOPREADcx.UseVisualStyleBackColor = true;
            this.LOOPREADcx.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 132);
            this.Controls.Add(this.LOOPREADcx);
            this.Controls.Add(this.READbutton);
            this.Controls.Add(this.COMbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OFFbutton);
            this.Controls.Add(this.ONbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ONbutton;
        private System.Windows.Forms.Button OFFbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button COMbutton;
        private System.Windows.Forms.Button READbutton;
        private System.Windows.Forms.CheckBox LOOPREADcx;
    }
}


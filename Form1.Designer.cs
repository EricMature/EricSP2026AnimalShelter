namespace EricSP2026AnimalShelter
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnimalWeight = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAnimalHeight = new System.Windows.Forms.TextBox();
            this.lstOut = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAnimalName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "BMI Calculation for Animal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "The Animal\'s &Weight";
            // 
            // txtAnimalWeight
            // 
            this.txtAnimalWeight.Location = new System.Drawing.Point(205, 113);
            this.txtAnimalWeight.Name = "txtAnimalWeight";
            this.txtAnimalWeight.Size = new System.Drawing.Size(172, 20);
            this.txtAnimalWeight.TabIndex = 6;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(38, 283);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 54);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate &Amount";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "The Animal\'s &Height";
            // 
            // txtAnimalHeight
            // 
            this.txtAnimalHeight.Location = new System.Drawing.Point(205, 81);
            this.txtAnimalHeight.Name = "txtAnimalHeight";
            this.txtAnimalHeight.Size = new System.Drawing.Size(172, 20);
            this.txtAnimalHeight.TabIndex = 4;
            // 
            // lstOut
            // 
            this.lstOut.FormattingEnabled = true;
            this.lstOut.Location = new System.Drawing.Point(38, 149);
            this.lstOut.Name = "lstOut";
            this.lstOut.Size = new System.Drawing.Size(339, 95);
            this.lstOut.TabIndex = 7;
            this.lstOut.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(158, 283);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 54);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(276, 283);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 54);
            this.btnQuit.TabIndex = 10;
            this.btnQuit.Text = "&Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "The Animal\'s &Name";
            // 
            // txtAnimalName
            // 
            this.txtAnimalName.Location = new System.Drawing.Point(205, 49);
            this.txtAnimalName.Name = "txtAnimalName";
            this.txtAnimalName.Size = new System.Drawing.Size(172, 20);
            this.txtAnimalName.TabIndex = 2;
            this.txtAnimalName.Enter += new System.EventHandler(this.txtAnimalName_Enter);
            this.txtAnimalName.Leave += new System.EventHandler(this.txtAnimalName_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 381);
            this.Controls.Add(this.txtAnimalName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lstOut);
            this.Controls.Add(this.txtAnimalWeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtAnimalHeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Eric\'s Animal Shelter Service";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAnimalWeight;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAnimalHeight;
        private System.Windows.Forms.ListBox lstOut;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAnimalName;
    }
}


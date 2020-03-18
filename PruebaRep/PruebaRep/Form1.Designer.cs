namespace PruebaRep
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
            this.btn_paramiform = new System.Windows.Forms.Button();
            this.lbl_quehace = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hola, qué hace?";
            // 
            // btn_paramiform
            // 
            this.btn_paramiform.Location = new System.Drawing.Point(13, 13);
            this.btn_paramiform.Name = "btn_paramiform";
            this.btn_paramiform.Size = new System.Drawing.Size(75, 23);
            this.btn_paramiform.TabIndex = 0;
            this.btn_paramiform.Text = "form2";
            this.btn_paramiform.UseVisualStyleBackColor = true;
            this.btn_paramiform.Click += new System.EventHandler(this.btn_paramiform_Click);
            // 
            // lbl_quehace
            // 
            this.lbl_quehace.AutoSize = true;
            this.lbl_quehace.Font = new System.Drawing.Font("Papyrus", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quehace.Location = new System.Drawing.Point(12, 176);
            this.lbl_quehace.Name = "lbl_quehace";
            this.lbl_quehace.Size = new System.Drawing.Size(334, 19);
            this.lbl_quehace.TabIndex = 1;
            this.lbl_quehace.Text = "PROGRAMANDO EN GIT O QUE HACE?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(363, 307);
            this.Controls.Add(this.lbl_quehace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_paramiform);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;

       private System.Windows.Forms.Button btn_paramiform;
       private System.Windows.Forms.Label lbl_quehace;
    }
}


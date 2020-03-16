namespace PruebaRep
{
    partial class frm_formulario2
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
            this.btn_nomedesclick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_nomedesclick
            // 
            this.btn_nomedesclick.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_nomedesclick.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_nomedesclick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nomedesclick.ForeColor = System.Drawing.Color.White;
            this.btn_nomedesclick.Location = new System.Drawing.Point(169, 54);
            this.btn_nomedesclick.Name = "btn_nomedesclick";
            this.btn_nomedesclick.Size = new System.Drawing.Size(114, 81);
            this.btn_nomedesclick.TabIndex = 0;
            this.btn_nomedesclick.Text = "No me des Click";
            this.btn_nomedesclick.UseVisualStyleBackColor = false;
            this.btn_nomedesclick.Click += new System.EventHandler(this.btn_nomedesclick_Click);
            // 
            // frm_formulario2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(434, 255);
            this.Controls.Add(this.btn_nomedesclick);
            this.Name = "frm_formulario2";
            this.Text = "frm_formulario2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_nomedesclick;
    }
}
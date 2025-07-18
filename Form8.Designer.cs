namespace Aplikacja1
{
    partial class Form8
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
            this.buttonReturn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAddAdm = new System.Windows.Forms.Button();
            this.buttonShowAdm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(577, 189);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(147, 55);
            this.buttonReturn.TabIndex = 0;
            this.buttonReturn.Text = "Powrót";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(618, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonAddAdm
            // 
            this.buttonAddAdm.Location = new System.Drawing.Point(94, 189);
            this.buttonAddAdm.Name = "buttonAddAdm";
            this.buttonAddAdm.Size = new System.Drawing.Size(147, 55);
            this.buttonAddAdm.TabIndex = 2;
            this.buttonAddAdm.Text = "Dodaj administatora";
            this.buttonAddAdm.UseVisualStyleBackColor = true;
            this.buttonAddAdm.Click += new System.EventHandler(this.buttonAddAdm_Click);
            // 
            // buttonShowAdm
            // 
            this.buttonShowAdm.Location = new System.Drawing.Point(334, 189);
            this.buttonShowAdm.Name = "buttonShowAdm";
            this.buttonShowAdm.Size = new System.Drawing.Size(147, 55);
            this.buttonShowAdm.TabIndex = 3;
            this.buttonShowAdm.Text = "Zobacz aktualnych administratorów";
            this.buttonShowAdm.UseVisualStyleBackColor = true;
            this.buttonShowAdm.Click += new System.EventHandler(this.buttonShowAdm_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonShowAdm);
            this.Controls.Add(this.buttonAddAdm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonReturn);
            this.Name = "Form8";
            this.Text = "Panel administratora";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAddAdm;
        private System.Windows.Forms.Button buttonShowAdm;
    }
}
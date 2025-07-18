namespace Aplikacja1
{
    partial class Form5
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
            this.comboBoxChooseService = new System.Windows.Forms.ComboBox();
            this.textBoxServiceName = new System.Windows.Forms.TextBox();
            this.textBoxServiceStatus = new System.Windows.Forms.TextBox();
            this.textBoxServiceOwner = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCLearContent = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wybierz serwis";
            // 
            // comboBoxChooseService
            // 
            this.comboBoxChooseService.FormattingEnabled = true;
            this.comboBoxChooseService.Location = new System.Drawing.Point(108, 110);
            this.comboBoxChooseService.Name = "comboBoxChooseService";
            this.comboBoxChooseService.Size = new System.Drawing.Size(121, 21);
            this.comboBoxChooseService.TabIndex = 1;
            this.comboBoxChooseService.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseService_SelectedIndexChanged);
            // 
            // textBoxServiceName
            // 
            this.textBoxServiceName.Location = new System.Drawing.Point(108, 242);
            this.textBoxServiceName.Name = "textBoxServiceName";
            this.textBoxServiceName.Size = new System.Drawing.Size(132, 20);
            this.textBoxServiceName.TabIndex = 2;
            // 
            // textBoxServiceStatus
            // 
            this.textBoxServiceStatus.Location = new System.Drawing.Point(350, 242);
            this.textBoxServiceStatus.Name = "textBoxServiceStatus";
            this.textBoxServiceStatus.Size = new System.Drawing.Size(132, 20);
            this.textBoxServiceStatus.TabIndex = 3;
            // 
            // textBoxServiceOwner
            // 
            this.textBoxServiceOwner.Location = new System.Drawing.Point(597, 242);
            this.textBoxServiceOwner.Name = "textBoxServiceOwner";
            this.textBoxServiceOwner.Size = new System.Drawing.Size(132, 20);
            this.textBoxServiceOwner.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nazwa serwisu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Status serwisu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(594, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Właściciel";
            // 
            // buttonCLearContent
            // 
            this.buttonCLearContent.Location = new System.Drawing.Point(597, 297);
            this.buttonCLearContent.Name = "buttonCLearContent";
            this.buttonCLearContent.Size = new System.Drawing.Size(132, 33);
            this.buttonCLearContent.TabIndex = 8;
            this.buttonCLearContent.Text = "Wyczyść dane";
            this.buttonCLearContent.UseVisualStyleBackColor = true;
            this.buttonCLearContent.Click += new System.EventHandler(this.buttonCLearContent_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(597, 356);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(132, 34);
            this.buttonReturn.TabIndex = 15;
            this.buttonReturn.Text = "Powrót";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonCLearContent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxServiceOwner);
            this.Controls.Add(this.textBoxServiceStatus);
            this.Controls.Add(this.textBoxServiceName);
            this.Controls.Add(this.comboBoxChooseService);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Serwisy";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxChooseService;
        private System.Windows.Forms.TextBox textBoxServiceName;
        private System.Windows.Forms.TextBox textBoxServiceStatus;
        private System.Windows.Forms.TextBox textBoxServiceOwner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCLearContent;
        private System.Windows.Forms.Button buttonReturn;
    }
}
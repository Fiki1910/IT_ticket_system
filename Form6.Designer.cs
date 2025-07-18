namespace Aplikacja1
{
    partial class Form6
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
            this.comboBoxTIcketID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonCLearContent = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxAssignmentGroup = new System.Windows.Forms.TextBox();
            this.textBoxService = new System.Windows.Forms.TextBox();
            this.textBoxPriority = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxSolution = new System.Windows.Forms.TextBox();
            this.textBoxReportedDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wybierz ID zgłoszenia";
            // 
            // comboBoxTIcketID
            // 
            this.comboBoxTIcketID.FormattingEnabled = true;
            this.comboBoxTIcketID.Location = new System.Drawing.Point(110, 102);
            this.comboBoxTIcketID.Name = "comboBoxTIcketID";
            this.comboBoxTIcketID.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTIcketID.TabIndex = 1;
            this.comboBoxTIcketID.SelectedIndexChanged += new System.EventHandler(this.comboBoxTIcketID_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Użytkownik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Przypisana grupa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(450, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Serwis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Pilność";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Opis problemu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(450, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Rozwiązanie";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Data zgloszenia";
            // 
            // buttonCLearContent
            // 
            this.buttonCLearContent.Location = new System.Drawing.Point(453, 25);
            this.buttonCLearContent.Name = "buttonCLearContent";
            this.buttonCLearContent.Size = new System.Drawing.Size(132, 33);
            this.buttonCLearContent.TabIndex = 13;
            this.buttonCLearContent.Text = "Wyczyść dane";
            this.buttonCLearContent.UseVisualStyleBackColor = true;
            this.buttonCLearContent.Click += new System.EventHandler(this.buttonCLearContent_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(453, 102);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(132, 34);
            this.buttonReturn.TabIndex = 14;
            this.buttonReturn.Text = "Powrót";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(49, 225);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(127, 20);
            this.textBoxUser.TabIndex = 15;
            // 
            // textBoxAssignmentGroup
            // 
            this.textBoxAssignmentGroup.Location = new System.Drawing.Point(246, 225);
            this.textBoxAssignmentGroup.Name = "textBoxAssignmentGroup";
            this.textBoxAssignmentGroup.Size = new System.Drawing.Size(127, 20);
            this.textBoxAssignmentGroup.TabIndex = 16;
            // 
            // textBoxService
            // 
            this.textBoxService.Location = new System.Drawing.Point(453, 225);
            this.textBoxService.Name = "textBoxService";
            this.textBoxService.Size = new System.Drawing.Size(127, 20);
            this.textBoxService.TabIndex = 17;
            // 
            // textBoxPriority
            // 
            this.textBoxPriority.Location = new System.Drawing.Point(49, 305);
            this.textBoxPriority.Name = "textBoxPriority";
            this.textBoxPriority.Size = new System.Drawing.Size(127, 20);
            this.textBoxPriority.TabIndex = 18;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(246, 305);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(127, 87);
            this.textBoxDescription.TabIndex = 19;
            // 
            // textBoxSolution
            // 
            this.textBoxSolution.Location = new System.Drawing.Point(453, 305);
            this.textBoxSolution.Multiline = true;
            this.textBoxSolution.Name = "textBoxSolution";
            this.textBoxSolution.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSolution.Size = new System.Drawing.Size(127, 87);
            this.textBoxSolution.TabIndex = 20;
            // 
            // textBoxReportedDate
            // 
            this.textBoxReportedDate.Location = new System.Drawing.Point(49, 372);
            this.textBoxReportedDate.Name = "textBoxReportedDate";
            this.textBoxReportedDate.Size = new System.Drawing.Size(127, 20);
            this.textBoxReportedDate.TabIndex = 21;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxReportedDate);
            this.Controls.Add(this.textBoxSolution);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxPriority);
            this.Controls.Add(this.textBoxService);
            this.Controls.Add(this.textBoxAssignmentGroup);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonCLearContent);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTIcketID);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Zgłoszenia";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTIcketID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonCLearContent;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxAssignmentGroup;
        private System.Windows.Forms.TextBox textBoxService;
        private System.Windows.Forms.TextBox textBoxPriority;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxSolution;
        private System.Windows.Forms.TextBox textBoxReportedDate;
    }
}
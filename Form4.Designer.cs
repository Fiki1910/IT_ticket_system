namespace Aplikacja1
{
    partial class Form4
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxGroupName = new System.Windows.Forms.TextBox();
            this.textBoxManager = new System.Windows.Forms.TextBox();
            this.textBoxSecondManager = new System.Windows.Forms.TextBox();
            this.textBoxAmountOfEmployees = new System.Windows.Forms.TextBox();
            this.comboBoxNameOfGroup = new System.Windows.Forms.ComboBox();
            this.comboBoxManager = new System.Windows.Forms.ComboBox();
            this.buttonCLearContent = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wybierz grupę";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wybierz managera";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nazwa grupy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pierwszy manager";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Drugi manager";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(590, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ilość pracowników";
            // 
            // textBoxGroupName
            // 
            this.textBoxGroupName.Location = new System.Drawing.Point(46, 217);
            this.textBoxGroupName.Name = "textBoxGroupName";
            this.textBoxGroupName.Size = new System.Drawing.Size(131, 20);
            this.textBoxGroupName.TabIndex = 6;
            // 
            // textBoxManager
            // 
            this.textBoxManager.Location = new System.Drawing.Point(219, 217);
            this.textBoxManager.Name = "textBoxManager";
            this.textBoxManager.Size = new System.Drawing.Size(131, 20);
            this.textBoxManager.TabIndex = 7;
            // 
            // textBoxSecondManager
            // 
            this.textBoxSecondManager.Location = new System.Drawing.Point(408, 217);
            this.textBoxSecondManager.Name = "textBoxSecondManager";
            this.textBoxSecondManager.Size = new System.Drawing.Size(131, 20);
            this.textBoxSecondManager.TabIndex = 8;
            // 
            // textBoxAmountOfEmployees
            // 
            this.textBoxAmountOfEmployees.Location = new System.Drawing.Point(593, 217);
            this.textBoxAmountOfEmployees.Name = "textBoxAmountOfEmployees";
            this.textBoxAmountOfEmployees.Size = new System.Drawing.Size(131, 20);
            this.textBoxAmountOfEmployees.TabIndex = 9;
            // 
            // comboBoxNameOfGroup
            // 
            this.comboBoxNameOfGroup.FormattingEnabled = true;
            this.comboBoxNameOfGroup.Location = new System.Drawing.Point(119, 103);
            this.comboBoxNameOfGroup.Name = "comboBoxNameOfGroup";
            this.comboBoxNameOfGroup.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNameOfGroup.TabIndex = 10;
            this.comboBoxNameOfGroup.SelectedIndexChanged += new System.EventHandler(this.comboBoxNameOfGroup_SelectedIndexChanged);
            // 
            // comboBoxManager
            // 
            this.comboBoxManager.FormattingEnabled = true;
            this.comboBoxManager.Location = new System.Drawing.Point(389, 103);
            this.comboBoxManager.Name = "comboBoxManager";
            this.comboBoxManager.Size = new System.Drawing.Size(121, 21);
            this.comboBoxManager.TabIndex = 11;
            this.comboBoxManager.SelectedIndexChanged += new System.EventHandler(this.comboBoxManager_SelectedIndexChanged);
            // 
            // buttonCLearContent
            // 
            this.buttonCLearContent.Location = new System.Drawing.Point(592, 296);
            this.buttonCLearContent.Name = "buttonCLearContent";
            this.buttonCLearContent.Size = new System.Drawing.Size(132, 33);
            this.buttonCLearContent.TabIndex = 12;
            this.buttonCLearContent.Text = "Wyczyść dane";
            this.buttonCLearContent.UseVisualStyleBackColor = true;
            this.buttonCLearContent.Click += new System.EventHandler(this.buttonCLearContent_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(593, 352);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(132, 34);
            this.buttonReturn.TabIndex = 15;
            this.buttonReturn.Text = "Powrót";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonCLearContent);
            this.Controls.Add(this.comboBoxManager);
            this.Controls.Add(this.comboBoxNameOfGroup);
            this.Controls.Add(this.textBoxAmountOfEmployees);
            this.Controls.Add(this.textBoxSecondManager);
            this.Controls.Add(this.textBoxManager);
            this.Controls.Add(this.textBoxGroupName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Grupy wsparcia";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxGroupName;
        private System.Windows.Forms.TextBox textBoxManager;
        private System.Windows.Forms.TextBox textBoxSecondManager;
        private System.Windows.Forms.TextBox textBoxAmountOfEmployees;
        private System.Windows.Forms.ComboBox comboBoxNameOfGroup;
        private System.Windows.Forms.ComboBox comboBoxManager;
        private System.Windows.Forms.Button buttonCLearContent;
        private System.Windows.Forms.Button buttonReturn;
    }
}
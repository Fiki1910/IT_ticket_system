namespace Aplikacja1
{
    partial class Form2
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
            this.chooseLabel = new System.Windows.Forms.Label();
            this.showUsers = new System.Windows.Forms.Button();
            this.showSupportGroups = new System.Windows.Forms.Button();
            this.showService = new System.Windows.Forms.Button();
            this.showTickets = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonAdm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chooseLabel
            // 
            this.chooseLabel.AutoSize = true;
            this.chooseLabel.Location = new System.Drawing.Point(319, 74);
            this.chooseLabel.Name = "chooseLabel";
            this.chooseLabel.Size = new System.Drawing.Size(164, 16);
            this.chooseLabel.TabIndex = 0;
            this.chooseLabel.Text = "Wybierz, co chcesz zrobić:";
            // 
            // showUsers
            // 
            this.showUsers.Location = new System.Drawing.Point(65, 135);
            this.showUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showUsers.Name = "showUsers";
            this.showUsers.Size = new System.Drawing.Size(161, 46);
            this.showUsers.TabIndex = 1;
            this.showUsers.Text = "Wyświetl użytkowników";
            this.showUsers.UseVisualStyleBackColor = true;
            this.showUsers.Click += new System.EventHandler(this.showUsers_Click);
            // 
            // showSupportGroups
            // 
            this.showSupportGroups.Location = new System.Drawing.Point(65, 209);
            this.showSupportGroups.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showSupportGroups.Name = "showSupportGroups";
            this.showSupportGroups.Size = new System.Drawing.Size(161, 44);
            this.showSupportGroups.TabIndex = 2;
            this.showSupportGroups.Text = "Wyświetl grupy wsparcia";
            this.showSupportGroups.UseVisualStyleBackColor = true;
            this.showSupportGroups.Click += new System.EventHandler(this.showSupportGroups_Click);
            // 
            // showService
            // 
            this.showService.Location = new System.Drawing.Point(565, 135);
            this.showService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showService.Name = "showService";
            this.showService.Size = new System.Drawing.Size(161, 44);
            this.showService.TabIndex = 3;
            this.showService.Text = "Wyświetl serwis";
            this.showService.UseVisualStyleBackColor = true;
            this.showService.Click += new System.EventHandler(this.showService_Click);
            // 
            // showTickets
            // 
            this.showTickets.Location = new System.Drawing.Point(565, 209);
            this.showTickets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showTickets.Name = "showTickets";
            this.showTickets.Size = new System.Drawing.Size(161, 44);
            this.showTickets.TabIndex = 5;
            this.showTickets.Text = "Wyświetl zgłoszenia";
            this.showTickets.UseVisualStyleBackColor = true;
            this.showTickets.Click += new System.EventHandler(this.showTickets_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(565, 366);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(161, 44);
            this.buttonLogOut.TabIndex = 9;
            this.buttonLogOut.Text = "Wyloguj się";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonAdm
            // 
            this.buttonAdm.Location = new System.Drawing.Point(322, 135);
            this.buttonAdm.Name = "buttonAdm";
            this.buttonAdm.Size = new System.Drawing.Size(161, 44);
            this.buttonAdm.TabIndex = 10;
            this.buttonAdm.Text = "Panel administratora";
            this.buttonAdm.UseVisualStyleBackColor = true;
            this.buttonAdm.Click += new System.EventHandler(this.buttonAdm_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAdm);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.showTickets);
            this.Controls.Add(this.showService);
            this.Controls.Add(this.showSupportGroups);
            this.Controls.Add(this.showUsers);
            this.Controls.Add(this.chooseLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Menu główne";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chooseLabel;
        private System.Windows.Forms.Button showUsers;
        private System.Windows.Forms.Button showSupportGroups;
        private System.Windows.Forms.Button showService;
        private System.Windows.Forms.Button showTickets;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonAdm;
    }
}
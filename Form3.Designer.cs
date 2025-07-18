namespace Aplikacja1
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.systemZgloszenITCDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._System_Zgloszen_IT_C_DataSet = new Aplikacja1._System_Zgloszen_IT_C_DataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.textBoxAdres = new System.Windows.Forms.TextBox();
            this.textBoxNumer_Komputera = new System.Windows.Forms.TextBox();
            this.textBoxNumer_Telefonu = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.ChooseName = new System.Windows.Forms.Label();
            this.chooseLastName = new System.Windows.Forms.Label();
            this.chooseComputer = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.buttonCLearContent = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemZgloszenITCDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._System_Zgloszen_IT_C_DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(532, 323);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(6, 6);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.DataSource = this.systemZgloszenITCDataSetBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(554, 311);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(13, 19);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.Visible = false;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // systemZgloszenITCDataSetBindingSource
            // 
            this.systemZgloszenITCDataSetBindingSource.DataSource = this._System_Zgloszen_IT_C_DataSet;
            this.systemZgloszenITCDataSetBindingSource.Position = 0;
            // 
            // _System_Zgloszen_IT_C_DataSet
            // 
            this._System_Zgloszen_IT_C_DataSet.DataSetName = "_System_Zgloszen_IT_C_DataSet";
            this._System_Zgloszen_IT_C_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(62, 54);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Location = new System.Drawing.Point(47, 217);
            this.textBoxNazwisko.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(100, 20);
            this.textBoxNazwisko.TabIndex = 3;
            // 
            // textBoxAdres
            // 
            this.textBoxAdres.Location = new System.Drawing.Point(47, 286);
            this.textBoxAdres.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAdres.Name = "textBoxAdres";
            this.textBoxAdres.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdres.TabIndex = 4;
            // 
            // textBoxNumer_Komputera
            // 
            this.textBoxNumer_Komputera.Location = new System.Drawing.Point(295, 286);
            this.textBoxNumer_Komputera.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNumer_Komputera.Name = "textBoxNumer_Komputera";
            this.textBoxNumer_Komputera.Size = new System.Drawing.Size(99, 20);
            this.textBoxNumer_Komputera.TabIndex = 5;
            // 
            // textBoxNumer_Telefonu
            // 
            this.textBoxNumer_Telefonu.Location = new System.Drawing.Point(295, 217);
            this.textBoxNumer_Telefonu.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNumer_Telefonu.Name = "textBoxNumer_Telefonu";
            this.textBoxNumer_Telefonu.Size = new System.Drawing.Size(99, 20);
            this.textBoxNumer_Telefonu.TabIndex = 6;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(295, 147);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(99, 20);
            this.textBoxEmail.TabIndex = 7;
            // 
            // ChooseName
            // 
            this.ChooseName.AutoSize = true;
            this.ChooseName.Location = new System.Drawing.Point(60, 23);
            this.ChooseName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ChooseName.Name = "ChooseName";
            this.ChooseName.Size = new System.Drawing.Size(66, 13);
            this.ChooseName.TabIndex = 8;
            this.ChooseName.Text = "Wybierz imię";
            // 
            // chooseLastName
            // 
            this.chooseLastName.AutoSize = true;
            this.chooseLastName.Location = new System.Drawing.Point(211, 23);
            this.chooseLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.chooseLastName.Name = "chooseLastName";
            this.chooseLastName.Size = new System.Drawing.Size(92, 13);
            this.chooseLastName.TabIndex = 9;
            this.chooseLastName.Text = "Wybierz nazwisko";
            // 
            // chooseComputer
            // 
            this.chooseComputer.AutoSize = true;
            this.chooseComputer.Location = new System.Drawing.Point(368, 23);
            this.chooseComputer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.chooseComputer.Name = "chooseComputer";
            this.chooseComputer.Size = new System.Drawing.Size(132, 13);
            this.chooseComputer.TabIndex = 10;
            this.chooseComputer.Text = "Wybierz nazwę komputera";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(213, 54);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(92, 21);
            this.comboBox2.TabIndex = 11;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(370, 54);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(92, 21);
            this.comboBox3.TabIndex = 12;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // buttonCLearContent
            // 
            this.buttonCLearContent.Location = new System.Drawing.Point(473, 353);
            this.buttonCLearContent.Name = "buttonCLearContent";
            this.buttonCLearContent.Size = new System.Drawing.Size(132, 33);
            this.buttonCLearContent.TabIndex = 13;
            this.buttonCLearContent.Text = "Wyczyść dane";
            this.buttonCLearContent.UseVisualStyleBackColor = true;
            this.buttonCLearContent.Click += new System.EventHandler(this.buttonCLearContent_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(295, 353);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(132, 34);
            this.buttonReturn.TabIndex = 15;
            this.buttonReturn.Text = "Powrót";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nazwisko";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Adres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Numer komputera";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Numer telefonu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Adres Email";
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(47, 146);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(100, 20);
            this.textBoxImie.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Imie";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(473, 140);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(132, 37);
            this.buttonUpdate.TabIndex = 24;
            this.buttonUpdate.Text = "Zaktualizuj dane";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(473, 202);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(132, 35);
            this.buttonInsert.TabIndex = 25;
            this.buttonInsert.Text = "Dodaj użytkownika";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 437);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxImie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonCLearContent);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.chooseComputer);
            this.Controls.Add(this.chooseLastName);
            this.Controls.Add(this.ChooseName);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxNumer_Telefonu);
            this.Controls.Add(this.textBoxNumer_Komputera);
            this.Controls.Add(this.textBoxAdres);
            this.Controls.Add(this.textBoxNazwisko);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.Text = "Użytkownicy";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemZgloszenITCDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._System_Zgloszen_IT_C_DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource systemZgloszenITCDataSetBindingSource;
        private _System_Zgloszen_IT_C_DataSet _System_Zgloszen_IT_C_DataSet;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.TextBox textBoxAdres;
        private System.Windows.Forms.TextBox textBoxNumer_Komputera;
        private System.Windows.Forms.TextBox textBoxNumer_Telefonu;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label ChooseName;
        private System.Windows.Forms.Label chooseLastName;
        private System.Windows.Forms.Label chooseComputer;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button buttonCLearContent;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonInsert;
    }
}
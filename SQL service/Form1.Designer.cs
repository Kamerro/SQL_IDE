namespace SQL_service
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridDB = new System.Windows.Forms.DataGridView();
            this.btnOdswiez = new System.Windows.Forms.Button();
            this.btn_addCol = new System.Windows.Forms.Button();
            this.btn_delCol = new System.Windows.Forms.Button();
            this.tbNameCol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbSer = new System.Windows.Forms.ComboBox();
            this.Z_S = new System.Windows.Forms.Button();
            this.Z_B = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbBaz = new System.Windows.Forms.ComboBox();
            this.Z_T = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbTab = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDB)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridDB
            // 
            this.dataGridDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDB.Location = new System.Drawing.Point(13, 29);
            this.dataGridDB.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridDB.Name = "dataGridDB";
            this.dataGridDB.RowHeadersWidth = 51;
            this.dataGridDB.Size = new System.Drawing.Size(424, 327);
            this.dataGridDB.TabIndex = 1;
            // 
            // btnOdswiez
            // 
            this.btnOdswiez.Location = new System.Drawing.Point(498, 407);
            this.btnOdswiez.Margin = new System.Windows.Forms.Padding(4);
            this.btnOdswiez.Name = "btnOdswiez";
            this.btnOdswiez.Size = new System.Drawing.Size(156, 28);
            this.btnOdswiez.TabIndex = 2;
            this.btnOdswiez.Text = "Wyświetl dane z tabeli";
            this.btnOdswiez.UseVisualStyleBackColor = true;
            this.btnOdswiez.Click += new System.EventHandler(this.btnOdswiez_Click);
            // 
            // btn_addCol
            // 
            this.btn_addCol.Location = new System.Drawing.Point(75, 465);
            this.btn_addCol.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addCol.Name = "btn_addCol";
            this.btn_addCol.Size = new System.Drawing.Size(89, 46);
            this.btn_addCol.TabIndex = 3;
            this.btn_addCol.Text = "Dodaj kolumnę";
            this.btn_addCol.UseVisualStyleBackColor = true;
            this.btn_addCol.Click += new System.EventHandler(this.btn_addCol_Click);
            // 
            // btn_delCol
            // 
            this.btn_delCol.Location = new System.Drawing.Point(240, 465);
            this.btn_delCol.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delCol.Name = "btn_delCol";
            this.btn_delCol.Size = new System.Drawing.Size(85, 46);
            this.btn_delCol.TabIndex = 4;
            this.btn_delCol.Text = "Usuń kolumnę";
            this.btn_delCol.UseVisualStyleBackColor = true;
            this.btn_delCol.Click += new System.EventHandler(this.btn_delCol_Click);
            // 
            // tbNameCol
            // 
            this.tbNameCol.Location = new System.Drawing.Point(134, 435);
            this.tbNameCol.Margin = new System.Windows.Forms.Padding(4);
            this.tbNameCol.Name = "tbNameCol";
            this.tbNameCol.Size = new System.Drawing.Size(156, 22);
            this.tbNameCol.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 410);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nazwa kolumny";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1202, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Search for severs";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_Ser);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Location = new System.Drawing.Point(1132, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 69);
            this.panel2.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(279, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1202, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 55);
            this.button2.TabIndex = 9;
            this.button2.Text = "Search databases from selected server";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_Baz);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Location = new System.Drawing.Point(1132, 255);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(301, 67);
            this.panel3.TabIndex = 9;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(3, 18);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(279, 24);
            this.comboBox2.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(100, 100);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(183, 53);
            this.button3.TabIndex = 10;
            this.button3.Text = "search for tables from selected database";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn_Tab);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(3, 17);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(276, 24);
            this.comboBox3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.comboBox3);
            this.panel4.Location = new System.Drawing.Point(1135, 422);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(298, 72);
            this.panel4.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbSer);
            this.panel1.Location = new System.Drawing.Point(492, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 57);
            this.panel1.TabIndex = 7;
            // 
            // cbSer
            // 
            this.cbSer.FormattingEnabled = true;
            this.cbSer.Location = new System.Drawing.Point(3, 3);
            this.cbSer.Name = "cbSer";
            this.cbSer.Size = new System.Drawing.Size(194, 24);
            this.cbSer.TabIndex = 0;
            // 
            // Z_S
            // 
            this.Z_S.Location = new System.Drawing.Point(492, 77);
            this.Z_S.Name = "Z_S";
            this.Z_S.Size = new System.Drawing.Size(200, 23);
            this.Z_S.TabIndex = 1;
            this.Z_S.Text = "Znajdz serwery ";
            this.Z_S.UseVisualStyleBackColor = true;
            this.Z_S.Click += new System.EventHandler(this.btn_Ser);
            // 
            // Z_B
            // 
            this.Z_B.Location = new System.Drawing.Point(495, 188);
            this.Z_B.Name = "Z_B";
            this.Z_B.Size = new System.Drawing.Size(200, 23);
            this.Z_B.TabIndex = 8;
            this.Z_B.Text = "Znajdz bazę danych";
            this.Z_B.UseVisualStyleBackColor = true;
            this.Z_B.Click += new System.EventHandler(this.btn_Baz);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cbBaz);
            this.panel5.Location = new System.Drawing.Point(495, 217);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 57);
            this.panel5.TabIndex = 9;
            // 
            // cbBaz
            // 
            this.cbBaz.FormattingEnabled = true;
            this.cbBaz.Location = new System.Drawing.Point(3, 3);
            this.cbBaz.Name = "cbBaz";
            this.cbBaz.Size = new System.Drawing.Size(194, 24);
            this.cbBaz.TabIndex = 0;
            // 
            // Z_T
            // 
            this.Z_T.Location = new System.Drawing.Point(495, 300);
            this.Z_T.Name = "Z_T";
            this.Z_T.Size = new System.Drawing.Size(200, 23);
            this.Z_T.TabIndex = 10;
            this.Z_T.Text = "Znajdz tabele";
            this.Z_T.UseVisualStyleBackColor = true;
            this.Z_T.Click += new System.EventHandler(this.btn_Tab);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cbTab);
            this.panel6.Location = new System.Drawing.Point(495, 329);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 57);
            this.panel6.TabIndex = 11;
            // 
            // cbTab
            // 
            this.cbTab.FormattingEnabled = true;
            this.cbTab.Location = new System.Drawing.Point(3, 3);
            this.cbTab.Name = "cbTab";
            this.cbTab.Size = new System.Drawing.Size(194, 24);
            this.cbTab.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(745, 554);
            this.Controls.Add(this.Z_T);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.Z_B);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.Z_S);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNameCol);
            this.Controls.Add(this.btn_delCol);
            this.Controls.Add(this.btn_addCol);
            this.Controls.Add(this.btnOdswiez);
            this.Controls.Add(this.dataGridDB);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDB)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridDB;
        private System.Windows.Forms.Button btnOdswiez;
        private System.Windows.Forms.Button btn_addCol;
        private System.Windows.Forms.Button btn_delCol;
        private System.Windows.Forms.TextBox tbNameCol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbSer;
        private System.Windows.Forms.Button Z_S;
        private System.Windows.Forms.Button Z_B;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cbBaz;
        private System.Windows.Forms.Button Z_T;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cbTab;
    }
}


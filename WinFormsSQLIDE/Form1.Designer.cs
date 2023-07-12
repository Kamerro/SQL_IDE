namespace WinFormsSQLIDE
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
            this.Z_T = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbTable = new System.Windows.Forms.ComboBox();
            this.Z_B = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbBase = new System.Windows.Forms.ComboBox();
            this.Z_S = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbServer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableColumnName = new System.Windows.Forms.TextBox();
            this.btn_delCol = new System.Windows.Forms.Button();
            this.btn_addCol = new System.Windows.Forms.Button();
            this.btnOdswiez = new System.Windows.Forms.Button();
            this.dataGridDB = new System.Windows.Forms.DataGridView();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDB)).BeginInit();
            this.SuspendLayout();
            // 
            // Z_T
            // 
            this.Z_T.Location = new System.Drawing.Point(525, 231);
            this.Z_T.Name = "Z_T";
            this.Z_T.Size = new System.Drawing.Size(200, 23);
            this.Z_T.TabIndex = 22;
            this.Z_T.Text = "Znajdź tabele";
            this.Z_T.UseVisualStyleBackColor = true;
            this.Z_T.Click += new System.EventHandler(this.btnSzukajTabel_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cbTable);
            this.panel6.Location = new System.Drawing.Point(525, 260);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 57);
            this.panel6.TabIndex = 23;
            // 
            // cbTable
            // 
            this.cbTable.FormattingEnabled = true;
            this.cbTable.Location = new System.Drawing.Point(3, 3);
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(194, 24);
            this.cbTable.TabIndex = 0;
            // 
            // Z_B
            // 
            this.Z_B.Location = new System.Drawing.Point(525, 119);
            this.Z_B.Name = "Z_B";
            this.Z_B.Size = new System.Drawing.Size(200, 23);
            this.Z_B.TabIndex = 20;
            this.Z_B.Text = "Znajdź bazę danych";
            this.Z_B.UseVisualStyleBackColor = true;
            this.Z_B.Click += new System.EventHandler(this.BtnBazyDanych_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cbBase);
            this.panel5.Location = new System.Drawing.Point(525, 148);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 57);
            this.panel5.TabIndex = 21;
            // 
            // cbBase
            // 
            this.cbBase.FormattingEnabled = true;
            this.cbBase.Location = new System.Drawing.Point(3, 3);
            this.cbBase.Name = "cbBase";
            this.cbBase.Size = new System.Drawing.Size(194, 24);
            this.cbBase.TabIndex = 0;
            // 
            // Z_S
            // 
            this.Z_S.Location = new System.Drawing.Point(522, 8);
            this.Z_S.Name = "Z_S";
            this.Z_S.Size = new System.Drawing.Size(200, 23);
            this.Z_S.TabIndex = 12;
            this.Z_S.Text = "Znajdź serwery ";
            this.Z_S.UseVisualStyleBackColor = true;
            this.Z_S.Click += new System.EventHandler(this.btnSzukaj_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbServer);
            this.panel1.Location = new System.Drawing.Point(522, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 57);
            this.panel1.TabIndex = 19;
            // 
            // cbServer
            // 
            this.cbServer.FormattingEnabled = true;
            this.cbServer.Location = new System.Drawing.Point(3, 3);
            this.cbServer.Name = "cbServer";
            this.cbServer.Size = new System.Drawing.Size(194, 24);
            this.cbServer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 341);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nazwa kolumny";
            // 
            // tableColumnName
            // 
            this.tableColumnName.Location = new System.Drawing.Point(164, 366);
            this.tableColumnName.Margin = new System.Windows.Forms.Padding(4);
            this.tableColumnName.Name = "tableColumnName";
            this.tableColumnName.Size = new System.Drawing.Size(156, 22);
            this.tableColumnName.TabIndex = 17;
            // 
            // btn_delCol
            // 
            this.btn_delCol.Location = new System.Drawing.Point(270, 396);
            this.btn_delCol.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delCol.Name = "btn_delCol";
            this.btn_delCol.Size = new System.Drawing.Size(85, 46);
            this.btn_delCol.TabIndex = 16;
            this.btn_delCol.Text = "Usuń kolumnę";
            this.btn_delCol.UseVisualStyleBackColor = true;
            this.btn_delCol.Click += new System.EventHandler(this.btn_delCol_Click);
            // 
            // btn_addCol
            // 
            this.btn_addCol.Location = new System.Drawing.Point(105, 396);
            this.btn_addCol.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addCol.Name = "btn_addCol";
            this.btn_addCol.Size = new System.Drawing.Size(89, 46);
            this.btn_addCol.TabIndex = 15;
            this.btn_addCol.Text = "Dodaj kolumnę";
            this.btn_addCol.UseVisualStyleBackColor = true;
            this.btn_addCol.Click += new System.EventHandler(this.btn_addCol_Click);
            // 
            // btnOdswiez
            // 
            this.btnOdswiez.Location = new System.Drawing.Point(528, 338);
            this.btnOdswiez.Margin = new System.Windows.Forms.Padding(4);
            this.btnOdswiez.Name = "btnOdswiez";
            this.btnOdswiez.Size = new System.Drawing.Size(156, 28);
            this.btnOdswiez.TabIndex = 14;
            this.btnOdswiez.Text = "Wyświetl dane z tabeli";
            this.btnOdswiez.UseVisualStyleBackColor = true;
            this.btnOdswiez.Click += new System.EventHandler(this.btnOdswiez_Click);
            // 
            // dataGridDB
            // 
            this.dataGridDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDB.Location = new System.Drawing.Point(13, 8);
            this.dataGridDB.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridDB.Name = "dataGridDB";
            this.dataGridDB.RowHeadersWidth = 51;
            this.dataGridDB.Size = new System.Drawing.Size(424, 327);
            this.dataGridDB.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Z_T);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.Z_B);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.Z_S);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableColumnName);
            this.Controls.Add(this.btn_delCol);
            this.Controls.Add(this.btn_addCol);
            this.Controls.Add(this.btnOdswiez);
            this.Controls.Add(this.dataGridDB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Z_T;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cbTable;
        private System.Windows.Forms.Button Z_B;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cbBase;
        private System.Windows.Forms.Button Z_S;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tableColumnName;
        private System.Windows.Forms.Button btn_delCol;
        private System.Windows.Forms.Button btn_addCol;
        private System.Windows.Forms.Button btnOdswiez;
        private System.Windows.Forms.DataGridView dataGridDB;
    }
}


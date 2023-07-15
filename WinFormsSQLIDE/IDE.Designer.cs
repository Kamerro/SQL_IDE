namespace WinFormsSQLIDE
{
    partial class IDE
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableColumnName = new System.Windows.Forms.TextBox();
            this.btn_delCol = new System.Windows.Forms.Button();
            this.btn_addCol = new System.Windows.Forms.Button();
            this.btnOdswiez = new System.Windows.Forms.Button();
            this.dataGridDB = new System.Windows.Forms.DataGridView();
            this.btnConfig = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(878, 318);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nazwa kolumny";
            // 
            // tableColumnName
            // 
            this.tableColumnName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tableColumnName.Location = new System.Drawing.Point(881, 342);
            this.tableColumnName.Margin = new System.Windows.Forms.Padding(4);
            this.tableColumnName.Name = "tableColumnName";
            this.tableColumnName.Size = new System.Drawing.Size(182, 24);
            this.tableColumnName.TabIndex = 17;
            // 
            // btn_delCol
            // 
            this.btn_delCol.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_delCol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_delCol.Location = new System.Drawing.Point(978, 378);
            this.btn_delCol.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delCol.Name = "btn_delCol";
            this.btn_delCol.Size = new System.Drawing.Size(85, 46);
            this.btn_delCol.TabIndex = 16;
            this.btn_delCol.Text = "Usuń kolumnę";
            this.btn_delCol.UseVisualStyleBackColor = false;
            this.btn_delCol.Click += new System.EventHandler(this.btn_delCol_Click);
            // 
            // btn_addCol
            // 
            this.btn_addCol.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_addCol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_addCol.Location = new System.Drawing.Point(881, 378);
            this.btn_addCol.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addCol.Name = "btn_addCol";
            this.btn_addCol.Size = new System.Drawing.Size(89, 46);
            this.btn_addCol.TabIndex = 15;
            this.btn_addCol.Text = "Dodaj kolumnę";
            this.btn_addCol.UseVisualStyleBackColor = false;
            this.btn_addCol.Click += new System.EventHandler(this.btn_addCol_Click);
            // 
            // btnOdswiez
            // 
            this.btnOdswiez.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnOdswiez.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdswiez.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOdswiez.Location = new System.Drawing.Point(878, 93);
            this.btnOdswiez.Margin = new System.Windows.Forms.Padding(4);
            this.btnOdswiez.Name = "btnOdswiez";
            this.btnOdswiez.Size = new System.Drawing.Size(201, 130);
            this.btnOdswiez.TabIndex = 14;
            this.btnOdswiez.Text = "Wyświetl dane z tabeli";
            this.btnOdswiez.UseVisualStyleBackColor = false;
            this.btnOdswiez.Click += new System.EventHandler(this.btnOdswiez_Click);
            // 
            // dataGridDB
            // 
            this.dataGridDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDB.Location = new System.Drawing.Point(13, 16);
            this.dataGridDB.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridDB.Name = "dataGridDB";
            this.dataGridDB.RowHeadersWidth = 51;
            this.dataGridDB.Size = new System.Drawing.Size(857, 421);
            this.dataGridDB.TabIndex = 13;
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnConfig.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConfig.Location = new System.Drawing.Point(878, 16);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(202, 70);
            this.btnConfig.TabIndex = 19;
            this.btnConfig.Text = "Otwórz konfigurator";
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // IDE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1092, 450);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableColumnName);
            this.Controls.Add(this.btn_delCol);
            this.Controls.Add(this.btn_addCol);
            this.Controls.Add(this.btnOdswiez);
            this.Controls.Add(this.dataGridDB);
            this.Name = "IDE";
            this.Text = "IDE";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tableColumnName;
        private System.Windows.Forms.Button btn_delCol;
        private System.Windows.Forms.Button btn_addCol;
        private System.Windows.Forms.Button btnOdswiez;
        private System.Windows.Forms.DataGridView dataGridDB;
        private System.Windows.Forms.Button btnConfig;
    }
}


namespace DatabaseClient
{
    partial class DbCountriesForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridViewCountries = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountryCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capital = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Population = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Region1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountries)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(154, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 1;
            // 
            // dataGridViewCountries
            // 
            this.dataGridViewCountries.AllowUserToAddRows = false;
            this.dataGridViewCountries.AllowUserToDeleteRows = false;
            this.dataGridViewCountries.AllowUserToOrderColumns = true;
            this.dataGridViewCountries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCountries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCountries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCountries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name1,
            this.CountryCode,
            this.Capital,
            this.Area,
            this.Population,
            this.Region1});
            this.dataGridViewCountries.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewCountries.Name = "dataGridViewCountries";
            this.dataGridViewCountries.ReadOnly = true;
            this.dataGridViewCountries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCountries.Size = new System.Drawing.Size(828, 494);
            this.dataGridViewCountries.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Location = new System.Drawing.Point(4, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(843, 511);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.DataPropertyName = "Capital";
            this.dataGridViewComboBoxColumn1.HeaderText = "Capital";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.ReadOnly = true;
            this.dataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn1.Width = 121;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Region";
            this.dataGridViewTextBoxColumn1.HeaderText = "Region";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 121;
            // 
            // dataGridViewComboBoxColumn2
            // 
            this.dataGridViewComboBoxColumn2.DataPropertyName = "Capital";
            this.dataGridViewComboBoxColumn2.HeaderText = "Capital";
            this.dataGridViewComboBoxColumn2.Name = "dataGridViewComboBoxColumn2";
            this.dataGridViewComboBoxColumn2.ReadOnly = true;
            this.dataGridViewComboBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn2.Width = 121;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Region";
            this.dataGridViewTextBoxColumn2.HeaderText = "Region";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 121;
            // 
            // dataGridViewComboBoxColumn3
            // 
            this.dataGridViewComboBoxColumn3.DataPropertyName = "Capital";
            this.dataGridViewComboBoxColumn3.HeaderText = "Capital";
            this.dataGridViewComboBoxColumn3.Name = "dataGridViewComboBoxColumn3";
            this.dataGridViewComboBoxColumn3.ReadOnly = true;
            this.dataGridViewComboBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn3.Width = 121;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Region";
            this.dataGridViewTextBoxColumn3.HeaderText = "Region";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 121;
            // 
            // dataGridViewComboBoxColumn4
            // 
            this.dataGridViewComboBoxColumn4.DataPropertyName = "Capital";
            this.dataGridViewComboBoxColumn4.HeaderText = "Capital";
            this.dataGridViewComboBoxColumn4.Name = "dataGridViewComboBoxColumn4";
            this.dataGridViewComboBoxColumn4.ReadOnly = true;
            this.dataGridViewComboBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn4.Width = 121;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Region";
            this.dataGridViewTextBoxColumn4.HeaderText = "Region";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 121;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Region";
            this.dataGridViewTextBoxColumn6.HeaderText = "Region";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 104;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Region";
            this.dataGridViewTextBoxColumn7.HeaderText = "Region";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 104;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Region";
            this.dataGridViewTextBoxColumn8.HeaderText = "Region";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 104;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Region";
            this.dataGridViewTextBoxColumn9.HeaderText = "Region";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 104;
            // 
            // dataGridViewComboBoxColumn5
            // 
            this.dataGridViewComboBoxColumn5.DataPropertyName = "Capital";
            this.dataGridViewComboBoxColumn5.HeaderText = "Capital";
            this.dataGridViewComboBoxColumn5.Name = "dataGridViewComboBoxColumn5";
            this.dataGridViewComboBoxColumn5.ReadOnly = true;
            this.dataGridViewComboBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn5.Width = 105;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Region";
            this.dataGridViewTextBoxColumn10.HeaderText = "Region";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 104;
            // 
            // dataGridViewComboBoxColumn6
            // 
            this.dataGridViewComboBoxColumn6.DataPropertyName = "Capital";
            this.dataGridViewComboBoxColumn6.HeaderText = "Capital";
            this.dataGridViewComboBoxColumn6.Name = "dataGridViewComboBoxColumn6";
            this.dataGridViewComboBoxColumn6.ReadOnly = true;
            this.dataGridViewComboBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn6.Width = 105;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Region";
            this.dataGridViewTextBoxColumn11.HeaderText = "Region";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 104;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Name1
            // 
            this.Name1.DataPropertyName = "Name";
            this.Name1.FillWeight = 71.15245F;
            this.Name1.HeaderText = "Name";
            this.Name1.Name = "Name1";
            this.Name1.ReadOnly = true;
            // 
            // CountryCode
            // 
            this.CountryCode.DataPropertyName = "CountryCode";
            this.CountryCode.FillWeight = 40.58612F;
            this.CountryCode.HeaderText = "Country code";
            this.CountryCode.Name = "CountryCode";
            this.CountryCode.ReadOnly = true;
            // 
            // Capital
            // 
            this.Capital.DataPropertyName = "Capital";
            this.Capital.FillWeight = 71.27306F;
            this.Capital.HeaderText = "Capital";
            this.Capital.Name = "Capital";
            this.Capital.ReadOnly = true;
            this.Capital.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Capital.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Area
            // 
            this.Area.DataPropertyName = "Area";
            this.Area.FillWeight = 71.27306F;
            this.Area.HeaderText = "Area";
            this.Area.Name = "Area";
            this.Area.ReadOnly = true;
            // 
            // Population
            // 
            this.Population.DataPropertyName = "Population";
            this.Population.FillWeight = 71.27306F;
            this.Population.HeaderText = "Population";
            this.Population.Name = "Population";
            this.Population.ReadOnly = true;
            // 
            // Region1
            // 
            this.Region1.DataPropertyName = "Region";
            this.Region1.FillWeight = 71.27306F;
            this.Region1.HeaderText = "Region";
            this.Region1.Name = "Region1";
            this.Region1.ReadOnly = true;
            // 
            // DbCountriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 513);
            this.Controls.Add(this.dataGridViewCountries);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox3);
            this.Name = "DbCountriesForm";
            this.Text = "Country data from database Countries";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DbCountriesForm_FormClosed);
            this.Load += new System.EventHandler(this.DbCountriesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridViewCountries;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capital;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn Population;
        private System.Windows.Forms.DataGridViewTextBoxColumn Region1;
    }
}


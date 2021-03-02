namespace DatabaseClient
{
    partial class MainForm
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
            this.buttonSectionGetInf = new System.Windows.Forms.Button();
            this.buttonSectionOpenDCountries = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSectionGetInf
            // 
            this.buttonSectionGetInf.Location = new System.Drawing.Point(32, 77);
            this.buttonSectionGetInf.Name = "buttonSectionGetInf";
            this.buttonSectionGetInf.Size = new System.Drawing.Size(171, 23);
            this.buttonSectionGetInf.TabIndex = 0;
            this.buttonSectionGetInf.Text = "Get information about country";
            this.buttonSectionGetInf.UseVisualStyleBackColor = true;
            this.buttonSectionGetInf.Click += new System.EventHandler(this.buttonSectionGetInf_Click);
            // 
            // buttonSectionOpenDCountries
            // 
            this.buttonSectionOpenDCountries.Location = new System.Drawing.Point(209, 77);
            this.buttonSectionOpenDCountries.Name = "buttonSectionOpenDCountries";
            this.buttonSectionOpenDCountries.Size = new System.Drawing.Size(171, 23);
            this.buttonSectionOpenDCountries.TabIndex = 1;
            this.buttonSectionOpenDCountries.Text = "Open country data";
            this.buttonSectionOpenDCountries.UseVisualStyleBackColor = true;
            this.buttonSectionOpenDCountries.Click += new System.EventHandler(this.buttonSectionOpenDCountries_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose section:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonSectionOpenDCountries);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonSectionGetInf);
            this.groupBox1.Location = new System.Drawing.Point(4, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 130);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(30, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wellcome to the Contry information application!";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 136);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Country information application";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSectionGetInf;
        private System.Windows.Forms.Button buttonSectionOpenDCountries;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
    }
}
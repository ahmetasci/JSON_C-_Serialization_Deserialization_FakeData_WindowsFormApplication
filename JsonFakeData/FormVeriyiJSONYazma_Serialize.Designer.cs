namespace JsonFakeData
{
    partial class FormVeriyiJSONYazma_Serialize
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGetir = new System.Windows.Forms.Button();
            this.btnJsonYaz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 316);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnGetir
            // 
            this.btnGetir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGetir.Location = new System.Drawing.Point(401, 362);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(148, 41);
            this.btnGetir.TabIndex = 3;
            this.btnGetir.Text = "FakeData Getir";
            this.btnGetir.UseVisualStyleBackColor = false;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // btnJsonYaz
            // 
            this.btnJsonYaz.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnJsonYaz.Location = new System.Drawing.Point(134, 362);
            this.btnJsonYaz.Name = "btnJsonYaz";
            this.btnJsonYaz.Size = new System.Drawing.Size(168, 41);
            this.btnJsonYaz.TabIndex = 4;
            this.btnJsonYaz.Text = "FakeData\'yı JSON Olarak Yaz";
            this.btnJsonYaz.UseVisualStyleBackColor = false;
            this.btnJsonYaz.Click += new System.EventHandler(this.btnJsonYaz_Click);
            // 
            // FormVeriyiJSONYazma_Serialize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(735, 431);
            this.Controls.Add(this.btnJsonYaz);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormVeriyiJSONYazma_Serialize";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.Button btnJsonYaz;
    }
}


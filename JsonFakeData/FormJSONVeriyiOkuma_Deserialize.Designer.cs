namespace JsonFakeData
{
    partial class FormJSONVeriyiOkuma_Deserialize
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
            this.dataGridViewDeserialize = new System.Windows.Forms.DataGridView();
            this.btnJSONVeriyiOku = new System.Windows.Forms.Button();
            this.btnGoster = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeserialize)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDeserialize
            // 
            this.dataGridViewDeserialize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeserialize.Location = new System.Drawing.Point(41, 30);
            this.dataGridViewDeserialize.Name = "dataGridViewDeserialize";
            this.dataGridViewDeserialize.Size = new System.Drawing.Size(620, 310);
            this.dataGridViewDeserialize.TabIndex = 0;
            // 
            // btnJSONVeriyiOku
            // 
            this.btnJSONVeriyiOku.Location = new System.Drawing.Point(143, 362);
            this.btnJSONVeriyiOku.Name = "btnJSONVeriyiOku";
            this.btnJSONVeriyiOku.Size = new System.Drawing.Size(164, 38);
            this.btnJSONVeriyiOku.TabIndex = 1;
            this.btnJSONVeriyiOku.Text = "JSON Türündeki Veriyi Oku";
            this.btnJSONVeriyiOku.UseVisualStyleBackColor = true;
            this.btnJSONVeriyiOku.Click += new System.EventHandler(this.btnJSONVeriyiOku_Click);
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(410, 362);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(137, 38);
            this.btnGoster.TabIndex = 2;
            this.btnGoster.Text = "Göster";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // FormJSONVeriyiOkuma_Deserialize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(719, 423);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.btnJSONVeriyiOku);
            this.Controls.Add(this.dataGridViewDeserialize);
            this.Name = "FormJSONVeriyiOkuma_Deserialize";
            this.Text = "FormJSONVeriyiOkuma_Deserialize";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeserialize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDeserialize;
        private System.Windows.Forms.Button btnJSONVeriyiOku;
        private System.Windows.Forms.Button btnGoster;
    }
}
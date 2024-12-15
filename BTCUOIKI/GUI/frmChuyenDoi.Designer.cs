namespace BTCUOIKI.GUI
{
    partial class frmChuyenDoi
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
            this.btn_SqlToXml = new System.Windows.Forms.Button();
            this.btn_XmlToSql = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_SqlToXml
            // 
            this.btn_SqlToXml.Location = new System.Drawing.Point(440, 134);
            this.btn_SqlToXml.Name = "btn_SqlToXml";
            this.btn_SqlToXml.Size = new System.Drawing.Size(147, 67);
            this.btn_SqlToXml.TabIndex = 0;
            this.btn_SqlToXml.Text = "SQL to XML";
            this.btn_SqlToXml.UseVisualStyleBackColor = true;
            this.btn_SqlToXml.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_XmlToSql
            // 
            this.btn_XmlToSql.Location = new System.Drawing.Point(440, 257);
            this.btn_XmlToSql.Name = "btn_XmlToSql";
            this.btn_XmlToSql.Size = new System.Drawing.Size(147, 65);
            this.btn_XmlToSql.TabIndex = 1;
            this.btn_XmlToSql.Text = "XML to SQL";
            this.btn_XmlToSql.UseVisualStyleBackColor = true;
            this.btn_XmlToSql.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmChuyenDoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 577);
            this.Controls.Add(this.btn_XmlToSql);
            this.Controls.Add(this.btn_SqlToXml);
            this.Name = "frmChuyenDoi";
            this.Text = "frmChuyenDoi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_SqlToXml;
        private System.Windows.Forms.Button btn_XmlToSql;
    }
}
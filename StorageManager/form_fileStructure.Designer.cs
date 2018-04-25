namespace StorageManager
{
    partial class form_fileStructure
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
            this.cmb_fieldStructure = new System.Windows.Forms.ComboBox();
            this.cmb_recordStructure = new System.Windows.Forms.ComboBox();
            this.btn_done = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmb_fieldStructure
            // 
            this.cmb_fieldStructure.FormattingEnabled = true;
            this.cmb_fieldStructure.Items.AddRange(new object[] {
            "Fixed length",
            "Length indicator",
            "Delimiter",
            "Keyword"});
            this.cmb_fieldStructure.Location = new System.Drawing.Point(12, 12);
            this.cmb_fieldStructure.Name = "cmb_fieldStructure";
            this.cmb_fieldStructure.Size = new System.Drawing.Size(121, 21);
            this.cmb_fieldStructure.TabIndex = 0;
            this.cmb_fieldStructure.SelectedIndexChanged += new System.EventHandler(this.cmb_fieldStructure_SelectedIndexChanged);
            // 
            // cmb_recordStructure
            // 
            this.cmb_recordStructure.FormattingEnabled = true;
            this.cmb_recordStructure.Items.AddRange(new object[] {
            "Fixed size",
            "Fixed number of records",
            "Delimiter",
            "Length indicator",
            "Index file"});
            this.cmb_recordStructure.Location = new System.Drawing.Point(151, 12);
            this.cmb_recordStructure.Name = "cmb_recordStructure";
            this.cmb_recordStructure.Size = new System.Drawing.Size(121, 21);
            this.cmb_recordStructure.TabIndex = 1;
            // 
            // btn_done
            // 
            this.btn_done.Location = new System.Drawing.Point(197, 226);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(75, 23);
            this.btn_done.TabIndex = 2;
            this.btn_done.Text = "Done";
            this.btn_done.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(172, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(13, 65);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 115);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 6;
            // 
            // form_fileStructure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_done);
            this.Controls.Add(this.cmb_recordStructure);
            this.Controls.Add(this.cmb_fieldStructure);
            this.Name = "form_fileStructure";
            this.Text = "File Structure";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_fieldStructure;
        private System.Windows.Forms.ComboBox cmb_recordStructure;
        private System.Windows.Forms.Button btn_done;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}
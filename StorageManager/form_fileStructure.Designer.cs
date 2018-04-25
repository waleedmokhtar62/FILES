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
            this.txt_numberOfFields = new System.Windows.Forms.TextBox();
            this.dgv_fieldSize = new System.Windows.Forms.DataGridView();
            this.FieldSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fieldSize)).BeginInit();
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
            this.textBox1.Text = "Record Size";
            // 
            // txt_numberOfFields
            // 
            this.txt_numberOfFields.Location = new System.Drawing.Point(172, 65);
            this.txt_numberOfFields.Name = "txt_numberOfFields";
            this.txt_numberOfFields.Size = new System.Drawing.Size(100, 20);
            this.txt_numberOfFields.TabIndex = 4;
            this.txt_numberOfFields.Text = "Number of Fields";
            // 
            // dgv_fieldSize
            // 
            this.dgv_fieldSize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_fieldSize.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FieldSize,
            this.Column1});
            this.dgv_fieldSize.Location = new System.Drawing.Point(12, 65);
            this.dgv_fieldSize.Name = "dgv_fieldSize";
            this.dgv_fieldSize.Size = new System.Drawing.Size(120, 150);
            this.dgv_fieldSize.TabIndex = 7;
            // 
            // FieldSize
            // 
            this.FieldSize.HeaderText = "Field Size";
            this.FieldSize.Name = "FieldSize";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // form_fileStructure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dgv_fieldSize);
            this.Controls.Add(this.txt_numberOfFields);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_done);
            this.Controls.Add(this.cmb_recordStructure);
            this.Controls.Add(this.cmb_fieldStructure);
            this.Name = "form_fileStructure";
            this.Text = "File Structure";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fieldSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_fieldStructure;
        private System.Windows.Forms.ComboBox cmb_recordStructure;
        private System.Windows.Forms.Button btn_done;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt_numberOfFields;
        private System.Windows.Forms.DataGridView dgv_fieldSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn FieldSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}
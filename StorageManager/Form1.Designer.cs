namespace StorageManager
{
    partial class form_start
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
            this.btn_newDrive = new System.Windows.Forms.Button();
            this.btn_oldDrive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_newDrive
            // 
            this.btn_newDrive.Location = new System.Drawing.Point(112, 80);
            this.btn_newDrive.Name = "btn_newDrive";
            this.btn_newDrive.Size = new System.Drawing.Size(75, 23);
            this.btn_newDrive.TabIndex = 0;
            this.btn_newDrive.Text = "New Drive";
            this.btn_newDrive.UseVisualStyleBackColor = true;
            this.btn_newDrive.Click += new System.EventHandler(this.btn_newDrive_Click);
            // 
            // btn_oldDrive
            // 
            this.btn_oldDrive.Location = new System.Drawing.Point(112, 132);
            this.btn_oldDrive.Name = "btn_oldDrive";
            this.btn_oldDrive.Size = new System.Drawing.Size(75, 23);
            this.btn_oldDrive.TabIndex = 1;
            this.btn_oldDrive.Text = "Old Drive";
            this.btn_oldDrive.UseVisualStyleBackColor = true;
            // 
            // form_start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_oldDrive);
            this.Controls.Add(this.btn_newDrive);
            this.Name = "form_start";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_newDrive;
        private System.Windows.Forms.Button btn_oldDrive;
    }
}


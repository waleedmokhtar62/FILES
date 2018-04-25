namespace StorageManager
{
    partial class form_setDrive
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
            this.btn_clustesr = new System.Windows.Forms.Button();
            this.btn_blocks = new System.Windows.Forms.Button();
            this.txt_sectorSize = new System.Windows.Forms.TextBox();
            this.txt_blockingFactor = new System.Windows.Forms.TextBox();
            this.txt_trackSize = new System.Windows.Forms.TextBox();
            this.txt_sectorsinCluster = new System.Windows.Forms.TextBox();
            this.btn_done = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_clustesr
            // 
            this.btn_clustesr.Location = new System.Drawing.Point(12, 12);
            this.btn_clustesr.Name = "btn_clustesr";
            this.btn_clustesr.Size = new System.Drawing.Size(75, 23);
            this.btn_clustesr.TabIndex = 0;
            this.btn_clustesr.Text = "Clusters";
            this.btn_clustesr.UseVisualStyleBackColor = true;
            this.btn_clustesr.Click += new System.EventHandler(this.btn_clustesr_Click);
            // 
            // btn_blocks
            // 
            this.btn_blocks.Location = new System.Drawing.Point(93, 12);
            this.btn_blocks.Name = "btn_blocks";
            this.btn_blocks.Size = new System.Drawing.Size(75, 23);
            this.btn_blocks.TabIndex = 1;
            this.btn_blocks.Text = "Blocks";
            this.btn_blocks.UseVisualStyleBackColor = true;
            this.btn_blocks.Click += new System.EventHandler(this.btn_blocks_Click);
            // 
            // txt_sectorSize
            // 
            this.txt_sectorSize.Location = new System.Drawing.Point(12, 87);
            this.txt_sectorSize.Name = "txt_sectorSize";
            this.txt_sectorSize.Size = new System.Drawing.Size(100, 20);
            this.txt_sectorSize.TabIndex = 3;
            this.txt_sectorSize.Text = "Sector Size";
            // 
            // txt_blockingFactor
            // 
            this.txt_blockingFactor.Location = new System.Drawing.Point(172, 86);
            this.txt_blockingFactor.Name = "txt_blockingFactor";
            this.txt_blockingFactor.Size = new System.Drawing.Size(100, 20);
            this.txt_blockingFactor.TabIndex = 4;
            this.txt_blockingFactor.Text = "Blocking Factor";
            // 
            // txt_trackSize
            // 
            this.txt_trackSize.Location = new System.Drawing.Point(12, 145);
            this.txt_trackSize.Name = "txt_trackSize";
            this.txt_trackSize.Size = new System.Drawing.Size(100, 20);
            this.txt_trackSize.TabIndex = 5;
            this.txt_trackSize.Text = "Track Size";
            // 
            // txt_sectorsinCluster
            // 
            this.txt_sectorsinCluster.Location = new System.Drawing.Point(171, 144);
            this.txt_sectorsinCluster.Name = "txt_sectorsinCluster";
            this.txt_sectorsinCluster.Size = new System.Drawing.Size(100, 20);
            this.txt_sectorsinCluster.TabIndex = 6;
            this.txt_sectorsinCluster.Text = "Sectors in Cluster";
            // 
            // btn_done
            // 
            this.btn_done.Location = new System.Drawing.Point(197, 226);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(75, 23);
            this.btn_done.TabIndex = 7;
            this.btn_done.Text = "Done";
            this.btn_done.UseVisualStyleBackColor = true;
            this.btn_done.Click += new System.EventHandler(this.btn_done_Click);
            // 
            // form_setDrive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_done);
            this.Controls.Add(this.txt_sectorsinCluster);
            this.Controls.Add(this.txt_trackSize);
            this.Controls.Add(this.txt_blockingFactor);
            this.Controls.Add(this.txt_sectorSize);
            this.Controls.Add(this.btn_blocks);
            this.Controls.Add(this.btn_clustesr);
            this.Name = "form_setDrive";
            this.Text = "Set Drive";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_clustesr;
        private System.Windows.Forms.Button btn_blocks;
        private System.Windows.Forms.TextBox txt_sectorSize;
        private System.Windows.Forms.TextBox txt_blockingFactor;
        private System.Windows.Forms.TextBox txt_trackSize;
        private System.Windows.Forms.TextBox txt_sectorsinCluster;
        private System.Windows.Forms.Button btn_done;
    }
}
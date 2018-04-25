using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageManager
{
    public partial class form_setDrive : Form
    {
        public form_setDrive()
        {
            InitializeComponent();
        }

        private void btn_clustesr_Click(object sender, EventArgs e)
        {
            btn_clustesr.Enabled = false;
            btn_blocks.Enabled = true;
            txt_sectorsinCluster.Enabled = true;
            txt_blockingFactor.Enabled = false;
        }

        private void btn_blocks_Click(object sender, EventArgs e)
        {
            btn_clustesr.Enabled = true;
            btn_blocks.Enabled = false;
            txt_sectorsinCluster.Enabled = false;
            txt_blockingFactor.Enabled = true;
        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            
            
            form_fileStructure setDrive = new form_fileStructure();
            setDrive.Show();
            this.Hide();
        }
    }
}

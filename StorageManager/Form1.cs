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
    public partial class form_start : Form
    {
        public form_start()
        {
            InitializeComponent();
        }

        private void btn_newDrive_Click(object sender, EventArgs e)
        {
            form_setDrive f = new form_setDrive();
            f.Show();
            this.Hide();
        }
    }
}

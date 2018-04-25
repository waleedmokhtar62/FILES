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
    public partial class form_fileStructure : Form
    {
        public form_fileStructure()
        {
            InitializeComponent();
        }

        private void cmb_fieldStructure_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_fieldStructure.SelectedText == "Fixed length")
            {
                dgv_fieldSize.Visible = true;
                dgv_fieldSize.Height = int.Parse(txt_numberOfFields.Text);
            }
        }

    }
}

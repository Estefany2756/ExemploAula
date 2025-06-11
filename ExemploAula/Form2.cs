using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploAula
{
    public partial class frmvalido : Form
    {
        public frmvalido()
        {
            InitializeComponent();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 log = new Form1();
            log.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciTakipSistemi
{
    public partial class frmanaform : Form
    {
        public frmanaform()
        {
            InitializeComponent();
        }

        private void btnogrenci_Click(object sender, EventArgs e)
        {
            OgrenciForm fr= new OgrenciForm();
            fr.ShowDialog();
        }

        private void btnbranşvehedef_Click(object sender, EventArgs e)
        {
            Target fr= new Target();
            fr.Show();
        }

        private void btnegitimkocu_Click(object sender, EventArgs e)
        {
            EgitimKocuForm fr=new EgitimKocuForm();
            fr.Show();
        }

        private void btnbranş_Click(object sender, EventArgs e)
        {
            EgitmenBranş fr = new EgitmenBranş();
            fr.ShowDialog();
        }

       
    }
}

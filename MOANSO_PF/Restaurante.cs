using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOANSO_PF
{
    public partial class Restaurante : Form
    {
        public Restaurante()
        {
            InitializeComponent();
        }

        private void btnCore_Click(object sender, EventArgs e)
        {
            Core formCore = new Core();
            formCore.Show();
        }

        private void btnMantenedor_Click(object sender, EventArgs e)
        {
            Mantenedores formMantenedores = new Mantenedores();
            formMantenedores.Show();
        }
    }
}

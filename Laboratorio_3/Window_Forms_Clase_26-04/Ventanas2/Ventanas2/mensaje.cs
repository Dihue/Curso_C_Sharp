using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventanas2
{
    public partial class mensaje : Form
    {
        public Contactos cont { get; set; }
        public mensaje()
        {

            InitializeComponent();
        }

        private void mensaje_Load(object sender, EventArgs e)
        {
            if (cont != null)
            {
                tb_id.Text = cont.id.ToString();
                tb_Nombre.Text = cont.nombre;
                tb_direccion.Text = cont.direccion;
                tb_telefono.Text = cont.telefono.ToString();
            }

        }

        private void bt_aceptar_Click(object sender, EventArgs e)
        {
            cont = new Contactos(int.Parse(tb_id.Text),
                tb_Nombre.Text, tb_direccion.Text, int.Parse(tb_telefono.Text)
                );
            this.Close();
        }
    }
}

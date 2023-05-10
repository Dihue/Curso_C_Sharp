namespace Ventanas2
{
    public partial class Form1 : Form
    {
        public List<Contactos> Lista_contactos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Lista_contactos = new List<Contactos>();
            Lista_contactos.Add(new Contactos(1, "Pedro", "Direccion", 232323));
            Lista_contactos.Add(new Contactos(2, "Pablo", "Direccion", 232323));
            Lista_contactos.Add(new Contactos(3, "Leandro", "Direccion", 232323));
            Lista_contactos.Add(new Contactos(4, "Sandra", "Direccion", 232323));
            Lista_contactos.Add(new Contactos(5, "Leonor", "Direccion", 232323));

            dataGridView1.DataSource = Lista_contactos;

        }

        private void BTN_ver_Click(object sender, EventArgs e)
        {

        }

        private void bt_Buscar_Click(object sender, EventArgs e)
        {

        }

        public void refrescar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Lista_contactos;
        }

        private void BTN_Nuevo_Click(object sender, EventArgs e)
        {
            mensaje m = new mensaje();
            m.ShowDialog();
            if (m.cont != null)
            {
                Lista_contactos.Add((Contactos)m.cont);
                refrescar();

            }
        }

        private void bt_Modificar_Click(object sender, EventArgs e)
        {
            Contactos c;
            int i = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            if (i > 0)
            {
                c = (Contactos)Lista_contactos.FirstOrDefault(a => a.id == i);
                if (c != null)
                {
                    mensaje m = new mensaje();
                    m.cont = c;
                    m.ShowDialog();
                    int indice = Lista_contactos.IndexOf(c);
                    Lista_contactos[indice] = m.cont;
                    refrescar();

                }

            }




        }

        private void bt_borrar_Click(object sender, EventArgs e)
        {
            Contactos c;
            int i = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            if (i > 0)
            {
                c = (Contactos)Lista_contactos.FirstOrDefault(a => a.id == i);
                if (c != null)
                {                   
                    int indice = Lista_contactos.IndexOf(c);
                    Lista_contactos.RemoveAt(indice);
                    refrescar();

                }

            }
        }
    }
}
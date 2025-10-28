using System.Runtime.InteropServices.Marshalling;

namespace Tarea4._3_Transaccion
{
    using POJO;
    using Backend;
    using System.Runtime.CompilerServices;

    public partial class Form1 : Form
    {
        private List<Producto> listaProductos = new List<Producto>();
        public Form1()
        {
            InitializeComponent();
            Iniciar();
        }

        public void Iniciar()
        {
            txtCode.KeyPress += AgregarProducto;
        }

        public async void AgregarProducto(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    string code = txtCode.Text;
                    DaoProductos daoProducts = new DaoProductos();
                    Producto producto = await daoProducts.BuscarProducto(code);

                    if (producto == null) throw new Exception("Producto no encontrado");
                    if (listaProductos.Exists(p => p.Codigo == producto.Codigo))
                    {
                        MessageBox.Show("El producto ya ha sido agregado a la lista.");
                    } else
                    {
                        listaProductos.Add(producto);
                        dataGridView1.DataSource = listaProductos;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnDescontinuar_Click(object sender, EventArgs e)
        {
            if (listaProductos.Count == 0)
            {
                MessageBox.Show("No hay productos para descontinuar.");
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro que quieres borrar productos?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    DaoProductos daoProducts = new DaoProductos();
                    if (daoProducts.DescontinuarProductos(listaProductos))
                    {
                        listaProductos.Clear();
                        dataGridView1.DataSource = null;
                        MessageBox.Show("Productos descontinuados correctamente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al descontinuar productos: " + ex.Message);
                }
            }
        }
    }
}

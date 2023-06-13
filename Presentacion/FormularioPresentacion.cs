using Entidad;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormularioPresentacion : Form
    {
        public FormularioPresentacion()
        {
            InitializeComponent();
        }

        #region "Variables"
        TipoSedeServicio tipoSedeServicio = new TipoSedeServicio(); 
        #endregion

        private void FormularioPresentacion_Load(object sender, EventArgs e)
        {
            ListarSedes();
        }

        private void ListarSedes()
        {
            try
            {
                List<Sede> sedes = tipoSedeServicio.Listar();
                boxSedes.DataSource = sedes;
                boxSedes.DisplayMember = "Nombre";
                boxSedes.ValueMember = "CodigoSede";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string AbrirArchivo()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Seleccionar archivo";
            openFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*) | *.* ";
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog1.FileName;
                return rutaArchivo;
            }
            return string.Empty;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            AbrirArchivo();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Olimpiadas
{
    /// <summary>
    /// Interaction logic for BorrarEvento.xaml
    /// </summary>
    public partial class BorrarEvento : Page
    {
        VentanaPrincipal ventana;
        public BorrarEvento(VentanaPrincipal ventana)
        {
            InitializeComponent();
            this.ventana = ventana;
        }

        private void OptionSelected(object sender, EventArgs e)
        {
            switch (BorrarEventoDropdown.Text)
            {
                case "Persona":
                    ventana.cambiarPaginaBorrarPersona();
                    break;
                case "Evento":
                    ventana.cambiarPaginaBorrarEvento();
                    break;
                case "Competición":
                    ventana.cambiarPaginaBorrarCompetencia();
                    break;
                case "Resultado":
                    ventana.cambiarPaginaBorrarResultado();
                    break;

            }
        }

        private void traerInfo(object sender, TextChangedEventArgs e)
        {
            OracleCommand cmd = new OracleCommand("SELECT YEAR AS anho, Location as lugar FROM OLYMPICS WHERE ID_OLYMPICS = '" + IDBorrarEvento.Text +"'", ventana.oracleConnection);
            OracleDataReader reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            if (dataTable.Rows.Count != 0)
            {
                NombreEventoBorrarEvento.Text = dataTable.Rows[0]["lugar"].ToString();
                AnhoEventoBorrarEvento.Text = dataTable.Rows[0]["anho"].ToString();
            }
            else
            {
                NombreEventoBorrarEvento.Text = "";
                AnhoEventoBorrarEvento.Text = "";
            }
                

        }

        private void borrarEvento(object sender, RoutedEventArgs e)
        {
            OracleCommand cmd = new OracleCommand("DELETE FROM OLYMPICS WHERE ID_OLYMPICS = '" +IDBorrarEvento.Text+"'", ventana.oracleConnection);
            int rowsUpdated = cmd.ExecuteNonQuery();
            if (rowsUpdated == 0)
            {
                MessageBox.Show("Hubo un problema al borrar");
            }
            else
            {
                MessageBox.Show("Evento borrado");
            }
            NombreEventoBorrarEvento.Text = "";
            AnhoEventoBorrarEvento.Text = "";
            IDBorrarEvento.Text = "";
        }
    }
}

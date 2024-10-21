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
    /// Interaction logic for EventosPage.xaml
    /// </summary>
    public partial class EventosPage : Page
    {
        VentanaPrincipal ventana;
        public EventosPage(VentanaPrincipal ventana)
        {
            InitializeComponent();
            this.ventana = ventana;
            displayEventos();
        }

        private void AgendaClick(object sender, RoutedEventArgs e)
        {
            Top5CheckBox.IsChecked = false;
        }

        private void Top5Click(object sender, RoutedEventArgs e)
        {
            AgendaCheckBox.IsChecked = false;
        }

        public void displayEventos()
        {
            try
            {
                OracleCommand cmd = new OracleCommand("select YEAR AS Año, LOCATION AS Sede from Olympics", ventana.oracleConnection);
                OracleDataReader reader = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridEventos.ItemsSource = dataTable.DefaultView;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

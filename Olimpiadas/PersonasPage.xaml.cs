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
    /// Interaction logic for PersonasPage.xaml
    /// </summary>
    public partial class PersonasPage : Page
    {
        VentanaPrincipal ventana;
        public PersonasPage(VentanaPrincipal ventana)
        {
            InitializeComponent();
            this.ventana = ventana;
            displayQuery();
        }

        private void ComboBox_Selected(object sender, RoutedEventArgs e)
        {

        }

        public void displayQuery()
        {
            try
            {
                OracleCommand cmd = new OracleCommand("SELECT p.FIRST_NAME AS Nombre, p.MIDDLE_NAME as SegundoNombre, p.FIRST_SURNAME AS PrimerApellido, p.SECOND_SURNAME as SegundoApellido, g.Gender AS Género, c.Country_NAME AS País \r\nFROM PERSON p\r\nJOIN COUNTRY c ON p.Id_country = c.ID_COUNTRY\r\nJOIN GENDER g ON p.ID_GENDER = g.ID_GENDER\r\nJOIN ID_TYPE i ON p.ID_ID_TYPE = i.ID_ID_TYPE", ventana.oracleConnection);


                OracleDataReader reader = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridPersonas.ItemsSource = dataTable.DefaultView;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}

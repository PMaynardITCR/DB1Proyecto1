using System.Data;
using System.Data.OracleClient;
using System.Text;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public OracleConnection oracleConnection { get; set; }
        public MainWindow()
        {
            oracleConnection = new OracleConnection("Data Source=localhost:1521/BaseDatos1;Persist Security Info=True;User ID=SYSTEM;Password=comemani;");
            oracleConnection.Open();
            InitializeComponent();

        }

        public Boolean validarIngreso()
        {
            OracleCommand cmd = new OracleCommand("SELECT COUNT(1) AS TOTAL FROM ADMINISTRATOR WHERE USERNAME = '"+loginUsuario.Text+"' AND PASSWORD = '"+loginContrasenha.Text+"'", oracleConnection);
            OracleDataReader reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();            
            dataTable.Load(reader);
            Decimal result = (Decimal)dataTable.Rows[0]["TOTAL"];
            if (result > 0)
            {
                return true;
            }
            else 
                return false;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void UsuarioRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void AdministradorRadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (validarIngreso())
            {
                Window VentanaPrincipal = new VentanaPrincipal(this);
                VentanaPrincipal.Show();
                this.Visibility = Visibility.Hidden;
            }
            else
            {
                MessageBox.Show("Acceso Denegado");
            }
            
            
        }
    }
}
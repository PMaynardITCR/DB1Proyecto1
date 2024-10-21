using System;
using System.Collections.Generic;
using System.Data.OracleClient;
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
    /// Interaction logic for InsertarEvento.xaml
    /// </summary>
    public partial class InsertarEvento : Page
    {
        VentanaPrincipal ventana;
        public InsertarEvento(VentanaPrincipal ventana)
        {
            this.ventana = ventana;
            InitializeComponent();
        }

        private void CheckedEditarEvento(object sender, RoutedEventArgs e)
        {
            IDEditarEvento.Visibility = Visibility.Visible;
            LabelIDEvento.Visibility = Visibility.Visible;
        }

        private void UncheckIDEvento(object sender, RoutedEventArgs e)
        {
            IDEditarEvento.Visibility = Visibility.Hidden;
            LabelIDEvento.Visibility = Visibility.Hidden;
        }

        public void insertar()
        {
            OracleCommand cmd = new OracleCommand("INSERT INTO OLYMPICS(ID_OLYMPICS, YEAR, LOCATION) VALUES (SEQ_OLYMPICS.nextval, "+AnhoEventoInsercionEvento.Text+", '"+NombreEventoInsercionEvento.Text+"')", ventana.oracleConnection);
            int rowsUpdated = cmd.ExecuteNonQuery();
            if (rowsUpdated == 0)
            {
                MessageBox.Show("Hubo un problema en la inserción");
            }
            else
            {
                MessageBox.Show("Evento agregado");
            }
            AnhoEventoInsercionEvento.Text = "";
            NombreEventoInsercionEvento.Text = "";
        }

        private void OptionSelected(object sender, EventArgs e)
        {
            switch (Insertar.Text)
            {
                case "Persona":
                    ventana.cambiarPaginaInsertarPersona();
                    break;
                case "Evento":
                    ventana.cambiarPaginaInsertarEvento();
                    break;
                case "Competición":
                    ventana.cambiarPaginaInsertarCompetencia();
                    break;
                case "Resultado":
                    ventana.cambiarPaginaInsertarResultado();
                    break;

            }
        }

        private void insertarEvento(object sender, RoutedEventArgs e)
        {
            insertar();
        }
    }
}

using System;
using System.Collections.Generic;
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
    /// Interaction logic for InsercionesPage.xaml
    /// </summary>
    public partial class InsertarPersona : Page
    {
        VentanaPrincipal ventana;
        public InsertarPersona(VentanaPrincipal ventana)
        {
            this.ventana = ventana;
            InitializeComponent();
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
    }
}

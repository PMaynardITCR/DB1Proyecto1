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
    /// Interaction logic for BorrarResultado.xaml
    /// </summary>
    public partial class BorrarResultado : Page
    {
        VentanaPrincipal ventana;
        public BorrarResultado(VentanaPrincipal ventana)
        {
            InitializeComponent();
            this.ventana = ventana;
        }

        private void OptionSelected(object sender, EventArgs e)
        {
            switch (BorrarResultadoDropdown.Text)
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
    }
}

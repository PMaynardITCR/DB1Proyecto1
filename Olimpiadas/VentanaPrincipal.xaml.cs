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
using System.Windows.Shapes;
using System.Data.OracleClient;
using System.Diagnostics.Eventing.Reader;

namespace Olimpiadas
{
    /// <summary>
    /// Interaction logic for VentanaPrincipal.xaml
    /// </summary>
    public partial class VentanaPrincipal : Window
    {
        MainWindow login;
        public OracleConnection oracleConnection {get;set;}
        public VentanaPrincipal(MainWindow login)
        {
            this.login = login;
            InitializeComponent();
            oracleConnection = login.oracleConnection;
            FrameContenido.Content = new PersonasPage(this);

        }

        public void conectarDB()
        {
            
        }

        private void PersonasTab(object sender, RoutedEventArgs e)
        {
            ponerEnNegro();
            PersonasButton.Foreground = Brushes.LightSkyBlue;
            FrameContenido.Content = new PersonasPage(this);
        }

        private void EventosTab(object sender, RoutedEventArgs e)
        {
            ponerEnNegro();
            EventosButton.Foreground = Brushes.LightSkyBlue;
            FrameContenido.Content = new EventosPage(this);
        }

        private void EstadisticasTab(object sender, RoutedEventArgs e)
        {
            ponerEnNegro();
            EstadisticasButton.Foreground = Brushes.LightSkyBlue;
            FrameContenido.Content = new EstadisticasPage();
        }

        private void InsercionesTab(object sender, RoutedEventArgs e)
        {
            ponerEnNegro();
            InsercionesButton.Foreground = Brushes.LightSkyBlue;
            FrameContenido.Content = new InsertarEvento(this);
        }

        private void BorradoTab(object sender, RoutedEventArgs e)
        {
            ponerEnNegro();
            BorradoButton.Foreground = Brushes.LightSkyBlue;
            FrameContenido.Content = new BorrarEvento(this);
        }

        void ponerEnNegro()
        {
            PersonasButton.Foreground = Brushes.Black;
            EventosButton.Foreground = Brushes.Black;
            EstadisticasButton.Foreground = Brushes.Black;
            InsercionesButton.Foreground = Brushes.Black;
            BorradoButton.Foreground = Brushes.Black;
        }

        public void cambiarPaginaInsertarPersona()
        {
            FrameContenido.Content = new InsertarPersona(this);
        }

        public void cambiarPaginaInsertarEvento()
        {
            FrameContenido.Content = new InsertarEvento(this);
        }

        public void cambiarPaginaInsertarCompetencia()
        {
            FrameContenido.Content = new InsertarCompetencia(this);
        }

        public void cambiarPaginaInsertarResultado()
        {
            FrameContenido.Content = new InsertarResultado(this);
        }

        public void cambiarPaginaBorrarPersona()
        {
            FrameContenido.Content = new BorrarPersona(this);
        }

        public void cambiarPaginaBorrarEvento()
        {
            FrameContenido.Content = new BorrarEvento(this);
        }

        public void cambiarPaginaBorrarCompetencia()
        {
            FrameContenido.Content = new BorrarCompetencia(this);
        }

        public void cambiarPaginaBorrarResultado()
        {
            FrameContenido.Content = new BorrarResultado(this);
        }

        private void Cerrar(object sender, System.ComponentModel.CancelEventArgs e)
        {
            oracleConnection.Close();
            login.Close();
        }
    }
}

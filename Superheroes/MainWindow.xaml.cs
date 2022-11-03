using Superheroes.Modelo;
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

namespace Superheroes
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int posicionHereo = 0;
        private List<Superheroe> superheroes = Superheroe.GetSamples();
        public MainWindow()
        {
            InitializeComponent();
            CambiaSuperHereo();
        }

        private void Event_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Image i = (Image)sender;
            if(i.Tag.ToString() == "Derecha")
            {
                if (posicionHereo < 2)
                    posicionHereo++;
            } else if (i.Tag.ToString() == "Izquierda")
            {
                if (posicionHereo > 0)
                    posicionHereo--;
            }

            ConteoSuperHeroe.Text = posicionHereo+1 + "/3";
            CambiaSuperHereo();
        }

        private void CambiaSuperHereo()
        {
            DockPanelSuperheroes.DataContext = superheroes[posicionHereo];
        }
    }
}

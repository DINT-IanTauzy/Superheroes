using CommunityToolkit.Mvvm.ComponentModel;
using Superheroes.Modelo;
using Superheroes.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheroes.VistaModelo
{
    class MainWindowVM : ObservableObject
    {
        private Superheroe personaje;

        public Superheroe Personaje
        {
            get { return personaje; }
            set { SetProperty(ref personaje, value); }
        }

        private int posicion;

        public int Posicion
        {
            get { return posicion; }
            set{ SetProperty(ref posicion, value); }
            
        }

        private int total;

        public int Total
        {
            get { return total; }
            set{ SetProperty(ref total, value); }
        }

        private SuperheroesService servicioHeroes;
        private DialogosService servicioDialogos;

        private ObservableCollection<Superheroe> listaSuperheroe;

        public MainWindowVM()
        {
            servicioHeroes = new SuperheroesService();
            servicioDialogos = new DialogosService();
            listaSuperheroe = servicioHeroes.ObtenerHeroes();
            this.Personaje = listaSuperheroe[0];
            this.Posicion = 1;
            this.Total = listaSuperheroe.Count;
        }

        public void Avanzar()
        {
            if(Posicion < Total)
            {
                Posicion++;
                Personaje = listaSuperheroe[Posicion - 1];
            }
            else{
                servicioDialogos.MostrarMensaje("Has llegado al final");
            }
                
        }

        public void Retroceder()
        {
            if(Posicion > 1)
            {
                Posicion--;
                Personaje = listaSuperheroe[Posicion - 1];
            }
            else
            {
                servicioDialogos.MostrarMensaje("Has llegado al principio");
            }
                
        }
       
    }
}

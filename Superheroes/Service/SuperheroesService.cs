using Superheroes.Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheroes.Service
{
    class SuperheroesService
    {
        public ObservableCollection<Superheroe> ObtenerHeroes()
        {
            return Superheroe.GetSamples();
        }
    }
}

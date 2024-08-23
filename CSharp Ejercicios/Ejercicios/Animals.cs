using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Animals
    {
        private string _nombre;
        private string _raza;

        public string Nombre
        {
            get => _nombre;
            set => _nombre = value;
        }

        public string Raza
        {
            get => _raza;
            set => _raza = value;
        }
    }
}

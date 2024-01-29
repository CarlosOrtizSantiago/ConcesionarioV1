using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcesionarioV1
{
    public class Vehiculo
    {
        //CONSTANTES


        //MIEMBROS PRIVADOS
        private string _marca;
        private string _modelo;

        //CONSTRUCTORES
        public Vehiculo(string marca, string modelo) 
        {
            Marca = marca;
            Modelo = modelo;
        }

        //PROPIEDADES
        public string Marca 
        { 
            get { return _marca; }
            //TODO Proporcionar seguridad y proteccion al miembro _marca
            set { _marca = value; }
        }

        public string Modelo
        {
            get { return _modelo; }
            //TODO Proporcionar seguridad y proteccion al miembro _modelo
            set { _modelo = value; }
        }

        //METODOS PUBLICOS


        //METODOS PRIVADOS
    }
}

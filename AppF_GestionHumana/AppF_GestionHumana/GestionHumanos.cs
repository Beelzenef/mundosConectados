using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppF_GestionHumana
{
    class GestionHumanos
    {
        // Campos

        List<Persona> _listaCiudadanos = new List<Persona>();

        List<int> _listaCods = new List<int>();
        bool _ordenados = false;
        Random rnd = new Random();

        

        // Propiedades

        /// ... ListaCods
        /// <summary>
        /// Gestión de códigos generados aleatoriamente y sin repetición
        /// </summary>
        public List<int> ListaCods
        {
            get
            {
                if (!_ordenados)
                    return _listaCods;
                return _listaCods;
            }
        }

        // Métodos

        /// ... AnadirCiudadano()
        /// <summary>
        /// Añadir a un ciudadano a la lista de Ciudadanos
        /// </summary>
        public void AnadirCiudadano(string nombreProv, string fechaProv, string apellido1Prov, string apellido2Prov)
        {
            int codProv = 0;

            while (codProv == 0)
            {
                codProv = Generar(1, 100);
            }

            Persona A = new Persona(codProv, nombreProv, fechaProv, apellido1Prov, apellido2Prov);
            _listaCiudadanos.Add(A);

        }

        /// ... Eliminar a un humano
        /// <summary>
        /// 
        /// DEVUELVE ENTEROS QUE PUEDE SERVIR PARA LLEVAR REGISTRO DE CIUDADANOS ELIMINADOS
        /// </summary>
        /// <returns>Estado de la eliminación ciudadana:
        /// Entero positivo con el índice del ciudadano a eliminar
        /// -1 si eliminación no confirmada o fallida (ciudadano no existe)</returns>
        public int EliminarCiud(int eligeID)
        {
            // Variable temporal para comparar contenido en las listas
            int tmp = 0;

            if (_listaCiudadanos.Count == 0)
            {
                //La lista está vacía
                return 0;
            }
            else
            {
               

                // Buscando al ciudadano, lanzando una jauría de perros
                for (int i = 0; i < _listaCods.Count; i++)
                {
                    tmp = Convert.ToInt32(_listaCods[i]);
                    // El ciudadano existe, ha de ser eliminado
                    if (tmp == eligeID)
                    {
                        _listaCiudadanos.RemoveAt(i);
                        _listaCods.RemoveAt(i);
                        return 1;
                    }
                }

                // El ciudadano no ha sido encontrado
                return -1;
            }


        }

        /// ... Lista()
        /// <summary>
        /// Listando a los usuarios introducidos en _listaCiudadanos
        /// </summary>
        public void Listar()
        {
            if (_listaCiudadanos.Count == 0)
            {
                // La lista está vacía
                return;
            }
            else
            {
                foreach (Persona p in _listaCiudadanos)
                {
                    p.ToString();
                }
            }
        }

        /// ... Mostrar()
        /// <summary>
        /// Mostrando a usuarios identificados por código
        /// </summary>
        public int Buscar(int eligeID)
        {
            // Variable temporal para comparar contenido de lista de ciduadanos
            int tmp = 0;

            // Si la lista está vacía...
            if (_listaCiudadanos.Count == 0)
            {
                // La lista de ciudadanos está vacía
                return 0;
            }
            // Si no, pasamos a buscar códigos únicos
            else
            {
                // Buscando al ciudadano
                for (int i = 0; i < _listaCods.Count; i++)
                {
                    tmp = Convert.ToInt32(_listaCods[i]);
                    // El ciudadano existe, ha de ser mostrado
                    if (tmp == eligeID)
                    {
                        _listaCiudadanos[i].ToString();
                        return i;
                    }
                }
                // El ciudadano no ha sido encontrado
                return -1;
            }
        }

        /// ... Ver()
        /// <summary>
        /// Verificando si un ciudadano existe o no
        /// </summary>
        public int Ver(int eligeID)
        {
            // Variable temporal para comparar contenido de lista de ciduadanos
            int tmp = 0;

            // Si la lista está vacía...
            if (_listaCiudadanos.Count == 0)
            {
                // La lista está vacía
                return 0;
            }
            // Si no, pasamos a buscar códigos únicos
            else
            {
                

                // Buscando al ciudadano
                for (int i = 0; i < _listaCods.Count; i++)
                {
                    tmp = Convert.ToInt32(_listaCods[i]);
                    // El ciudadano existe, ha de ser mostrado
                    if (tmp == eligeID)
                    {
                        _listaCiudadanos[i].ToString();
                        return eligeID;
                    }
                }
                return -1;
            }
        }



        /// ... Generar()
        /// <summary>
        /// Generación de números aleatorios con un máximo valor y una cantidad añadida
        /// para añadir a lista números sin repetición
        /// </summary>
        /// <param name="cantidad">Número máximo de números generados</param>
        /// <param name="maximoValor">Máximo valor que toman los números generados aleatoriamente</param>
        private int Generar(int cantidad, int maximoValor)
        {
            int nTemp = 0;
            while (_listaCods.Count <= cantidad)
            {
                nTemp = rnd.Next(maximoValor);
                if (_listaCods.Contains(nTemp))
                {
                    continue;
                }
                _listaCods.Add(nTemp);
                return nTemp;
            }

            return 0;

        }

    }

    /// ... Persona
    /// <summary>
    /// Estructura para personas, con información de nombres, apeplidos, fechas de nacimiento, sueldo y código
    /// único generado de forma aleatoria.
    /// </summary>
    public struct Persona
    {
        // Campos para personas

        int _codigo;
        string _apellido1;
        string _apellido2;
        string _nombre;
        string _fechaNacimiento;

        // Propiedades

        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        public string Fecha
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Apellido1
        {
            get { return _apellido1; }
            set { _apellido1 = value; }
        }

        public string Apellido2
        {
            get { return _apellido2; }
            set { _apellido2 = value; }
        }


        public Persona(int id, string nombre, string fecha, string apellido1, string apellido2)
        {
            _codigo = id;
            _nombre = nombre;
            _apellido1 = apellido1;
            _apellido2 = apellido2;
            _fechaNacimiento = fecha;

        }

        /// ... ToString() sobreescrito
        /// <summary>
        /// Sobreescribir para mostrar datos de personas de forma ordenada
        /// </summary>
        /// <returns>Cadena de texto con datos ordenados de Personas</returns>
        public override string ToString()
        {
            return "código " + _codigo.ToString().PadRight(4, ' ') +
               "; nombre " + _nombre.PadRight(10, ' ') +
               "; fecha " + _fechaNacimiento.PadRight(5, ' ');

        }

    }

}
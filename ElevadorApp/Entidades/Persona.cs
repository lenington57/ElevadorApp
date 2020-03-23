using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevadorApp.Entidades
{
    public class Persona
    {
        public int PersonaId { get; set; }
        public string Nombre { get; set; }
        public int Peso { get; set; }
        public int Piso { get; set; }
        public string Estado { get; set; }

        public Persona()
        {
            PersonaId = 0;
            Nombre = string.Empty;
            Peso = 0;
            Piso = 0;
            Estado = string.Empty;
        }

        public Persona(int personaId, string nombre, int peso, int piso, string estado)
        {
            PersonaId = personaId;
            Nombre = nombre;
            Peso = peso;
            Piso = piso;
            Estado = estado;
        }

    }
}

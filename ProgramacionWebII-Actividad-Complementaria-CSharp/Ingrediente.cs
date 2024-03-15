using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramacionWebII_Actividad_Complementaria_CSharp
{
    class Ingrediente
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Ingrediente>? Ingredientes { get; set; }


         // Constructor
        public Ingrediente(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
          
        }

    }
}

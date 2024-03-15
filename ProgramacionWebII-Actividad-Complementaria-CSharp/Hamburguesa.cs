using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramacionWebII_Actividad_Complementaria_CSharp
{
    public class Hamburguesa
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public string Descripcion { get; set; }

        // Constructor
        public Hamburguesa(int id, string nombre, int precio, string descripcion)
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
            Descripcion = descripcion;
        }

        // Método para mostrar detalles de la hamburguesa
        public void MostrarDetalles()

        {
            Console.WriteLine($"ID: {Id}, Nombre: {Nombre}, Precio: {Precio:C}, Descripción: {Descripcion}");
        }
    }





}

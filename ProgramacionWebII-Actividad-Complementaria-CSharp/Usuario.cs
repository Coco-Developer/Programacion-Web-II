using System;

namespace ProgramacionWebII_Actividad_Complementaria_CSharp
{
    public class Usuario
    {
            public int Id { get; set; }

            public DateTime Nacimiento { get; set; }

            public int Edad { get; set; }

            public string Nombre { get; set; }

            public string Apellido { get; set; }



        public Usuario(int id, DateTime nacimiento, int edad, string nombre, string apellido)
        {
            Id = id;
            Nacimiento = nacimiento;
            Edad = edad;
            Nombre = nombre;
            Apellido = apellido;

        }


        public void ComprarHamburguesa(Hamburguesa hamburguesa)

            {

               if (hamburguesa == null)
               {

                throw new ArgumentNullException(nameof(hamburguesa), "La hamburguesa no puede ser nula");

                Console.WriteLine($"{Nombre} ha comprado {hamburguesa.Nombre}");
               }


            }


    }





}


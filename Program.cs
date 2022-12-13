using System;
using net1;
using MySql.Data.MySqlClient;
namespace net1
{
    class Program {
        static void Main(string[] args)
        {
            PersonaRepository repo= new PersonaRepository();

            List<PersonaNueva> lista= repo.BuscarTodas();

            foreach (var persona in lista)
            {
                Console.WriteLine(persona.DNI);
                Console.WriteLine(persona.Nombre);
                Console.WriteLine(persona.Apellidos);
            }
          
        }
    }
}
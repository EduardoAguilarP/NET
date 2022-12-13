using System;
using net1;
using MySql.Data.MySqlClient;
namespace net1
{
    class Program {
        static void Main(string[] args)
        {
            PersonaRepository repo= new PersonaRepository();

            /*List<PersonaNueva> lista= repo.BuscarTodas();

            foreach (var persona in lista)
            {
                Console.WriteLine(persona.DNI);
                Console.WriteLine(persona.Nombre);
                Console.WriteLine(persona.Apellidos);
            }

            Console.WriteLine("*******************");*/

            PersonaNueva pnueva= new PersonaNueva("12","Marcelo","Salas");
            repo.Insertar(pnueva);

            /*PersonaNueva pborrar= new PersonaNueva("12","Marcelo","Salas");
            repo.Borrar(pborrar);*/

            List<PersonaNueva> lista2= repo.BuscarTodasOrdenadasPorNombre();

            foreach (var persona in lista2)
            {                
                Console.WriteLine(persona.Nombre);
                Console.WriteLine(persona.Apellidos);
                Console.WriteLine(persona.DNI);
            }

          
        }
    }
}
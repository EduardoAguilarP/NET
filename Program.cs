using System;
using net1;
using MySql.Data.MySqlClient;
namespace net1
{
    class Program {
        static void Main(string[] args)
        {
            PersonaRepository repo= new PersonaRepository();

            List<PersonaNueva> lista= repo.obtenerConexion();

           Console.WriteLine("hola");
        }
    }
}
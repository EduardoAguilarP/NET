namespace net1 {

    public class PersonaNueva {

        public string DNI {get;set;}
        public string Nombre {get;set;}
        public string Apellidos {get;set;}

        public PersonaNueva(string dni, string nombre, string apellidos) {
            this.DNI=dni;
            this.Nombre=nombre;
            this.Apellidos=apellidos;

        }
    }
}
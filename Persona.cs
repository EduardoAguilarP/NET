namespace net1
{
    public class Persona
    {
      private string nombre="";
      private int edad;
      //propiedad en .net
      public int Edad {
        get {
          return this.edad;
        }
        set {
          if(value<120)
          this.edad=value;
          else this.edad=120;
        }
      }
      public string? Nombre {get;set;}
      public bool estaJubilado() {
        return edad>65;
      }
    }
}

namespace net1
{
    public class Caja
    {
     //variables de la clase
      public int largo;
      public int ancho;
      public int profundidad;
      public Caja(int largo, int ancho, int profundidad) {
        this.largo=largo;
        this.ancho=ancho;
        this.profundidad=profundidad;
      }
      public double volumen(){
        return largo*ancho*profundidad;
      }
    }
}

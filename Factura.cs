namespace net1 {

public class Factura {
    public int numero;
    public bool pagada;
    public int importe;
    public string concepto="";
    public double ImporteConIVA() {
        return importe*1.21;
    }
}

}


public class Memoria: Decorator{

    public Memoria(OrdenBase ordenBase):base(ordenBase){ }

    public override string Extender(){
        var teclado = orden.Extender();
        Console.WriteLine("Se ha agregado memoria adicional a su telefono");
      return teclado;
    }
}
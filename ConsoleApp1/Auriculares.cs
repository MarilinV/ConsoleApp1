public class Auriculares: Decorator{
    
    public Auriculares(OrdenBase ordenBase):base(ordenBase){
        
    }
    public override string Extender(){
        var sonido = orden.Extender();
        Console.WriteLine("Se ha agregado un auricular adicional");
      return sonido;
    }
}
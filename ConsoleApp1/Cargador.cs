public class Cargador: Decorator{
    
    public Cargador(OrdenBase ordenBase):base(ordenBase){
        
    }
    public override string Extender(){
        var teclado = orden.Extender();
        Console.WriteLine("Se ha agregado un cargador adicional");
      return teclado;
    }
}
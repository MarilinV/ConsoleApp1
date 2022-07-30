public class Caida: Decorator{

    public Caida(OrdenBase ordenBase):base(ordenBase){ }
    public override string Reparar()
    {
        var reparacion = "Su telefono sera reparado por una caida";
          return reparacion;
    }
}
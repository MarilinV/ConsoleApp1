public class Formatear: Decorator{

    public Formatear(OrdenBase ordenBase):base(ordenBase){ }
    public override string Reparar(){
        var reparacion = "Tu telefono será formateado";
          return reparacion;
    }
}
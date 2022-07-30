public class Pantalla: Decorator{

    public Pantalla(OrdenBase ordenBase):base(ordenBase){ }
    public override string Reparar(){
        var reparacion = "La pantalla de su telefono sera reparada";
          return reparacion;
    }
}
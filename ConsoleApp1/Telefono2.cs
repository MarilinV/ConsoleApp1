public class Telefono2:OrdenBase
    {
    public override string Reparar(){
    var repara = "su telefono está siendo reparado";
    return repara;
    }
   public override string Extender(){
    var repara = "Se le agregara un hardware adicional al dispositivo¿Desea agregar una extencion";
    return repara;
    }
}
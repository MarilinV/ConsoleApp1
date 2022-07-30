using System;
public class Decorator{
    protected OrdenBase orden;

    public Decorator(OrdenBase orden)
    {
        this.orden= orden;
    }
    public virtual string Extender(){
      return orden.Extender();
    }
    public virtual string Reparar(){
      return orden.Extender();
    }
}
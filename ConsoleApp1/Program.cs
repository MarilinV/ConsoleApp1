class Program
{
    public static void Main(String[] args)
    {

        //Dispositivo#1
        Console.WriteLine("");
        var Dispositivo1 = new Telefono1();
        Console.WriteLine(Dispositivo1.Reparar());

        var Reparar1 = new Pantalla(Dispositivo1);
        Console.WriteLine(Reparar1.Reparar());

        var Reparar2 = new Caida(Dispositivo1);
        Console.WriteLine(Reparar2.Reparar());

        var Reparar3 = new Caida(Dispositivo1);
        Console.WriteLine(Reparar2.Reparar());

        Console.WriteLine(Dispositivo1.Extender());

        var cargador = new Cargador(Dispositivo1);
        Console.WriteLine(cargador.Extender());
        Console.WriteLine("*******************");


        //Dispositivo#2
        Console.WriteLine("");
        var Dispositivo2 = new Telefono2();
        Console.WriteLine(Dispositivo2.Reparar());

        var Reparaar1 = new Pantalla(Dispositivo2);
        Console.WriteLine(Reparaar1.Reparar());

        var Reparaar2 = new Caida(Dispositivo2);
        Console.WriteLine(Reparaar2.Reparar());

        var Reparaar3 = new Caida(Dispositivo2);
        Console.WriteLine(Reparaar3.Reparar());

        Console.WriteLine(Dispositivo2.Extender());

        var auriculares = new Auriculares(Dispositivo2);
        Console.WriteLine(auriculares.Extender());
        Console.WriteLine("");
        Console.WriteLine("*******************");


        //Dispositivo#2
        Console.WriteLine("");
        var Dispositivo3 = new Telefono2();
        Console.WriteLine(Dispositivo2.Reparar());

        var Repaaraar1 = new Pantalla(Dispositivo3);
        Console.WriteLine(Reparaar1.Reparar());

        var Repaaraar2 = new Caida(Dispositivo3);
        Console.WriteLine(Reparaar2.Reparar());

        var Repaaraar3 = new Caida(Dispositivo3);
        Console.WriteLine(Reparaar3.Reparar());

        Console.WriteLine(Dispositivo3.Extender());

        var memory = new Memoria(Dispositivo3);
        Console.WriteLine(memory.Extender());
        Console.WriteLine("");
        Console.WriteLine("*******************");
    }
}
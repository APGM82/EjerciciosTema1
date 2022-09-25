using EjerciciosTema1;

internal class Program
{
    static void Main(string[] args)
    {
        String x = "";
        int select = 0;
        do
        {

            Console.WriteLine("Seleccione la ocion deseada: ");
            Console.WriteLine("1: Fechas");
            Console.WriteLine("2: Libros");
            Console.WriteLine("3: Puerto");
            Console.WriteLine("4: Salir");


            string sel = Console.ReadLine();
            if (!int.TryParse(sel, out select))
            {
                Console.WriteLine("Introduzca una opción válida");
            }
            switch (select)
            {
                case 1:
                    //fechas
                    Fechas.Selector();
                    break;
                case 2:
                    //
                    Libros.Selector();
                    //Console.WriteLine("Esta funcionalidad aún no ha sido implementada");
                    //Console.WriteLine("¡Proximamente nueva funcionalidad!");
                    break;
                case 3:
                    Alquiler.Selector();
                    //Console.WriteLine("Esta funcionalidad aún no ha sido implementada");
                    //Console.WriteLine("¡Proximamente nueva funcionalidad!");
                    break;
                case 4:
                    //salir
                    break;
            }
        } while (select != 4);

        //todo esto se podia haber evitado con el tryParse en fecha...



    }
}
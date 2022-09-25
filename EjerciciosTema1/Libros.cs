using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosTema1
{
    internal class Libros
    {
        
        private String str_titulo;
        public String Titulo
        {
            get { return str_titulo; }
            set { str_titulo = value; }
        }

        
        private String str_autor;
        public String Autor
        {
            get { return str_autor; }
            set { str_autor = value; }
        }

        // private String Estilo;
        private String str_Estilo;

        public String Estilo
        {
            get { return str_Estilo; }
            set { str_Estilo = value; }
        }

        //private String Editorial;
        private String str_Editorial;

        public String Editorial
        {
            get { return str_Editorial; }
            set { str_Editorial = value; }
        }

        public Libros()
        {
            Console.WriteLine("Introduzca Título del libro: ");
            String tit = Console.ReadLine();
            this.Titulo = tit;
            Console.WriteLine("Introduzca autor:");
            String aut = Console.ReadLine();
            this.Autor = aut;
            Console.WriteLine("Introduzca estilo del libro: ");
            String est = Console.ReadLine();
            this.Estilo = est;
            Console.WriteLine("Introduzca editorial");
            String edi = Console.ReadLine();
            this.Editorial = edi;



        }
        public static void Selector()
        {
            int select = 0;
            List<Libros> L = new List<Libros>();
            do
            {


                Console.WriteLine("Seleccione la ocion deseada: ");
                Console.WriteLine("1: Insertar libro");
                Console.WriteLine("2: Ver listado de libros");
                Console.WriteLine("3: Modificar un libro");
                Console.WriteLine("4: Eliminar un libro");
                Console.WriteLine("5: Salir");

                string sel = Console.ReadLine();
                if (!int.TryParse(sel, out select))
                {
                    // Parsing failed, handle the error however you like
                }
                switch (select)
                {
                    case 1:
                        Libros a = new Libros();
                        L.Add(a);
                        break;
                    case 2:

                        for (int i = 0; i < L.Count; i++)
                        {
                            Console.WriteLine("=========================");
                            Console.WriteLine("Código " + i);
                            Console.WriteLine("Título: " + L[i].Titulo);
                            Console.WriteLine("Autor: " + L[i].Autor);
                            Console.WriteLine("Estilo: " + L[i].Estilo);
                            Console.WriteLine("Editorial: " + L[i].Editorial);
                            Console.WriteLine("=========================");
                        }

                        break;
                    case 3:
                        int select2;
                        int codigoint;
                        int coigoEliminar;
                        Console.WriteLine("¿Que libro quiere modificar?(Código)");
                        String codigo = Console.ReadLine();
                        if (!int.TryParse(codigo, out codigoint))
                        {
                            
                        }
                        Console.WriteLine("¿Que elemento quiere modificar?");
                        Console.WriteLine("1: Título");
                        Console.WriteLine("2: Autor");
                        Console.WriteLine("3: Estilo");
                        Console.WriteLine("4: Editorial");
                        string sel2 = Console.ReadLine();
                        if (!int.TryParse(sel2, out select2))
                        {
                            // Parsing failed, handle the error however you like
                        }
                        switch (select2)
                        {
                            case 1:
                                Console.WriteLine("Nuevo título: ");
                                L[codigoint].Titulo = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("Nuevo autor: ");
                                L[codigoint].Autor = Console.ReadLine();
                                break;
                            case 3:
                                Console.WriteLine("Nuevo estilo: ");
                                L[codigoint].Estilo = Console.ReadLine();
                                break;
                            case 4:
                                Console.WriteLine("Nueva editorial: ");
                                L[codigoint].Editorial = Console.ReadLine();
                                break;
                        }

                        break;
                    case 4:

                        Console.WriteLine("¿Qué libro desea eliminar?(Código): ");
                        string eli = Console.ReadLine();
                        if (!int.TryParse(eli, out coigoEliminar)) ;
                        {
                            // Parsing failed, handle the error however you like
                        }
                        L.RemoveAt(coigoEliminar);
                        break;
                    case 5:
                        break;
                }
            } while (select != 5);
        }
    }
}

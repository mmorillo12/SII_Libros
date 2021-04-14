using System;

namespace Poliformismo_Libro
{
    public class Libro{
        protected string autor;
        protected string titulo;
        protected string ubicacion;
        public string Autor {get{return autor;} set{autor = value;} }
        public string Titulo {get{return titulo;} set{titulo = value;}}
        public string Ubicacion {get{return ubicacion;} set{ubicacion = value;}}

        public Libro(){}

        public Libro(string autor, string titulo, string ubicacion){
            this.autor = autor;
            this.titulo = titulo;
            this.ubicacion = ubicacion;
            Console.WriteLine("Creando libro");
        }

        public Libro(string autor, string titulo){
            this.autor = Autor;
            this.titulo = titulo;
            this.ubicacion = "No detallada";
            Console.WriteLine("Creando Documento");
        }

        public virtual void Ver(){
            Console.WriteLine("Autor: {0}", Autor);
            Console.WriteLine("Titulo: {0}", Titulo);
            Console.WriteLine("Ubicacion: {0}", Ubicacion);
        }
    }
    public class Documento : Libro{
        protected int paginas;
        public int Paginas{get{return paginas;} set{paginas = value;}}
        public Documento(){}
        public Documento(string autor, string titulo, string ubicacion,int paginas):base(autor, titulo, ubicacion){
            this.paginas = paginas;
            Console.WriteLine("Creando documento");
        }
        public override void Ver()
        {
            Console.WriteLine("Autor: {0}", Autor);
            Console.WriteLine("Titulo: {0}", Titulo);
            Console.WriteLine("Ubicacion: {0}", Ubicacion);
            Console.WriteLine("Paginas: {0}", Paginas);
        }
    }
    public class PruebaDeLibro : Libro{
        public void Main1(){
        Libro lib = new Libro();
        lib.Autor = "Zusanne Collins";
        lib.Titulo = "Los Juegos del Hambre";
        lib.Ubicacion = "Estados Unidos";
        Console.WriteLine("Autor: " + lib.Autor);
            Console.WriteLine("Titulo: " + lib.Titulo);
            Console.WriteLine("Ubicacion: " + lib.Ubicacion);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {   
            Libro libro1 = new Libro();
            Documento doc1 = new Documento();
            int va = 0;
            while(va != 3){
                Console.WriteLine("          ---- MENU ----            ");
                Console.WriteLine("Opcion 1: Añadir nuevo Libro");
                Console.WriteLine("Opcion 2: Añadir Docuemtno Generico");
                Console.WriteLine("Opcion 3: Salir");
            va = int.Parse(Console.ReadLine());
            Console.Clear();
            switch(va){
                case 1:
                Console.WriteLine("Inserte el Autor");
                libro1.Autor = Console.ReadLine();
                Console.WriteLine("Inserte el Titulo");
                libro1.Titulo = Console.ReadLine();
                Console.WriteLine("Inserte la Ubicacion");
                libro1.Ubicacion = Console.ReadLine();
                libro1.Ver();
                break;
                case 2:
                Console.WriteLine("Inserte El Autor");
                doc1.Autor = Console.ReadLine();
                Console.WriteLine("Inserte el Titulo");
                doc1.Titulo = Console.ReadLine();
                Console.WriteLine("Inserte la Ubicacion");
                doc1.Ubicacion = Console.ReadLine();
                Console.WriteLine("Inserte el numero de paginas");
                doc1.Paginas = int.Parse(Console.ReadLine());
                doc1.Ver();
                break;
                case 3:
                Console.Clear();
                Console.Write("Fin del Programa");
                break;
            }
            }

        }
    }
}


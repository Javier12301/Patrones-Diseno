using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear un libro y un video
            ILibraryItem book = new Book("Worley");
            ILibraryItem video = new Video("Moonwalker");

            //Crear decoradores y agregar responsabilidades adicionales
            Borrowable borrowableBook = new Borrowable(book);
            Borrowable borrowableVideo = new Borrowable(video);

            //Prestar un libro y un video
            borrowableBook.BorrowItem("Javier");
            borrowableVideo.BorrowItem("Mareclo");

            //Mostrar los items
            borrowableBook.Display();
            borrowableVideo.Display();

            // Devolver el libro y el video
            borrowableBook.ReturnItem();
            borrowableVideo.ReturnItem();

            //Mostrar los items nuevamente
            borrowableBook.Display();
            borrowableVideo.Display();

            Console.ReadKey();



        }

    }

    // Componente (LibraryItem)
    interface ILibraryItem
    {
        void Display();
    }

    // ConcreteComponent (Book)
    class Book : ILibraryItem
    {
        private string title;

       
        public Book(string title)
        {
            this.title = title;
        }

        public void Display()
        {
            Console.WriteLine("Libro: " + title);
        }
    }

    // ConcreteComponent (Video)
    class Video : ILibraryItem
    {
        private string title;

        public Video(string title)
        {
            this.title = title;
        }

        public void Display()
        {
            Console.WriteLine("Video: " + title);
        }
    }

    // Decorator (Decorator)
    abstract class LibraryItemDecorator : ILibraryItem
    {
        protected ILibraryItem libraryItem;

        
        public LibraryItemDecorator(ILibraryItem libraryItem)
        {
            this.libraryItem = libraryItem;
        }

        //es virtual para que se pueda sobreescribir en las clases hijas
        public virtual void Display()
        {
            libraryItem.Display();
        }
    }

    // ConcreteDecorator (Borrowable)
    class Borrowable : LibraryItemDecorator
    {
        //En español borrower es prestar
        protected string borrower;
        
        // Constructor
        public Borrowable(ILibraryItem libraryItem) : base(libraryItem)
        {
            
        }
        
        public void BorrowItem(string borrower)
        {
            this.borrower = borrower;
        }

        public void ReturnItem()
        {
            borrower = null;
        }

        public override void Display()
        {
            //base es para llamar al metodo de la clase padre
            base.Display();
            if(borrower != null)
            {
                Console.WriteLine("Prestado a: " + borrower + "\n");
            }
            else
            {
                Console.WriteLine("Disponible" + "\n");
            }
        }
    }
}

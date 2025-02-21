using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; }

        public Book(int bookID, string title, string author)
        {
            BookID = bookID;
            Title = title;
            Author = author;
            IsAvailable = true;
        }

        public void DisplayBookDetails()
        {
            Console.WriteLine($"BookID: {BookID}, Title: {Title}, Author: {Author}, Available: {IsAvailable}");
        }
        public void DisplayBookDetails(bool showAvailability)
        {
            if (showAvailability)
                Console.WriteLine($"BookID: {BookID}, Title: {Title}, Author: {Author}, Available: {IsAvailable}");
            else
                DisplayBookDetails();
        }
    }

    class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public int BorrowedBookID { get; set; }

        public User(int userID, string name)
        {
            UserID = userID;
            Name = name;
            BorrowedBookID = 1; 
        }

        public virtual void DisplayUserDetails()
        {
            Console.WriteLine($"UserID: {UserID}, Name: {Name}, Borrowed Book ID: {BorrowedBookID}");
        }
    }
    class PremiumUser : User
    {
        public string MembershipLevel { get; set; }

        public PremiumUser(int userID, string name, string membershipLevel) : base(userID, name)
        {
            MembershipLevel = membershipLevel;
        }

        public override void DisplayUserDetails()
        {
            Console.WriteLine($"User ID: {UserID}, Name: {Name}, Membership Level: {MembershipLevel}, Borrowed Book ID: {(BorrowedBookID == -1 ? "None" : BorrowedBookID.ToString())}");
        }
    }
    class Library
    {
        public List<Book> Books { get; set; } = new List<Book>();
        public List<User> Users { get; set; } = new List<User>();

        public void AddBook(Book book)
        {
            Books.Add(book);
            Console.WriteLine($"Book '{book.Title}' added to the library.");
        }

        public void AddUser(User user)
        {
            Users.Add(user);
            Console.WriteLine($"User '{user.Name}' registered.");
        }

        public void BorrowBook(int userID, int bookID)
        {
            User user = Users.Find(u => u.UserID == userID);
            Book book = Books.Find(b => b.BookID == bookID);

            if (user == null)
            {
                Console.WriteLine("User not found.");
                return;
            }
            if (book == null)
            {
                Console.WriteLine("Book not found.");
                return;
            }
            if (!book.IsAvailable)
            {
                Console.WriteLine("Book is already borrowed.");
                return;
            }

            book.IsAvailable = false;
            user.BorrowedBookID = bookID;
            Console.WriteLine($"User '{user.Name}' borrowed book '{book.Title}'.");
        }

        public void ReturnBook(int userID)
        {
            User user = Users.Find(u => u.UserID == userID);
            Book book = Books.Find(b => b.BookID == user.BorrowedBookID);

            if (user == null || user.BorrowedBookID == -1)
            {
                Console.WriteLine("No borrowed book found for this user.");
                return;
            }

            
            if (book != null)
            {
                book.IsAvailable = true;
                user.BorrowedBookID = -1;
                Console.WriteLine($"User '{user.Name}' returned book '{book.Title}'.");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Library library = new Library();

            Book book1 = new Book(101, "Love is Blind", "Anil Kapoor");
            Book book2 = new Book(102, "Tere Name", "Salman Khan");
            library.AddBook(book1);
            library.AddBook(book2);

            
            User user1 = new User(1, "Anklesh");
            PremiumUser user2 = new PremiumUser(2, "Baby", "Gold");
            library.AddUser(user1);
            library.AddUser(user2);

           
            Console.WriteLine("\nBook Details:");
            book1.DisplayBookDetails(true);
            book2.DisplayBookDetails(true);

           
            Console.WriteLine("\nBorrowing Books:");
            library.BorrowBook(1, 101);
            book1.DisplayBookDetails(true);

            
            Console.WriteLine("\nReturning Books:");
            library.ReturnBook(1);
            book1.DisplayBookDetails(true);

            
            Console.WriteLine("\nUser Details:");
            user1.DisplayUserDetails();
            user2.DisplayUserDetails();
            
        }
    }
}

public class Exercise2
{
    public static void Run()
    {
        Book book = new Book();
        book.author.name = "The author";
        book.title.title = "Very epic title";
        book.content.content = "Long long sentence from the book";

        book.author.Show();
        book.title.Show();
        book.content.Show();
    }
}

internal class Book
{
    public Author author = new Author();
    public Title title = new Title();
    public Content content = new Content();

    public class Author
    {
        public string name = "";

        public void Show(){
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine(name);
            Console.ResetColor();
        }
    }

    public class Title
    {
        public string title = "";

        public void Show(){
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine(title);
            Console.ResetColor();
        }
    }

    public class Content
    {
        public string content = "";

        public void Show(){
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine(content);
            Console.ResetColor();
        }
    }
}

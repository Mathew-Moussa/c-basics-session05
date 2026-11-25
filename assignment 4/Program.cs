

Book book1 = new Book();
#region q1
splitter(1);
Console.WriteLine("commented");
//Console.WriteLine(book1.password);
//'Book.password' is inaccessible due to its protection level
//not in the same class
#endregion
#region q2
splitter(2);
Console.WriteLine(book1.copiesInStock);
//yes
//same project
#endregion
#region q3
splitter(3);
book1.Title = "Title";
Console.WriteLine(book1.Title);
#endregion
#region q4
splitter(4);
Console.WriteLine(book1.genre);
#endregion
#region q5
splitter(5);
Console.WriteLine((int)Genre.Fiction);
Console.WriteLine((int)Genre.NonFiction);
Console.WriteLine((int)Genre.Science);
#endregion
#region q6
splitter(6);
int genreNumber = 1;
Console.WriteLine((Genre)genreNumber);
#endregion
#region q7
splitter(7);
Genre genre = Genre.Fiction;
Console.WriteLine(genre.ToString());
#endregion
#region q8
splitter(8);
{
    string genreText = "Science";
    Genre genreParse = Enum.Parse<Genre>(genreText);
    Console.WriteLine(genreParse);
}
#endregion
#region q9
splitter(9);
{
    string genreText = "Mystery";
    if (Enum.TryParse<Genre>(genreText, out Genre genreParse))
    {
        Console.WriteLine(genreParse);
    }
    else
    {
        Console.WriteLine("Unknown genre");
    }
}
#endregion
void splitter(int counter)
{
    Console.WriteLine($"############q{counter}############");
}
public class Book
{
    private string password = "secret";
    internal int copiesInStock = 5;
    public string Title;
    public Genre genre = Genre.Science;
}


public enum Genre { 
    Fiction,
    NonFiction,
    Science }
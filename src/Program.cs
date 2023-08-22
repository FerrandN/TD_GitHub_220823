internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Entrez votre nom");
        string nom = LireDonee();
        Console.WriteLine("Entrez votre prenom");
        string prenom = LireDonee();
        Console.WriteLine(String.Format("{0} {1}", prenom, nom));

    }

    private static string LireDonee()
    {
        string val = "";
        do
        {
            val = Console.ReadLine().Trim();
        } while (val.Equals(""));
        return val;
    }
}
using src;

public class Program
{
    public static void Main(string[] args)
    {
        //demander à l'utilisateur son nom et prénom
        Console.WriteLine("Entrez votre nom");
        string nom = LireDonee();
        Console.WriteLine("Entrez votre prenom");
        string prenom = LireDonee();
        Console.WriteLine(String.Format("{0} {1}", prenom, nom));

        //creer une personne représentant l'utilisateur
        Person myPerson = new Person(nom, prenom);
        Console.WriteLine(myPerson.Prenom);
        Console.WriteLine(myPerson.Nom);

        //ajout de l'utilisateur dans la liste
        PersonContainer myContainer = new PersonContainer();
        myContainer.AjouterPersonne(myPerson);

        //Ajout de 3 personnes dans la liste
        Person personOne = new Person("Lafrite", "Jacky");
        Person personTwo = new Person("Bouvier", "Michelle");
        Person personThree = new Person("Bounatirou", "Rodolphe");

        myContainer.AjouterPersonne(personOne);
        myContainer.AjouterPersonne(personTwo);
        myContainer.AjouterPersonne(personThree);

        //Ajout en boucle de personne dans la liste


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
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
        bool userToAdd = true;
        do
        {
            Console.WriteLine("Do you want to add a new User ? answer with y for YES and n for NO");
            string answer = LireDonee().ToLower();

            if(!answer.Equals("n") && !answer.Equals("y"))
            {
                Console.WriteLine("Wrong Answer, please answer with Y or N");
            }

            if (answer == "y")
            {
                Console.WriteLine("Entrez votre nom");
                string name = LireDonee();
                Console.WriteLine("Entrez votre prenom");
                string surname = LireDonee();
                if(myContainer.AjouterPersonne(name,surname))
                {
                    Console.WriteLine(String.Format("l'utilisateur {0} {1} a été ajouté(e)", surname, name));
                }
                else
                {
                    Console.WriteLine("L'utilisateur n'a pas été ajoutée, les valeurs sont incorrecte");
                }
            }
            else
            {
                userToAdd = false;
            }

        } while (userToAdd);

        Console.WriteLine("Do you want to save the datas ? Press y is YES");
        string userAnswer = LireDonee().ToLower();
        

        if (userAnswer.Equals("y"))
        {
            File.WriteAllText("C:\\Users\\nferrand\\Documents\\nomfichier.txt", myContainer.ExportToJSON());
        }

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
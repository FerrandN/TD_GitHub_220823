# TD_GitHub_220823
## Documentation

### Person

La classe dispose de deux attributs nom et prenom(chaine de caractères)
On peut respectivement accéder à leurs valeur en lecture via les accesseur Nom et Prenom.

Elle possède un constructeur classique uniquement prenant en premier paramètre le nom et en deuxième le prenom qui vont etre associés à l'instance

#### Liste des méthodes
##### Person(string _nom, string _prenom)

### PersonContainer (implemente IPersonContainer)

La classe permet de gérer une collection de personnes (classe Person)
On peut créer une instance de la classe de 3 façons avec une collection, un tableau (params), ou sans paramètre (laissant une collection vide).
Lorsqu'une personne est ajouté un controle est éfféctué afin de s'assurer qu'aucun duplicatat (combinaison nom+prenom) ne sois admis. (Ce controle est également appliqué dans les constructeurs).
Pour ajouter une personne on peut l'ajouter en envoyant directement une instance de personne en paramètre ou bien en envoyant un nom et un prenom sous la forme d'une personne en paramètre
(l'instance sera alors crée dynamiquement à l'éxécution de la méthode).

#### PersonContainer()
Constructeur par défaut

#### PersonContainer(List<Person> initialPersons)
Constructeur classique initialisant l'instance via la collection passée en paramètre, fait un controle de duplicata et renvoie une exception si la combinaison (nom+prenom) est présente en double

#### PersonContainer(params Person[] persons)
Constructeur classique alternatif qui permet d'ajouter des personne selon une collection params

#### bool PersonContainer.AjouterPersonne(Person person)
Ajoute la personne passée en paramètre à la collection, en cas de duplicata renvoie false sans ajout, sinon ajoute et renvoie true

#### bool PersonContainer.AjouterPersonne(string nom, string prenom)
Ajoute une personne générée dynamiquement à l'aide des deux paramètres, renvoie true si ajout ou false en cas de duplicate. fait appel à la surcharge de la méthode avec un paramètre de type Person.

#### List<Person> SortByFirstName()
Trie la collection interne de l'instance par prenom dans l'ordre alphabétique et renvoie la liste ainsi triée.

#### List<Person> SortByLastName()
Trie la collection interne de l'instance par nom dans l'ordre alphabétique et renvoie la liste ainsi triée.

#### string ExportToJSON()
Renvoie le contenu de la collection interne sous la forme d'une chaine de caractére en JSON
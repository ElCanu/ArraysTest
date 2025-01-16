namespace Exercice1B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] noms = new string[5];
            string[] prenoms = new string[5];
            char[] occupations = new char[5];
            decimal[] salaires = new decimal[5];

            string nom;
            string prenom;
            ConsoleKey occupation = ConsoleKey.None;
            decimal salaire;

            ConsoleKeyInfo input;
            bool valide = false;

            decimal somme = 0;
            decimal moyenne = 0;
            decimal salairePlusHaut = -1;
            decimal salairePlusBas = 1000000;

            decimal recherche = 0;


            while (true)
            {
                Console.WriteLine(@"
            Veuillez choisir l'une des options suivantes:
            1 - Ajouter un(e) employé(e)
            2 - Rechercher à partir d'un salaire
            3 - Afficher tout les employées
            4 - Quitter
            ");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1 or ConsoleKey.NumPad1:

                        // Validation si besoin de resize le array
                        if (!String.IsNullOrEmpty(noms[noms.Length - 1]))
                        {
                            Array.Resize(ref noms, noms.Length * 2);
                            Array.Resize(ref prenoms, prenoms.Length * 2);
                            Array.Resize(ref occupations, occupations.Length * 2);
                            Array.Resize(ref salaires, salaires.Length * 2);
                        }

                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Entrez le prénom:");
                            prenom = Console.ReadLine() ?? String.Empty;
                            valide = !string.IsNullOrEmpty(prenom);

                            if (!valide)
                            {
                                Console.Clear();
                                Console.WriteLine("Entrée invalide! Appuyez sur une touche pour recommencer...");
                                Console.ReadKey();
                            }
                        } while (!valide);

                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Entrez le nom:");
                            nom = Console.ReadLine() ?? String.Empty;
                            valide = !string.IsNullOrEmpty(nom);

                            if (!valide)
                            {
                                Console.Clear();
                                Console.WriteLine("Entrée invalide! Appuyez sur une touche pour recommencer...");
                                Console.ReadKey();
                            }
                        } while (!valide);

                        do
                        {

                            Console.Clear();
                            Console.WriteLine("Entrez l'occupation;");
                            Console.WriteLine("(A)nalyste, (P)rogrammeur et (S)ystem admin");

                            input = Console.ReadKey(true);
                            valide = input.Key == ConsoleKey.A || input.Key == ConsoleKey.P || input.Key == ConsoleKey.S;

                            if (!valide)
                            {
                                Console.Clear();
                                Console.WriteLine("Entrée invalide! Appuyez sur une touche pour recommencer...");
                                Console.ReadKey();
                            }
                        } while (!valide);

                        occupation = input.Key;

                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Entrez le salaire annuel:");
                            valide = decimal.TryParse(Console.ReadLine(), out salaire)
                                && salaire <= 999999
                                && salaire > 0;

                            if (!valide)
                            {
                                Console.Clear();
                                Console.WriteLine("Entrée invalide! Appuyez sur une touche pour recommencer...");
                                Console.ReadKey();
                            }
                        } while (!valide);

                        break;
                    case ConsoleKey.D2 or ConsoleKey.NumPad2:

                        break;
                    case ConsoleKey.D3 or ConsoleKey.NumPad3:

                        break;
                    case ConsoleKey.D4 or ConsoleKey.NumPad4:

                        break;
                    default:
                        Console.WriteLine("Entrée invalide! Appuyez sur une touche pour recommencer...");
                        break;
                }
            }

            
            


            

        }
    }
}

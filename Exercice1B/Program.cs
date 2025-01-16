namespace Exercice1B;

internal class Program
{
    static void Main(string[] args)
    {
        string[] noms = new string[5];
        string[] prenoms = new string[5];
        ConsoleKey[] occupations = new ConsoleKey[5];
        decimal[] salaires = new decimal[5];

        string nom;
        string prenom;
        ConsoleKey occupation = ConsoleKey.None;
        decimal salaire;

        ConsoleKeyInfo input;
        bool valide = false;

        decimal somme = 0;
        decimal moyenne = 0;
        decimal salaireLePlusHaut = -1;
        decimal salaireLePlusBas = 1000000;
        int indexSalaireHaut = -1;
        int indexSalaireBas = -1;

        decimal recherche = 0;
        int nbEmploye = 0;




        while (true)
        {
            Console.Clear();
            Console.WriteLine(@"
            Veuillez choisir l'une des options suivantes:
            1 - Ajouter un(e) employé(e)
            2 - Rechercher à partir d'un salaire
            3 - Afficher tout les employées et statistiques
            4 - Quitter
            ");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1 or ConsoleKey.NumPad1: // Ajouter un(e) employé(e)

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

                    for (int i = 0, taille = noms.Length; i < taille; ++i)
                    {
                        if (String.IsNullOrEmpty(noms[i]))
                        {
                            prenoms[i] = prenom;
                            noms[i] = nom;
                            occupations[i] = occupation;
                            salaires[i] = salaire;
                            break;
                        }
                    }

                    break;
                case ConsoleKey.D2 or ConsoleKey.NumPad2: //Rechercher à partir d'un salaire

                    break;
                case ConsoleKey.D3 or ConsoleKey.NumPad3: //Afficher tout les employées et statistiques

                    Console.Clear();
                    Console.WriteLine($"{"#",-5}|{"Prénom",-12}|{"Nom",-12}|{"Occupation",-12}|{"Salaire",-12}");
                    for (int i = 0, taille = noms.Length; i < taille; ++i)
                    {
                        if (!String.IsNullOrEmpty(noms[i]))
                        {
                            Console.WriteLine($"{i,-5}|{prenoms[i],-12}|{noms[i],-12}|{occupations[i],-12}|{salaires[i],-12}");
                            somme += salaires[i];
                            nbEmploye++;

                            if (salaires[i] < salaireLePlusBas)
                            {
                                salaireLePlusBas = salaires[i];
                                indexSalaireBas = i;
                            }
                            if (salaires[i] > salaireLePlusHaut)
                            {
                                salaireLePlusHaut = salaires[i];
                                indexSalaireHaut = i;
                            }

                        }

                    }
                    try
                    {
                        moyenne = somme / nbEmploye;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                        Console.WriteLine("Appuyez sur une touche pour recommencer...");
                        Console.ReadKey();
                        break;
                    }
                    Console.WriteLine(@$"
            Somme des salaires  : {somme:C}
            Moyenne des salaires: {moyenne:C}
            Salaire le plus haut: {salaireLePlusHaut} ({prenoms[indexSalaireHaut]} {noms[indexSalaireHaut]})
            Salaire le plus bas : {salaireLePlusBas} ({prenoms[indexSalaireBas]} {noms[indexSalaireBas]})
                    ");

                    Console.WriteLine("Appuyez sur une touche pour retourner au menu principale...");
                    Console.ReadKey();

                    break;
                case ConsoleKey.D4 or ConsoleKey.NumPad4: //Quit
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Entrée invalide! Appuyez sur une touche pour recommencer...");
                    break;
            }
        }
    }
}

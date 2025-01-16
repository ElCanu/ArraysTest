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

        }
    }
}

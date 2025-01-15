namespace Excercice1A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] noms = new string[5];
            string[] prenoms = new string[5];
            float[] notesTp1 = new float[5];
            float[] notesTp2 = new float[5];
            float[] notesIntra = new float[5];
            float[] notesFinal = new float[5];

            bool valide;
            

            string nom;
            string prenom;
            float noteTp1;
            float noteTp2;
            float noteIntra;
            float noteFinal;

            

            // Validation si besoin de resize le array
            if (!String.IsNullOrEmpty(noms[noms.Length - 1]))
            {
                Array.Resize(ref noms, noms.Length * 2);
                Array.Resize(ref prenoms, prenoms.Length * 2);
                Array.Resize(ref notesTp1, notesTp1.Length * 2);
                Array.Resize(ref notesTp2, notesTp2.Length * 2);
                Array.Resize(ref notesIntra, notesIntra.Length * 2);
                Array.Resize(ref notesFinal, notesFinal.Length * 2);
            }

            do
            {
                Console.Clear();
                Console.WriteLine("Entrez prenom étudiant:");
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
                Console.WriteLine("Entrez nom étudiant:");
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
                Console.WriteLine("Entrez note du TP1:");
                valide = float.TryParse(Console.ReadLine(), out noteTp1)
                    && noteTp1 <= 100
                    && noteTp1 > 0;

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
                Console.WriteLine("Entrez note du TP2:");
                valide = float.TryParse(Console.ReadLine(), out noteTp2)
                    && noteTp2 <= 100
                    && noteTp2 > 0;

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
                Console.WriteLine("Entrez note de l'intra:");
                valide = float.TryParse(Console.ReadLine(), out noteIntra)
                    && noteIntra <= 100
                    && noteIntra > 0;

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
                Console.WriteLine("Entrez note de l'exam final:");
                valide = float.TryParse(Console.ReadLine(), out noteFinal)
                    && noteFinal <= 100
                    && noteFinal > 0;

                if (!valide)
                {
                    Console.Clear();
                    Console.WriteLine("Entrée invalide! Appuyez sur une touche pour recommencer...");
                    Console.ReadKey();
                }
            } while (!valide);

            // ajout des donnes saisi à la première place disponible
            for (int i = 0, taille = noms.Length; i < taille; ++i)
            {
                if (String.IsNullOrEmpty(noms[i]))
                {
                    prenoms[i] = prenom;
                    noms[i] = nom;
                    notesTp1[i] = noteTp1;
                    notesTp2[i] = noteTp2;
                    notesIntra[i] = noteIntra;
                    notesFinal[i] = noteFinal;
                    break;
                }
            }

            //affichage des donnes (debug) en boucle pour etre ready pour plustard 
            Console.Clear();
            Console.WriteLine($"{"#", -5}|{"Prénom", -12}|{"Noms", -12}|{"TP1", -8}|{"TP2", -8}|{"Intra", -7}|{"Final", -7}");
            for (int i = 0, taille = noms.Length; i < taille; ++i)
            {
                Console.WriteLine($"{i, -5}|{prenoms[i], -12}|{noms[i], -12}|{notesTp1[i], -8}|{notesTp2[i], -8}|{notesIntra[i], -7}|{notesFinal[i], -7}");
            }
                

        }
    }
}

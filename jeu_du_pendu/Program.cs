using System;
using System.Transactions;

namespace jeu_du_pendu
{
    class Program
    {

        static void AfficherMot(string mot, List<char> lettres)
        {
            // _ _ _ _ _ _ _ _
            for (int i = 0; i < mot.Length; i++)
            {
                if (lettres.Contains(mot[i]))
                {
                    Console.Write(mot[i] + " ");
                }
                else
                {
                    Console.Write("_ ");
                }
                
            }
            Console.WriteLine();
        }

        static char DemanderUneLettre()
        {
            // Rentrez une lettre
            // ERREUR : vous devez rentrez une seule lettre
            // retrun -> majuscules (ToUpper)
            
            while (true)
            {
                Console.Write("Rentrez une lettre : ");
                string reponse = Console.ReadLine();
                reponse = reponse.ToUpper();
                try
                {
                    char lettre = char.Parse(reponse);
                    return lettre;
                }
                catch
                {
                    Console.WriteLine("ERREUR : vous devez rentrez une seule lettre");
                }
            }
            

        }

        static void DevinerMot(string mot)
        {
            ///

            // _ _ _ _
            // E _ _ E _ _
            AfficherMot(mot, new List<char> { 'E','P'});

            DemanderUneLettre();
        }
        static void Main(string[] args)
        {
            string mot = "ELEPHANT";
            DevinerMot(mot);

        }
    }
}
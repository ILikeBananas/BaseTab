using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseTab
{
    class Program
    {
        public enum OptionMenu {
            ValMax,
            NbreColonne,
            NbreValeur,
            GenererValeur,
            AfficherValeur,
            Quitter,
            invalid
        }

        static int ValeurMax = 100;
        static int NbreColonne = 5;
        static int NbreValeur = 20;

        static void Main(string[] args)
        {
            OptionMenu optionMenu = OptionMenu.invalid;

            do
            {
                optionMenu = Menu();

                switch(optionMenu)
                {
                    case OptionMenu.ValMax:
                        ChangerValeurMax();
                        break;

                    case OptionMenu.NbreColonne:
                        ChangerNombreColonne();
                        break;
                }
            } while (optionMenu != OptionMenu.Quitter);
            

        }

        /// <summary>
        /// Affiche le menu dans lequel l'utilisateur choisira le menu dans lequel il veut aller
        /// </summary>
        /// <returns></returns>
        static public OptionMenu Menu()
        {
            OptionMenu optionMenu = OptionMenu.invalid;

            do
            {
                // Affichage du menu
                Console.Clear();
                Console.WriteLine("_________________________________________________________");
                Console.WriteLine("                    *** Menu ***                         ");
                Console.WriteLine("_________________________________________________________");
                Console.WriteLine("");
                Console.WriteLine(string.Format(" a) Valeur maximum pouvant être générée \t [{0}]", Program.ValeurMax));
                Console.WriteLine(string.Format(" b) Nombre de colonnes de l'affichage \t\t [{0}]", Program.NbreColonne));
                Console.WriteLine(string.Format(" c) Quantité de valeurs à générer \t\t [{0}]",     Program.NbreValeur));
                Console.WriteLine(              " d) Génération des valeurs aléatoires");
                Console.WriteLine(              " e) Affichage des valeurs");
                Console.Write("\n\n");
                Console.WriteLine(              " q) Quitter");
                Console.WriteLine("_________________________________________________________");
                Console.Write(    "Votre choix :");

                string choix = Console.ReadLine();

                switch (choix)
                {
                    case "a":
                        optionMenu = OptionMenu.ValMax;
                        break;

                    case "b":
                        optionMenu = OptionMenu.NbreColonne;
                        break;

                    case "c":
                        optionMenu = OptionMenu.NbreValeur;
                        break;

                    case "d":
                        optionMenu = OptionMenu.GenererValeur;
                        break;

                    case "e":
                        optionMenu = OptionMenu.AfficherValeur;
                        break;

                    case "q":
                        optionMenu = OptionMenu.Quitter;
                        break;

                    default:
                        optionMenu = OptionMenu.invalid;
                        break;
                }
            } while (optionMenu == OptionMenu.invalid);

            return optionMenu;
        }

        /// <summary>
        /// Demande et change la valeur maximale à générée
        /// </summary>
        static void ChangerValeurMax()
        {
            bool saisieInvalide = true;
            int nombreSaisi = 0;
            do
            {
                Console.Write("Valeur maximum pouvant être générée (minimum 1): ");
                string saisie = Console.ReadLine();
                Int32.TryParse(saisie, out nombreSaisi);

                saisieInvalide = nombreSaisi < 1;

            } while (saisieInvalide);

            ValeurMax = nombreSaisi;
        }

        
        static void ChangerNombreColonne()
        {
            bool saisieInvalide = true;
            int nombreSaisi = 0;

            do
            {
                Console.Write("Nombre de colonne à générer (1-15):");
                string saisie = Console.ReadLine();
                Int32.TryParse(saisie, out nombreSaisi);

                saisieInvalide = nombreSaisi < 1 || nombreSaisi > 15;
            } while (saisieInvalide);

            NbreColonne = nombreSaisi;
        }
        



    }
}

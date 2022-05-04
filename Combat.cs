using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Heroes
{
    class Combat
    {
        public Compagnie CompagnieJoueur { get; set; }
        public Compagnie CompagnieEnnemi { get; set; }
        public Heros HeroPrincipalJoueur { get; set; }
        public Heros HeroPrincipalEnnemi { get; set; }

        public int NumHeroPrincipalJoueur { get; set; } = 1;
        public int NumHeroPrincipalEnnemi { get; set; } = 1;
        public int NbHeroRestantJoueur { get; set; } = 3;
        public int NbHeroRestantEnnemi { get; set; } = 3;

        public int NumActionEnnemi { get; set; }

        public List<string> ActionsEnnemi { get; set; } = new List<string>();
 

        bool defenseEnnemi = false;
        bool defenseJoueur = false;
        
        Random rnd = new Random();

        int nbActionJoueur;
        
        List<Heros> listeHeros = new List<Heros>();

        public Combat()
        {
            ActionsEnnemi.Add("Defense");
            ActionsEnnemi.Add("Attaque");
            ActionsEnnemi.Add("Mouvement");
        }

        public void Attaque(bool actionJoueur)
        {
            if (actionJoueur)
            {
                if (defenseEnnemi)
                {
                    HeroPrincipalEnnemi.NvVie -= Convert.ToInt32(HeroPrincipalJoueur.Attaque / 2);
                }
                else
                {
                    HeroPrincipalEnnemi.NvVie -= HeroPrincipalJoueur.Attaque;
                }
                if (HeroPrincipalEnnemi.NvVie <= 0)
                {
                    HeroMort(HeroPrincipalEnnemi);
                }
            }
            else
            {
                if (defenseJoueur)
                {
                    HeroPrincipalJoueur.NvVie -= Convert.ToInt32(HeroPrincipalEnnemi.Attaque / 2);
                }
                else
                {
                    HeroPrincipalJoueur.NvVie -= HeroPrincipalEnnemi.Attaque;
                }
                if (HeroPrincipalJoueur.NvVie <= 0)
                {
                    HeroMort(HeroPrincipalJoueur);
                }
            }
            defenseJoueur = false;
            defenseEnnemi = false;
        }

        public void Defense(bool joueur)
        {
            if (joueur)
            {
                defenseJoueur = true;
            }
            else
            {
                defenseEnnemi = true;
            }
            
        }
        public void Mouvement(bool actionJoueur)
        {
            if (actionJoueur)
            {
                NumHeroPrincipalJoueur += 1;
                numHeroVerif();
                HeroPrincipalJoueur = CompagnieJoueur.Heros[NumHeroPrincipalJoueur - 1];
                //Hero mort
                while (HeroPrincipalJoueur.NvVie <= 0)
                {
                    NumHeroPrincipalJoueur += 1;
                    numHeroVerif();
                    HeroPrincipalJoueur = CompagnieJoueur.Heros[NumHeroPrincipalJoueur - 1];
                }
            }
            else
            {
                NumHeroPrincipalEnnemi += 1;
                numHeroVerif();
                HeroPrincipalEnnemi = CompagnieJoueur.Heros[NumHeroPrincipalEnnemi - 1];
                //Hero mort
                while (HeroPrincipalEnnemi.NvVie <= 0)
                {
                    NumHeroPrincipalEnnemi += 1;
                    numHeroVerif();
                    HeroPrincipalEnnemi = CompagnieEnnemi.Heros[NumHeroPrincipalEnnemi - 1];
                }
            }
            defenseJoueur = false;
            defenseEnnemi = false;
        }
        public void CapaciteSpecial()
        {

        }
        public void FinDeTour()
        {
            TourEnnemi();
        }
        public void numHeroVerif()
        {
            if (NumHeroPrincipalJoueur > 3)
            {
                NumHeroPrincipalJoueur = 1;
            }
            else if (NumHeroPrincipalEnnemi > 3)
            {
                NumHeroPrincipalEnnemi = 1;
            }
        }
        public void TourEnnemi()
        {
            NumActionEnnemi = rnd.Next(0, 3);
            if (ActionsEnnemi[NumActionEnnemi] == "Defense")
            {
                Defense(false);
            }
            else if (ActionsEnnemi[NumActionEnnemi] == "Attaque")
            {
                Attaque(false);
            }
            else
            {
                Mouvement(false);
            }
        }
        public void HeroMort(Heros heroMort)
        {
            if (heroMort == HeroPrincipalJoueur)
            {
                NbHeroRestantJoueur -= 1;
            }
            else
            {
                NbHeroRestantEnnemi -= 1;
            }
        }
        public void Commencer()
        {
            CompagnieEnnemi = CreationCompagnieEnnemi();

            HeroPrincipalJoueur = CompagnieJoueur.Heros[NumHeroPrincipalJoueur - 1];
            HeroPrincipalEnnemi = CompagnieEnnemi.Heros[NumHeroPrincipalEnnemi - 1];
        }
        public void CompagnieJoueurInit(Compagnie compagnie)
        {
            CompagnieJoueur = compagnie;
        }

        public Compagnie CreationCompagnieEnnemi()
        {
            Compagnie compagnieEnnemi = new Compagnie();
            compagnieEnnemi.InitListeArmes();
            List<Heros> herosEnnemi = new List<Heros>();
            Tenue tenue1 = new Tenue();
            Tenue tenue2 = new Tenue();
            Tenue tenue3 = new Tenue();
            Heros ennemi1 = new Heros();
            Heros ennemi2 = new Heros();
            Heros ennemi3 = new Heros();
            

            ennemi1.Ennemi1("Ennemi 1");
            ennemi2.Ennemi2("Ennemi 2");
            ennemi3.Ennemi3("Ennemi 3");

            ennemi1.Tenue = tenue1.majTenue("metal");
            ennemi2.Tenue = tenue2.majTenue("cuir");
            ennemi3.Tenue = tenue3.majTenue("tissu");

            ennemi1.Arme1 = compagnieEnnemi.DicoListeArmes["epee"].arme;
            ennemi1.Arme2 = compagnieEnnemi.DicoListeArmes["dague"].arme;

            ennemi2.Arme1 = compagnieEnnemi.DicoListeArmes["arc"].arme;
            ennemi2.Arme2 = compagnieEnnemi.DicoListeArmes["arc"].arme;

            ennemi3.Arme1 = compagnieEnnemi.DicoListeArmes["lance"].arme;
            ennemi3.Arme2 = compagnieEnnemi.DicoListeArmes["bouclier"].arme;

            ennemi1.ImageHero = Properties.Resources.Orc_Warriors_Armor_Shield;
            ennemi2.ImageHero = Properties.Resources.OrcArcherCuir;
            ennemi3.ImageHero = Properties.Resources.OrcArcherCuir;


            ennemi1 = Extension.TraitementHeros(ennemi1.Arme1, ennemi1.Arme2, ennemi1.Tenue, ennemi1);
            ennemi2 = Extension.TraitementHeros(ennemi2.Arme1, ennemi1.Arme2, ennemi2.Tenue, ennemi2);
            ennemi3 = Extension.TraitementHeros(ennemi3.Arme1, ennemi1.Arme2, ennemi3.Tenue, ennemi3);

            herosEnnemi.Add(ennemi1);
            herosEnnemi.Add(ennemi2);
            herosEnnemi.Add(ennemi3);

            compagnieEnnemi.Heros = herosEnnemi;
            compagnieEnnemi.majNom("Ennemi");
            return compagnieEnnemi;
        }

    }
}

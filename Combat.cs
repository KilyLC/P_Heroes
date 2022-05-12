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
        public int NbCapaciteSpecialJoueur { get; set; } = 3;
        public int NbCapaciteSpecialEnnemi { get; set; } = 3;
        public int NumActionEnnemi { get; set; }

        public List<string> ActionsEnnemi { get; set; } = new List<string>();
        List<string> capaciteSpecialListe = new List<string>();

        const int NB_HEROS_MAX = 3;

        const int AGILITE_MAX = 100;

        const int PV_REGENERATION = 80;

        Random rnd = new Random();

        int nbActionJoueur = 1;

        public Combat()
        {
            //init actions ennemi
            ActionsEnnemi.Add("Defense");
            ActionsEnnemi.Add("Attaque");
            ActionsEnnemi.Add("Mouvement");
            ActionsEnnemi.Add("Capacite Speciale");
        }

        public void Attaque(Heros heroAttaquant, Heros heroDefenseur)
        {
            int degatsTotaux = 0;
            int multiplicateurAttaque = 1;
            int nbRandom = rnd.Next(0, AGILITE_MAX + 1);
            //esquive
            if (heroDefenseur.Agilite > nbRandom)
            {
                return;
            }
            //critique
            if (nbRandom == 100)
            {
                multiplicateurAttaque = 2;
            }
            degatsTotaux = heroAttaquant.Degats() * multiplicateurAttaque;
            heroDefenseur.PerteVie(degatsTotaux);
            heroDefenseur.Defense = false;
        }

        public void Defense(Heros hero)
        {
            hero.Defense = true;
        }
        public void Mouvement(bool actionJoueur)
        {
            if (actionJoueur)
            {
                ChangementHero(actionJoueur);
                //Hero mort
                while (HeroPrincipalJoueur.Vivant == false)
                {
                    ChangementHero(actionJoueur);
                }
            }
            else
            {
                ChangementHero(actionJoueur);
                //Hero mort
                while (HeroPrincipalEnnemi.NvVie <= 0)
                {
                    ChangementHero(actionJoueur);
                }
            }
        }

        public void ChangementHero(bool joueur)
        {
            if (joueur)
            {
                //changement hero joueur
                NumHeroPrincipalJoueur++;
                numHeroVerif();
                HeroPrincipalJoueur = CompagnieJoueur.Heros[NumHeroPrincipalJoueur - 1];
            }
            else
            {
                //changement hero ennemi
                NumHeroPrincipalEnnemi++;
                numHeroVerif();
                HeroPrincipalEnnemi = CompagnieEnnemi.Heros[NumHeroPrincipalEnnemi - 1];
            }

        }
        public void CapaciteSpecial(Heros heroAction, Heros heroSubi)
        {
            if (HeroPrincipalJoueur == heroAction)
            {
                NbCapaciteSpecialJoueur--;
            }
            else
            {
                NbCapaciteSpecialEnnemi--;
            }
            foreach (string item in capaciteSpecialListe)
            {
                if (item == heroAction.CapaciteSpecial)
                {
                    //defense
                    if (item == capaciteSpecialListe[0])
                    {
                        heroAction.DefenseSpeciale = true;
                    }
                    //attaque
                    else if (item == capaciteSpecialListe[1])
                    {
                        heroSubi.NvVie -= heroAction.Degats() * 2;
                    }
                    //régenération
                    else
                    {
                        heroAction.NvVie += PV_REGENERATION;
                    }
                }
            }
        }
        public void FinDeTour()
        {
            TourEnnemi();
        }
        public void numHeroVerif()
        {
            if (NumHeroPrincipalJoueur > NB_HEROS_MAX)
            {
                NumHeroPrincipalJoueur = 1;
            }
            else if (NumHeroPrincipalEnnemi > NB_HEROS_MAX)
            {
                NumHeroPrincipalEnnemi = 1;
            }
        }
        public void TourEnnemi()
        {
            if (ActionsEnnemi.Count == 2)
            {
                NumActionEnnemi = rnd.Next(0, 2);
            }
            else if (ActionsEnnemi.Count == 3)
            {
                NumActionEnnemi = rnd.Next(0, 3);
            }
            else
            {
                NumActionEnnemi = rnd.Next(0, 4);
            }
            if (ActionsEnnemi[NumActionEnnemi] == "Defense")
            {
                Defense(HeroPrincipalEnnemi);
            }
            else if (ActionsEnnemi[NumActionEnnemi] == "Attaque")
            {
                Attaque(HeroPrincipalEnnemi, HeroPrincipalJoueur);
            }
            else if (ActionsEnnemi[NumActionEnnemi] == "Mouvement")
            {
                Mouvement(false);
            }
            else
            {
                CapaciteSpecial(HeroPrincipalEnnemi, HeroPrincipalJoueur);
            }

        }
        public void HeroMort(Heros heroMort)
        {
            if (heroMort == HeroPrincipalJoueur)
            {
                NbHeroRestantJoueur--;
                if (NbHeroRestantJoueur >= 1)
                {
                    Mouvement(true);
                }
            }
            else
            {
                NbHeroRestantEnnemi--;
                if (NbHeroRestantEnnemi >= 1)
                {
                    Mouvement(false);
                }
            }
            heroMort.Vivant = false;
            heroMort.NvVie = 0;
        }

        public bool Gagne()
        {
            //Victoire
            if (NbHeroRestantEnnemi == 0)
            {
                return true;
            }
            return false;
        }
        public bool Perdu()
        {
            //Defaite
            if (NbHeroRestantJoueur == 0)
            {
                return true;
            }
            return false;
        }
        public void FinCombat()
        {
            if (Gagne())
            {
                //Gagne Exp
                //Gagne argent
            }
            else if (Perdu())
            {

            }
        }
        public void Commencer()
        {
            //init compagnie ennemi
            CompagnieEnnemi = CreationCompagnieEnnemi();

            //Heros principal pour chaque compagnie
            HeroPrincipalJoueur = CompagnieJoueur.Heros[NumHeroPrincipalJoueur - 1];
            HeroPrincipalEnnemi = CompagnieEnnemi.Heros[NumHeroPrincipalEnnemi - 1];
            //init capacités spéciales
            capaciteSpecialListe.Add("defense");
            capaciteSpecialListe.Add("attaque");
            capaciteSpecialListe.Add("regeneration");
        }
        public void CompagnieJoueurInit(Compagnie compagnie)
        {
            CompagnieJoueur = compagnie;
        }
        public Compagnie CreationCompagnieEnnemi()
        {
            Compagnie compagnieEnnemi = new Compagnie();
            //compagnieEnnemi.InitListeArmes();
            List<Heros> herosEnnemi = new List<Heros>();
            //tenue
            Tenue tenue1 = new Tenue();
            Tenue tenue2 = new Tenue();
            Tenue tenue3 = new Tenue();
            //heros
            Heros ennemi1 = new Heros();
            Heros ennemi2 = new Heros();
            Heros ennemi3 = new Heros();
            //nom hero
            /*ennemi1.Ennemi1("Ennemi 1");
            ennemi2.Ennemi2("Ennemi 2");
            ennemi3.Ennemi3("Ennemi 3");*/
            //choix tenue
            /*ennemi1.Tenue = ;
            ennemi2.Tenue = ;
            ennemi3.Tenue = ;*/
            //arme ennemi 1
            ennemi1.Arme1 = compagnieEnnemi.DicoListeArmes["epee"].arme;
            ennemi1.Arme2 = compagnieEnnemi.DicoListeArmes["dague"].arme;
            //arme ennemi 2
            ennemi2.Arme1 = compagnieEnnemi.DicoListeArmes["arc"].arme;
            ennemi2.Arme2 = compagnieEnnemi.DicoListeArmes["arc"].arme;
            //arme ennemi 3
            ennemi3.Arme1 = compagnieEnnemi.DicoListeArmes["lance"].arme;
            ennemi3.Arme2 = compagnieEnnemi.DicoListeArmes["bouclier"].arme;
            //Image ennemi
            ennemi1.ImageHero = Properties.Resources.Orc_Warriors_Armor_Shield;
            ennemi2.ImageHero = Properties.Resources.OrcArcherCuir;
            ennemi3.ImageHero = Properties.Resources.OrcArcherCuir;

            //traitement de l'heros
           /* ennemi1 = ennemi1.TraitementHeros(ennemi1.Arme1, ennemi1.Arme2, ennemi1.Tenue, ennemi1);
            ennemi2 = ennemi2.TraitementHeros(ennemi2.Arme1, ennemi1.Arme2, ennemi2.Tenue, ennemi2);
            ennemi3 = ennemi3.TraitementHeros(ennemi3.Arme1, ennemi1.Arme2, ennemi3.Tenue, ennemi3);*/
            //ajout dans la compagnie
            herosEnnemi.Add(ennemi1);
            herosEnnemi.Add(ennemi2);
            herosEnnemi.Add(ennemi3);

            compagnieEnnemi.Heros = herosEnnemi;
            //nom compagnie
            compagnieEnnemi.majNom("Ennemi");
            return compagnieEnnemi;
        }
    }
}

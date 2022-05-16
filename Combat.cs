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

        public void RecupVie()
        {
            CompagnieJoueur.Heros[0].NvVie = CompagnieJoueur.HerosBase[0].NvVie;
            CompagnieJoueur.Heros[1].NvVie = CompagnieJoueur.HerosBase[1].NvVie;
            CompagnieJoueur.Heros[2].NvVie = CompagnieJoueur.HerosBase[2].NvVie;
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
            const int NV_VIE = 1000;
            const int AGILITE_BASE = 30;
            const int ATTAQUE_BASE = 40;
            const int AJOUT_ENNEMI2 = 10;
            const int AJOUT_ENNEMI3 = 10;
            Compagnie compagnieEnnemi = new Compagnie();

            List<Heros> herosEnnemi = new List<Heros>();
            //tenue
            Tenue tenue1 = new Tenue();
            Tenue tenue2 = new Tenue();
            Tenue tenue3 = new Tenue();

            tenue1.CreeTenue("lourde", 30, 35, null);
            tenue1.CreeTenue("moyenne", 20, 30, null);
            tenue1.CreeTenue("legere", 10, 15, null);
            //heros
            Heros ennemi1 = new Heros();
            Heros ennemi2 = new Heros();
            Heros ennemi3 = new Heros();

            ennemi1.CreeHero(NV_VIE, AGILITE_BASE, ATTAQUE_BASE, "ennemi 1", null, true, compagnieEnnemi, "regeneration");
            ennemi2.CreeHero(NV_VIE, AGILITE_BASE + AJOUT_ENNEMI2, ATTAQUE_BASE + AJOUT_ENNEMI2, "ennemi 2", null, true, compagnieEnnemi, "attaque");
            ennemi3.CreeHero(NV_VIE, AGILITE_BASE + AJOUT_ENNEMI3, ATTAQUE_BASE + AJOUT_ENNEMI3, "ennemi 3", null, true, compagnieEnnemi, "defense");
            
            //Creation armes ennemis
            Arme hache = new Arme();
            hache.CreeArme(100, 25, 40, "hache", null, 2);

            Arme lance = new Arme();
            lance.CreeArme(100, 10, 20, "lance", null, 1);

            Arme epee = new Arme();
            epee.CreeArme(100, 10, 20, "epee", null, 1);

            Arme arc = new Arme();
            arc.CreeArme(100, 25, 40, "arc", null, 2);

            Arme dague = new Arme();
            dague.CreeArme(100, 10, 20, "dague", null, 1);

            Arme bouclier = new Arme();
            bouclier.CreeArme(100, 10, 20, "bouclier", null, 1);

            //arme et tenue  ennemi 1
            ennemi1.Arme1 = dague;
            ennemi1.Arme2 = epee;
            ennemi1.Tenue = tenue2;
            //arme et tenue ennemi 2
            ennemi2.Arme1 = arc;
            ennemi2.Arme2 = arc;
            ennemi2.Tenue = tenue3;
            //arme et tenue ennemi 3
            ennemi3.Arme1 = lance;
            ennemi3.Arme2 = bouclier;
            ennemi3.Tenue = tenue1;

            //Image ennemi
            ennemi1.ImageHero = Properties.Resources.Orc_Warriors_Armor_Shield;
            ennemi2.ImageHero = Properties.Resources.OrcArcherCuir;
            ennemi3.ImageHero = Properties.Resources.OrcArcherCuir;

            //Traitement des stats
            ennemi1.TraitementStats(ennemi1.Arme1, ennemi1.Arme2, ennemi1.Tenue, ennemi1);
            ennemi2.TraitementStats(ennemi2.Arme1, ennemi2.Arme2, ennemi2.Tenue, ennemi2);
            ennemi3.TraitementStats(ennemi3.Arme1, ennemi3.Arme2, ennemi3.Tenue, ennemi3);
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

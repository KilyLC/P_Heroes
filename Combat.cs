﻿using System;
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
        public int NbPoCombatGagnerBase { get; set; } = 100;
        public int NbPoCombatPerduBase { get; set; } = 30;
        public int NbXpCombatGagneBase { get; set; } = 300;
        public int NbXpCombatPerduBase { get; set; } = 20;

        public List<string> ActionsEnnemi { get; set; } = new List<string>();
        List<string> capaciteSpecialListe = new List<string>();

        const int NB_HEROS_MAX = 3;

        const int AGILITE_MAX = 100;

        const int PV_REGENERATION = 80;

        int pvHero1Base;
        int pvHero2Base;
        int pvHero3Base;

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
            CompagnieJoueur.Heros[0].NvVie = pvHero1Base;
            CompagnieJoueur.Heros[1].NvVie = pvHero2Base;
            CompagnieJoueur.Heros[2].NvVie = pvHero3Base;
            CompagnieJoueur.Heros[0].Vivant = true;
            CompagnieJoueur.Heros[1].Vivant = true;
            CompagnieJoueur.Heros[2].Vivant = true;
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
                CompagnieJoueur.Xp += NbXpCombatGagneBase;
                CompagnieJoueur.Po += NbPoCombatGagnerBase;
                CompagnieJoueur.NivCampagne++;
                VerifNiveau();
                return true;
            }
            return false;
        }
        public bool Perdu()
        {
            //Defaite
            if (NbHeroRestantJoueur == 0)
            {
                CompagnieJoueur.Xp += NbXpCombatPerduBase;
                CompagnieJoueur.Po += NbPoCombatPerduBase;
                VerifNiveau();
                return true;
            }
            return false;
        }

        public void VerifNiveau()
        {
            if (CompagnieJoueur.Xp >= CompagnieJoueur.NbXpPalierNiveau)
            {
                int xp_diff = CompagnieJoueur.Xp - CompagnieJoueur.NbXpPalierNiveau;
                //maj palier
                CompagnieJoueur.NbXpPalierNiveau += CompagnieJoueur.NbXpPalierNiveau;
                //maj niveau
                CompagnieJoueur.Niveau++;
                //maj xp
                CompagnieJoueur.Xp = xp_diff;
            }
        }

        public void Commencer()
        {
            //init compagnie ennemi
            CompagnieEnnemi = CreationCompagnieEnnemi();

            pvHero1Base = CompagnieJoueur.Heros[0].NvVie;
            pvHero2Base = CompagnieJoueur.Heros[1].NvVie;
            pvHero3Base = CompagnieJoueur.Heros[2].NvVie;

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
            //Ennemi base
            const int NV_VIE_BASE = 1000;
            const int AGILITE_BASE = 30;
            const int ATTAQUE_BASE = 40;
            const int AJOUT_ENNEMI2 = 10;
            const int AJOUT_ENNEMI3 = 5;
            //Modif selon niveau campagne
            //Agilite, Attaque
            const int NV_2 = 5;
            const int NV_3 = 10;
            const int NV_4 = 15;
            const int NV_5 = 20;
            const int NV_6 = 30;
            const int NV_7 = 40;
            const int NV_8 = 50;
            const int NV_9 = 60;
            const int NV_10 = 100;
            //Vie
            const int NV_2_VIE = 50;
            const int NV_3_VIE = 100;
            const int NV_4_VIE = 150;
            const int NV_5_VIE = 200;
            const int NV_6_VIE = 300;
            const int NV_7_VIE = 400;
            const int NV_8_VIE = 500;
            const int NV_9_VIE = 600;
            const int NV_10_VIE = 1000;

            //stat ennemi init
            int agiliteEnnemi1;
            int vieEnnemi1;
            int attaqueEnnemi1;
            int agiliteEnnemi2;
            int vieEnnemi2;
            int attaqueEnnemi2;
            int agiliteEnnemi3;
            int vieEnnemi3;
            int attaqueEnnemi3;

            //niveau campagne
            int nvCampagne = CompagnieJoueur.NivCampagne;

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

            agiliteEnnemi1 = AGILITE_BASE;
            agiliteEnnemi2 = AGILITE_BASE + AJOUT_ENNEMI2;
            agiliteEnnemi3 = AGILITE_BASE + AJOUT_ENNEMI3;
            vieEnnemi1 = NV_VIE_BASE;
            vieEnnemi2 = NV_VIE_BASE + AJOUT_ENNEMI2;
            vieEnnemi3 = NV_VIE_BASE + AJOUT_ENNEMI3;
            attaqueEnnemi1 = ATTAQUE_BASE;
            attaqueEnnemi2 = ATTAQUE_BASE + AJOUT_ENNEMI2;
            attaqueEnnemi3 = ATTAQUE_BASE + AJOUT_ENNEMI3;

            if (nvCampagne == 2)
            {
                agiliteEnnemi1 += NV_2;
                agiliteEnnemi2 += NV_2;
                agiliteEnnemi3 += NV_2;
                vieEnnemi1 += NV_2_VIE;
                vieEnnemi2 += NV_2_VIE;
                vieEnnemi3 += NV_2_VIE;
                attaqueEnnemi1 += NV_2;
                attaqueEnnemi2 += NV_2;
                attaqueEnnemi3 += NV_2;

            }
            else if (nvCampagne == 3)
            {
                agiliteEnnemi1 += NV_3;
                agiliteEnnemi2 += NV_3;
                agiliteEnnemi3 += NV_3;
                vieEnnemi1 += NV_3_VIE;
                vieEnnemi2 += NV_3_VIE;
                vieEnnemi3 += NV_3_VIE;
                attaqueEnnemi1 += NV_3;
                attaqueEnnemi2 += NV_3;
                attaqueEnnemi3 += NV_3;
            }
            else if (nvCampagne == 4)
            {
                agiliteEnnemi1 += NV_4;
                agiliteEnnemi2 += NV_4;
                agiliteEnnemi3 += NV_4;
                vieEnnemi1 += NV_4_VIE;
                vieEnnemi2 += NV_4_VIE;
                vieEnnemi3 += NV_4_VIE;
                attaqueEnnemi1 += NV_4;
                attaqueEnnemi2 += NV_4;
                attaqueEnnemi3 += NV_4;
            }
            else if (nvCampagne == 5)
            {
                agiliteEnnemi1 += NV_5;
                agiliteEnnemi2 += NV_5;
                agiliteEnnemi3 += NV_5;
                vieEnnemi1 += NV_5_VIE;
                vieEnnemi2 += NV_5_VIE;
                vieEnnemi3 += NV_5_VIE;
                attaqueEnnemi1 += NV_5;
                attaqueEnnemi2 += NV_5;
                attaqueEnnemi3 += NV_5;
            }
            else if (nvCampagne == 6)
            {
                agiliteEnnemi1 += NV_6;
                agiliteEnnemi2 += NV_6;
                agiliteEnnemi3 += NV_6;
                vieEnnemi1 += NV_6_VIE;
                vieEnnemi2 += NV_6_VIE;
                vieEnnemi3 += NV_6_VIE;
                attaqueEnnemi1 += NV_6;
                attaqueEnnemi2 += NV_6;
                attaqueEnnemi3 += NV_6;
            }
            else if (nvCampagne == 7)
            {
                agiliteEnnemi1 += NV_7;
                agiliteEnnemi2 += NV_7;
                agiliteEnnemi3 += NV_7;
                vieEnnemi1 += NV_7_VIE;
                vieEnnemi2 += NV_7_VIE;
                vieEnnemi3 += NV_7_VIE;
                attaqueEnnemi1 += NV_7;
                attaqueEnnemi2 += NV_7;
                attaqueEnnemi3 += NV_7;
            }
            else if (nvCampagne == 8)
            {
                agiliteEnnemi1 += NV_8;
                agiliteEnnemi2 += NV_8;
                agiliteEnnemi3 += NV_8;
                vieEnnemi1 += NV_8_VIE;
                vieEnnemi2 += NV_8_VIE;
                vieEnnemi3 += NV_8_VIE;
                attaqueEnnemi1 += NV_8;
                attaqueEnnemi2 += NV_8;
                attaqueEnnemi3 += NV_8;
            }
            else if (nvCampagne == 9)
            {
                agiliteEnnemi1 += NV_9;
                agiliteEnnemi2 += NV_9;
                agiliteEnnemi3 += NV_9;
                vieEnnemi1 += NV_9_VIE;
                vieEnnemi2 += NV_9_VIE;
                vieEnnemi3 += NV_9_VIE;
                attaqueEnnemi1 += NV_9;
                attaqueEnnemi2 += NV_9;
                attaqueEnnemi3 += NV_9;
            }
            else if (nvCampagne == 10)
            {
                agiliteEnnemi1 += NV_10;
                agiliteEnnemi2 += NV_10;
                agiliteEnnemi3 += NV_10;
                vieEnnemi1 += NV_10_VIE;
                vieEnnemi2 += NV_10_VIE;
                vieEnnemi3 += NV_10_VIE;
                attaqueEnnemi1 += NV_10;
                attaqueEnnemi2 += NV_10;
                attaqueEnnemi3 += NV_10;
            }


            ennemi1.CreeHero(vieEnnemi1, agiliteEnnemi1, attaqueEnnemi1, "ennemi 1", null, true, compagnieEnnemi, "regeneration");
            ennemi2.CreeHero(vieEnnemi2, agiliteEnnemi2, attaqueEnnemi2, "ennemi 2", null, true, compagnieEnnemi, "attaque");
            ennemi3.CreeHero(vieEnnemi3, agiliteEnnemi3, attaqueEnnemi3, "ennemi 3", null, true, compagnieEnnemi, "defense");
            
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

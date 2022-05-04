﻿/*
 * Billegas Lucas, Crausaz Neal 
 * Projet : Jeu en c#
 * Fichier : Class Extension
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Heroes
{
    public static class Extension
    {
        const double POURCENTAGE = 20f / 100;
        /// <summary>
        /// Traitement de l'héro, ajout tenue, armes
        /// </summary>
        internal static Heros TraitementHeros(Arme armeChoisi, Arme armeChoisi2, Tenue tenueChoisi, Heros heros)
        {
            //Assigner les armes choisies à l'héros concerné 
            if (armeChoisi.NbMains == 1 && armeChoisi2.NbMains == 1)
            {
                heros.Arme1 = armeChoisi;
                heros.Arme2 = armeChoisi2;
            }
            else
            {
                heros.Arme1 = armeChoisi;
                heros.Arme2 = armeChoisi;
            }
            //Assigner la tenue à l'héros concerné
            heros.Tenue = tenueChoisi;


            //Changement des stats de l'héros en fonction de la tenue et des armes

            //Tenues Stat
            heros.NvVie += Convert.ToInt32(POURCENTAGE * tenueChoisi.NvDefense);
            heros.Agilite -= Convert.ToInt32(POURCENTAGE * tenueChoisi.Poids);

            //Armes Stat
            if (armeChoisi.NomArme == "bouclier")
            {
                heros.NvVie += Convert.ToInt32(POURCENTAGE * armeChoisi.Durabilite);
            }
            else if (armeChoisi2.NomArme == "bouclier")
            {
                heros.NvVie += Convert.ToInt32(POURCENTAGE * armeChoisi2.Durabilite);
            }

            heros.Attaque += Convert.ToInt32(POURCENTAGE * armeChoisi.NvAttaque);
            if (heros.Arme1 != heros.Arme2)
            {
                heros.Attaque += Convert.ToInt32(POURCENTAGE * armeChoisi2.NvAttaque);
            }
            return heros;

        }
    }
}

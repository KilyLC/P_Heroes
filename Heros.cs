﻿/*
 * Billegas Lucas, Crausaz Neal 
 * Projet : Jeu en c#
 * Fichier : Class Heros
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace P_Heroes
{
    public class Heros
    {
        private string _nomHeros;
        private Tenue _tenue;
        private int _nvVie;
        private int _attaque;
        private int _agilite;      
        private Arme _arme1;
        private Arme _arme2;
        private Compagnie _compagnie;
        private Image imageHero;

        public string NomHeros { get => _nomHeros; set => _nomHeros = value; }
        public int NvVie { get => _nvVie; set => _nvVie = value; }
        public int Agilite { get => _agilite; set => _agilite = value; }
        public int Attaque { get => _attaque; set => _attaque = value; }
        public Image ImageHero { get => imageHero; set => imageHero = value; }
        internal Tenue Tenue { get => _tenue; set => _tenue = value; }
        internal Arme Arme1 { get => _arme1; set => _arme1 = value; }
        internal Arme Arme2 { get => _arme2; set => _arme2 = value; }
        internal Compagnie Compagnie { get => _compagnie; set => _compagnie = value; }
        

        //
        public void Heros1(string nomHeros)
        {
            Agilite = 70;
            Attaque = 60;
            NvVie = 100;
            NomHeros = nomHeros;
            ImageHero = Properties.Resources.Hero1;
        }
        public void Heros2(string nomHeros)
        {
            Agilite = 50;
            Attaque = 40;
            NvVie = 100;
            NomHeros = nomHeros;
            ImageHero = Properties.Resources.Hero2;
        }
        public void Heros3(string nomHeros)
        {
            Agilite = 40;
            Attaque = 30;
            NvVie = 100;
            NomHeros = nomHeros;
            ImageHero = Properties.Resources.Hero3;
        }
        public void Ennemi1(string nomHeros)
        {
            Agilite = 40;
            Attaque = 20;
            NvVie = 100;
            NomHeros = nomHeros;
            ImageHero = Properties.Resources.OrcArcherCuir;
        }
        public void Ennemi2(string nomHeros)
        {
            Agilite = 10;
            Attaque = 50;
            NvVie = 100;
            NomHeros = nomHeros;
            ImageHero = Properties.Resources.Orc_Warriors_Armor_Shield;
        }
        public void Ennemi3(string nomHeros)
        {
            Agilite = 60;
            Attaque = 30;
            NvVie = 100;
            NomHeros = nomHeros;
            ImageHero = Properties.Resources.OrcArcherCuir;
        }
    }
}

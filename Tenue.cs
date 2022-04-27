using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Heroes
{
    class Tenue
    {
        private string _nomTenue;
        private int _nvDefense;
        private int _poids;

        public string NomTenue { get => _nomTenue; set => _nomTenue = value; }
        public int NvDefense { get => _nvDefense; set => _nvDefense = value; }
        public int Poids { get => _poids; set => _poids = value; }

        //tenue 1 
        private static readonly string TENUE1 = "tissu";
        private static readonly int POIDS_TENUE1 = 10;
        private static readonly int NIV_DEFENSE_1 = 20;
        //tenue 2 
        private static readonly string TENUE2 = "cuir";
        private static readonly int POIDS_TENUE2 = 30;
        private static readonly int NIV_DEFENSE_2 = 40;
        //tenue 3
        private static readonly string TENUE3 = "metal";
        private static readonly int POIDS_TENUE3 = 70;
        private static readonly int NIV_DEFENSE_3 = 40;

        public Tenue(string nomTenue)
        {
            if (nomTenue == TENUE1)
            {
                NomTenue = TENUE1;
                Poids = POIDS_TENUE1;
                NvDefense = NIV_DEFENSE_1;
            }
            else if(nomTenue == TENUE2)
            {
                NomTenue = TENUE2;
                Poids = POIDS_TENUE2;
                NvDefense = NIV_DEFENSE_2;
            }
            else if (nomTenue == TENUE3)
            {
                NomTenue = TENUE3;
                Poids = POIDS_TENUE3;
                NvDefense = NIV_DEFENSE_3;
            }
            else
            {
                throw new Exception("Tenue invalide");
            }
        }
    }
}

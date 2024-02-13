using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO1_Encapsulation
{
    public class Personnage
    {

        private string nom;
        private int pointsDeVie;
        private int pointsDepuissance;


        //Pour les protéger nos attributs : selectionner, click droit, Action rapide et refactorisation, encapsuler les champs (et utiliser la propriété)

        public string Nom { get => nom; set => nom = value; }
        public int PointsDeVie
        {
            get => pointsDeVie;
            set
            {
                if (value < 0) 
                { 
                    pointsDeVie = 0; //Empêche de descendre en bas de 0
                }
                else 
                { 
                    pointsDeVie = value;
                }
            }
        }
        public int PointsDepuissance { get => pointsDepuissance; set => pointsDepuissance = value; }

        public bool EstEnVie
        {
            get
            {
                if (pointsDeVie > 0)
                {
                    return true;
                }
                return false;
            }
        }
    }
}

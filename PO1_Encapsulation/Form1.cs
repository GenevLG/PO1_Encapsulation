namespace PO1_Encapsulation
{
    public partial class Form1 : Form
    {

        Personnage joueur = new();
        Personnage dragon = new Personnage();  

        public Form1()
        {
            InitializeComponent();

            joueur.PointsDeVie = 10;
            dragon.PointsDeVie = 30;

            joueur.PointsDepuissance = 1;
            dragon.PointsDepuissance = 3;
        }

        private void ActualiserLabel() 
        { 
            lbl_pointsVieJoueur.Text = "Vie du joueur : " + joueur.PointsDeVie.ToString();
            lbl_pointsVieDragon.Text = "Vie du dragon : " + dragon.PointsDeVie.ToString();

            lbl_puissanceAttaqueJoueur.Text = "Attaque du joueur : " + joueur.PointsDepuissance.ToString();
            lbl_puissanceAttaqueDragon.Text = "Attaque du dragon : " + dragon.PointsDepuissance.ToString();
            
        }

        private void btn_attaquer_Click(object sender, EventArgs e)
        {
            dragon.PointsDeVie -= joueur.PointsDepuissance;
            TourDragon();
            ActualiserLabel();
        }

        private void btn_seSoigner_Click(object sender, EventArgs e)
        {
            joueur.PointsDeVie += 5;
            TourDragon();
            ActualiserLabel();
        }

        private void btn_puissanceAttaque_Click(object sender, EventArgs e)
        {
            joueur.PointsDepuissance++;
            TourDragon();
            ActualiserLabel();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualiserLabel();
        }

        private void TourDragon() 
        { 
            joueur.PointsDeVie -= dragon.PointsDepuissance;
        }
    }

}
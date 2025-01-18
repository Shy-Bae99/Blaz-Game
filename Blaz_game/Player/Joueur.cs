namespace Player
{
    // Classe de base Joueur
    public class Joueur
    {
        public int PV { get;  set; }
        public int Attaque { get;  set; }
        public int VitesseAttaque { get;  set; }
        public int Agilite { get;  set; }
        public int Armure { get;  set; }

        // Constructeur par défaut
        public Joueur()
        {
            PV = 100; // Valeurs par défaut
            Attaque = 10;
            VitesseAttaque = 10;
            Agilite = 10;
            Armure = 10;
        }

        // Méthode Modifier pour ajuster les stats
        public void Modifier(int pvDelta, int attaqueDelta, int vitesseAttaqueDelta, int agiliteDelta, int armureDelta)
        {
            PV += pvDelta;
            Attaque += attaqueDelta;
            VitesseAttaque += vitesseAttaqueDelta;
            Agilite += agiliteDelta;
            Armure += armureDelta;

        }
    }
}
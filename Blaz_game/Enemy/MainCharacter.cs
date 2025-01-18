namespace Enemy
{
    // Classe principale Ennemi
    public class Ennemi
    {
        public int Pv { get; set; }
        
        public int Attaque { get; set; }
        public int VitesseAttaque { get; set; }
        public int Agilite { get; set; }
        public int Armure { get; set; }

        // Constructeur par défaut avec caractéristiques de base
        public Ennemi()
        {
            Pv = 30;
            Attaque = 30;
            VitesseAttaque = 50;
            Agilite = 0;
            Armure = 0;
        }

      
        // Méthode pour obtenir les statistiques sous forme de chaîne
        public virtual string AfficherStatistiques()
        {
            return $"PV: {Pv}, Attaque:{Attaque}, Vitesse d'Attaque: {VitesseAttaque}, Agilité: {Agilite}, Armure: {Armure}";
        }
        
    }
}
namespace Player
{
    // Classe principale Joueur
    public class Joueur
    {
        public int Pv { get; set; }
        public int VitesseAttaque { get; set; }
        public int Agilite { get; set; }
        public int Armure { get; set; }

        // Constructeur par défaut avec caractéristiques de base
        public Joueur()
        {
            Pv = 100;
            VitesseAttaque = 100;
            Agilite = 60;
            Armure =70;
        }

        // Méthode pour obtenir les statistiques sous forme de chaîne
        public virtual string AfficherStatistiques()
        {
            return $"PV: {Pv}, Vitesse d'Attaque: {VitesseAttaque}, Agilité: {Agilite}, Armure: {Armure}";
        }
    }
}
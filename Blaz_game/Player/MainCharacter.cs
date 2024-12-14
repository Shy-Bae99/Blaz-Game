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
            Agilite = 0;
            Armure = 0;
        }

        // Méthode d'affichage des statistiques
        public virtual void AfficherStatistiques()
        {
            Console.WriteLine($"PV: {Pv}, Vitesse d'Attaque: {VitesseAttaque}, Agilité: {Agilite}, Armure: {Armure}");
        }
        
    }
}
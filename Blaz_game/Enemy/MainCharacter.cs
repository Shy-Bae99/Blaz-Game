namespace Enemy
{
    // Classe principale Joueur
    public class Ennemi
    {
        public int Pv { get; set; }
        public int VitesseAttaque { get; set; }
        public int Agilite { get; set; }
        public int Armure { get; set; }

        // Constructeur par défaut avec caractéristiques de base
        public Ennemi()
        {
            Pv = 30;
            VitesseAttaque = 50;
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
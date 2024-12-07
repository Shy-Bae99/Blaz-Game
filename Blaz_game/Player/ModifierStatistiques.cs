namespace Player
{
    // Extension de la classe Joueur pour modifier les statistiques
    public static class ModifierStatistiques
    {
        public static void Modifier(this Joueur joueur, int pvDelta, int vitesseAttaqueDelta, int agiliteDelta, int armureDelta)
        {
            joueur.Pv += pvDelta;
            joueur.VitesseAttaque += vitesseAttaqueDelta;
            joueur.Agilite += agiliteDelta;
            joueur.Armure += armureDelta;

            // Empêche les statistiques d'être négatives
            if (joueur.Pv < 0) joueur.Pv = 0;
            if (joueur.VitesseAttaque < 0) joueur.VitesseAttaque = 0;
            if (joueur.Agilite < 0) joueur.Agilite = 0;
            if (joueur.Armure < 0) joueur.Armure = 0;
        }
    }
}

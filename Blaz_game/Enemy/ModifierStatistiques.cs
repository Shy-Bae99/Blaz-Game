namespace Enemy
{
    // Extension de la classe Joueur pour modifier les statistiques
    public static class ModifierStatistiques
    {
        public static void Modifier(this Ennemi ennemi, int pvDelta, int vitesseAttaqueDelta, int agiliteDelta, int armureDelta)
        {
            ennemi.Pv += pvDelta;
            ennemi.VitesseAttaque += vitesseAttaqueDelta;
            ennemi.Agilite += agiliteDelta;
            ennemi.Armure += armureDelta;

            // Empêche les statistiques d'être négatives
            if (ennemi.Pv < 0) joueur.Pv = 0;
            if (ennemi.VitesseAttaque < 0) joueur.VitesseAttaque = 0;
            if (ennemi.Agilite < 0) joueur.Agilite = 0;
            if (ennemi.Armure < 0) joueur.Armure = 0;
        }
    }
}
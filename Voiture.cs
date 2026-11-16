namespace _6TTI_DayaniPoty_Heritage_Abstract;

public class Voiture : Vehicule
{
    private string _motorisation;
    private bool _gps;
    
    
    public Voiture(string motorisation, bool gps, string modele, string marque, string couleur, decimal prix) : base(modele, marque, couleur, prix)
    {
        _motorisation = motorisation;
        _gps = gps;
    }

    public override string Affiche()
    {
        return base.Affiche() + ", Motorisation: " + _motorisation + ", GPS: " + (_gps ? "Oui" : "Non");
    }
}
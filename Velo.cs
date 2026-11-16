namespace _6TTI_DayaniPoty_Heritage_Abstract;

public class Velo : Vehicule
{
    private string _type;
    private bool _estElectrique;
    
    public Velo(string type, bool estElectrique, string modele, string marque, string couleur, decimal prix) : base(modele, marque, couleur, prix)
    {
        _type = type;
        _estElectrique = estElectrique;
    }
    
    public override string Affiche()
    {
        return base.Affiche() + ", Type: " + _type + ", Électrique: " + (_estElectrique ? "Oui" : "Non");
    }
}
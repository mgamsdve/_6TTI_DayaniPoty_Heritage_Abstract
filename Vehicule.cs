namespace _6TTI_DayaniPoty_Heritage_Abstract;

public abstract class Vehicule
{
    protected string _modele;
    protected string _marque;
    protected string _couleur;
    protected decimal _prix;
    
    public Vehicule(string modele, string marque, string couleur, decimal prix)
    {
        _modele = modele;
        _marque = marque;
        _couleur = couleur;
        _prix = prix;
    }
    

    public virtual string Affiche()
    {
        return $"Modèle: {_modele}, Marque: {_marque}, Couleur: {_couleur}, Prix: {_prix}";
    }
}
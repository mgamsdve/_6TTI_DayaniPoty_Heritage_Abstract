namespace _6TTI_DayaniPoty_Heritage_Abstract;

class Program
{
    static void Main(string[] args)
    {
        // Impossible de créer une instance de la classe abstraite Vehicule
        // Vehicule vehicule = new Vehicule("Modèle", "Marque", "Couleur", 1000m); // Erreur de compilation
        
        Velo[] velos = new Velo[3];
        velos[0] = new Velo("VTT", false, "Rockrider", "Decathlon", "Noir", 500m);
        velos[1] = new Velo("Route", true, "Specialized", "Specialized", "Rouge", 1200m);
        velos[2] = new Velo("Ville", false , "Brompton", "Brompton", "Gris", 1500m);
        
        Console.WriteLine("Affichage des vélos :");
        foreach (Velo vlo in velos)
        {
            Console.WriteLine(vlo.Affiche());
        }  
        
        Voiture voiture = new Voiture("Essence", true, "Model S", "Tesla", "Rouge", 80000m);
        Console.WriteLine(voiture.Affiche());

        Velo velo = new Velo("VTT", false, "Rockrider", "Decathlon", "Noir", 500m);
        Console.WriteLine(velo.Affiche());
        
    }
}
namespace AmauryPOOHeritageVehicule
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicule[] garage = new Vehicule[6];
            garage[0] = new Voiture("V8 biturbo de 5,0 litres",true, " Jesko", "Koenigsegg ","noir",3000000);
            garage[1] = new Velo("VTT",true,"XR5","TurboRide","noir",1200);
            garage[2] = new Voiture("V8 biturbo de 5,0 litres", true, " Jesko absulot", "Koenigsegg ", "noir", 3000000);
            garage[3] = new Velo("urbain", false, "VVille", "UrbainKids", "noir", 200);
            garage[4] = new Velo("urbain", true, "VVille", "Urbaibrider", "noir", 500);
            garage[5] = new Voiture("HV8 de 5,0 litres", true, " Gemera", "Koenigsegg ", "vert", 1700000);


            foreach (Vehicule vehicule in garage)
            {
                Console.WriteLine(vehicule.Affiche());
            }
        }

    }
}

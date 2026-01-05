namespace AmauryPOOCodeVoiture
{
    internal class Program
    {
        public class Programme
        {
            public static void Main()
            {
                // Création d’un tableau de véhicules
                vehicule[] garage = new vehicule[3];

                garage[0] = new vehicule("1-ABC-123", "Koenigsegg ", "Gemera", 80, 40);
                garage[1] = new vehicule("2-XYZ-456", "Koenigsegg", " Jesko Absolut ", 85, 35);
                garage[2] = new vehicule("3-DEF-789", "Mercedes", "AMG-GT", 90, 30);

                // Tests
                foreach (vehicule v in garage)
                {
                    v.AfficherInfos();
                }

                Console.WriteLine("== Tests des méthodes ==");

                garage[0].AjouterCarburant(15);
                garage[1].FaireLePlein();
                garage[2].ConsommerCarburant(20);

                foreach (vehicule v in garage)
                {
                    v.AfficherInfos();
                }
            }

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amaury_POO__SandwichMaker
{
    internal class Sandwichs
    {
    }
   

namespace SandwichsAleatoires
    {
        class SandwichMaker
        {
            private readonly string[] proteines =
            {
            "jambon",
            "fromage",
            "roast beef",
            "salami",
            "poulet",
            "dinde",
            "thon",
            "œuf"


        };

            private readonly string[] condiments =
            {
            "mayo",
            "ketchup",
            "moutarde",
            "sauce barbecue",
            "sauce piquante"


        };

            private readonly string[] pains =
            {
            "pain blanc",
            "pain complet",
            "pain aux céréales",
            "pain 1/2 gris",
            "baguette"
        };

            private readonly string[] crudites =
            {
            "salade",
            "tomates",
            "cornichons",
            "carottes",
            "oignons",
            "poivrons",
            "concombres",
            "radis",
            "avocats",
            "champignons"

        };

            private Random random = new Random();

            public string ComposeSandwich()
            {
                string pain = pains[random.Next(pains.Length)];
                string proteine = proteines[random.Next(proteines.Length)];
                string crudite = crudites[random.Next(crudites.Length)];
                string condiment = condiments[random.Next(condiments.Length)];

                return $"Pain {pain}, {proteine}, {crudite}, {condiment}";
            }
        }
    }


}


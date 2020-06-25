using System;
using System.Collections.Generic;
using System.Text;

namespace SubscriptionModel.Models
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public ProductType FavoriteType { get; set; }

        public void ReadPromotion(ProductType product)
        {
            
            Console.WriteLine($"Mr./Ms. {Name}, the {product} is on sale!");
            if (product == FavoriteType) Console.WriteLine("My Favorite!");
        }

        public void ReadInfo(string message)
        {
            Console.WriteLine($"Dear {Name}, here are the working hours!");
        }

        public void ReadNewLocation(string message)
        {
            Console.WriteLine($"Dear {Name}, we have opened a new location at Kosta Abrasevic 77, Skopje!");
        }
    }
}

using SubscriptionModel.Models;
using System;
using System.Threading;

namespace SubscriptionModel
{
    class Program
    {
        #region Markets And User

        public static Market Vero = new Market()
        {
            Name = "Vero",
            CurrentPromotion = ProductType.Food
        };
        public static Market Tinex = new Market()
        {
            Name = "Tinex",
            CurrentPromotion = ProductType.Drinks
        };
        public static Market Tehnomarket = new Market()
        {
            Name = "Tehnomarket",
            CurrentPromotion = ProductType.Electronics
        };

        




        #endregion
        static void Main(string[] args)
        {
            User martin = new User() { Name = "Martin", Age = 26, FavoriteType = ProductType.Drinks };
            User dejan = new User() { Name = "Dejan", Age = 28, FavoriteType = ProductType.Food };
            User ivo = new User() { Name = "Ivo", Age = 30, FavoriteType = ProductType.Cosmetics };


            //// Users subscribe to Vero for their promotions
            //Vero.SubscribeForPromotions(martin.ReadPromotion, "martin@gmail.com");
            //Vero.SubscribeForPromotions(dejan.ReadPromotion, "dejan@gmail.com");
            //Vero.SubscribeForPromotions(ivo.ReadPromotion, "ivo@gmail.com");
            //// Users subscribe to Tinex for their promotions
            //Tinex.SubscribeForPromotions(martin.ReadPromotion, "martin@gmail.com");

            //// Users subscribe to Tehnomarket for their promotions
            //Tehnomarket.SubscribeForPromotions(dejan.ReadPromotion, "dejan@gmail.com");
            //Tehnomarket.SubscribeForPromotions(ivo.ReadPromotion, "ivo@gmail.com");

            ////Vero is sending promotions to all its subscribers
            //Vero.SendPromotions();
            //Vero.CurrentPromotion = ProductType.Drinks;
            //Vero.UnsubscribeForPromotions(martin.ReadPromotion, "Boring");
            //Console.WriteLine("==============================");
            //Tinex.SendPromotions();
            //Tinex.CurrentPromotion = ProductType.Food;
            //Console.WriteLine("==============================");
            //Tehnomarket.SendPromotions();
            //Tehnomarket.UnsubscribeForPromotions(dejan.ReadPromotion, "Too often");
            //Tehnomarket.UnsubscribeForPromotions(ivo.ReadPromotion, "Too expensive");
            //Tehnomarket.SubscribeForPromotions(martin.ReadPromotion, "martin@gmail.com");

            //Thread.Sleep(4000);
            //Console.Clear();
            //Vero.SendPromotions();
            //Tinex.SendPromotions();
            //Tehnomarket.SendPromotions();


            //Vero.DisplayZalbiIPoplaki();
            //Tinex.DisplayZalbiIPoplaki();
            //Tehnomarket.DisplayZalbiIPoplaki();

            //Console.Clear();
            //Thread.Sleep(4000);
            //Vero.SubscribeForInfo(martin.ReadInfo, "martin@mail.com");
            //Vero.SendInfo();



            Vero.SubscribeForLocation(martin.ReadNewLocation, "martin@mail.com");
            Vero.SubscribeForLocation(dejan.ReadNewLocation, "martin@mail.com");
            Tehnomarket.SubscribeForLocation(dejan.ReadNewLocation, "dejan@mail.com");
            Tehnomarket.SubscribeForLocation(martin.ReadNewLocation, "dejan@mail.com");
            Tinex.SubscribeForLocation(ivo.ReadNewLocation, "ivo@mail.com");

            Vero.SendNewLocation();
            Tehnomarket.SendNewLocation();
            Tinex.SendNewLocation();

            Vero.UnsubscribeForLocation(martin.ReadNewLocation, "martin@mail.com");
            Tehnomarket.UnsubscribeForLocation(dejan.ReadNewLocation, "dejann@mail.com");
            Thread.Sleep(3000);
            Console.Clear();
            

            Vero.SendNewLocation();
            Tehnomarket.SendNewLocation();
            Tinex.SendNewLocation();
            Console.ReadLine();
        }
    }
}

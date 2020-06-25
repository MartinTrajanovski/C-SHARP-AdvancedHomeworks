using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SubscriptionModel.Models
{
    //this class will be the publisher
    //it will send messages to all objects subscribed for sucj messages
    public class Market
    {
        public delegate void PromotionSender(ProductType product);
        public event PromotionSender PromotionsHandler;

        public delegate void InformationSender(string message);
        public event InformationSender InformationHandler;

        public delegate void NewLocationSender(string message);
        public event NewLocationSender NewLocationHandler;




        public string Name { get; set; }
        public ProductType CurrentPromotion { get; set; }
        public List<string> ZalbiIPoplaki { get; set; }
        public List<string> Emails { get; set; }
        public Market()
        {
            ZalbiIPoplaki = new List<string>();
            Emails = new List<string>();
        }
        //a method tha does some work (sends promotions)
        // thread.sleep - simulates that somethins is being done for 3 seconds
        public void SendPromotions()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine($"{Name} is sending promotion for {CurrentPromotion}");
            Console.WriteLine("----------------------------------");
            Thread.Sleep(3000);
            Send();
        }

        private void Send()
        {
            PromotionsHandler(CurrentPromotion);
        }


        public void SubscribeForPromotions(PromotionSender suscriber, string email)
        {
            PromotionsHandler += suscriber;
            Emails.Add(email);
        }
        public void UnsubscribeForPromotions(PromotionSender suscriber, string reason)
        {
            PromotionsHandler -= suscriber;
            ZalbiIPoplaki.Add(reason);
        }

        public void DisplayZalbiIPoplaki()
        {
            Console.WriteLine($"{Name} ZALBI I POPLAKI:");
            ZalbiIPoplaki.ForEach(Console.WriteLine);
        }

        public void SubscribeForInfo(InformationSender subscriber, string email)
        {
            InformationHandler += subscriber;
            Emails.Add(email);
        }
        public void UnsubscribeForInfo(InformationSender subscriber, string reason)
        {
            InformationHandler -= subscriber;
            ZalbiIPoplaki.Add(reason);
        }

        public void SendInfo()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine($"{Name} is sending promotion for working hours");
            Console.WriteLine("----------------------------------");
            Thread.Sleep(3000);
            InformationHandler("Working hours");
        }

        public void SendNewLocation()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine($"{Name} is sending promotion for a new location opened!");
            Console.WriteLine("----------------------------------");
            Thread.Sleep(3000);
            NewLocationHandler("New Location");
        }
        public void SubscribeForLocation(NewLocationSender subscriber, string email)
        {
            NewLocationHandler += subscriber;
            Emails.Add(email);
        }
        public void UnsubscribeForLocation(NewLocationSender subscriber, string reason)
        {
            NewLocationHandler -= subscriber;
            ZalbiIPoplaki.Add(reason);
        }

    }
    public enum ProductType
    {
        Food,
        Cosmetics,
        Drinks,
        Electronics,
        Other
    }
}

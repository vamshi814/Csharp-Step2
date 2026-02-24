using System;

namespace RemotingSystem
{
    interface IRemote
    {
        void PowerOn();
        void ChangeChannel(int channelNumber);
        void IncreaseVolume();

    }
    interface IPrice
    {
        double getPrice();
    }
    interface IRemoteManufacturer : IRemote , IPrice
    {
        double getManufacturer();
    }
    //Multiple Interfaces are inherited for Sony Remote
    class SonyRemote : IRemote , IPrice
    {
        //---------------IRemote Implementation
        public void PowerOn()
        {
            Console.WriteLine("Sony TV Power on");
        }

        public void ChangeChannel(int channelNumber)
        {
            Console.WriteLine($"Sony tv channe changed to {channelNumber}");
        }

        public void IncreaseVolume()
        {
            Console.WriteLine("Sony TV volume increased");
        }
        //---------IPrice Implementation
        public double getPrice()
        {
            return 1200;
        }

    }
    class LGRemote : IRemote , IPrice
    {
        //---------------IRemote Implementation
        public void ChangeChannel(int channelNumber)
        {
            Console.WriteLine($"LG TV channel changed to {channelNumber}");
        }

        public void IncreaseVolume()
        {
            Console.WriteLine("LG TV volume increased");
        }

        public void PowerOn()
        {
            Console.WriteLine("LG TV Power on");

        }
        //---------IPrice Implementation
        public double getPrice()
        {
            return 1200;
        }
    }
    class SamsungRemote : IRemoteManufacturer
    {
        public void ChangeChannel(int channelNumber)
        {
            Console.WriteLine($"Samsung channel changed to {channelNumber}");
        }

        public double getManufacturer()
        {
            return 3000;
        }
        public double getPrice()
        {
            return 1500;
        }

        public void IncreaseVolume()
        {
            Console.WriteLine($"Samsung Remote volume Increased");
        }

        public void PowerOn()
        {
            Console.WriteLine("LG TV Power on");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            LGRemote lGRemote = new LGRemote();
            lGRemote.PowerOn();
            lGRemote.ChangeChannel(19);
            Console.WriteLine("----------------------");
            IRemote sonyRemote = new SonyRemote();
            //sonyRemote only access the IRemote members
            //bcz IRemote reference used it reflects only what it contains

            //    sonyRemote.getPrice();  not possible 
            sonyRemote.PowerOn();

            IPrice sonyPrice = new SonyRemote();
            double price = sonyPrice.getPrice();
            Console.WriteLine($"Sony Remote Price is: {price}");

            // but with SonyRemote refernce we can access all members in SonyRemote
            SonyRemote sonyRemote1 = new SonyRemote();
            sonyRemote1.PowerOn();
            double price2  = sonyRemote1.getPrice();
            Console.WriteLine($"Price is {price2}");
            Console.WriteLine("----------------------");

            //----------------Samsung Remote : IRemoteManufacturer
            IPrice samsung1 = new SamsungRemote();
            double price3 = samsung1.getPrice();
            Console.WriteLine("Samsung IPrice price:" + price3);
            
            IRemote samsung2 = new SamsungRemote();
            samsung2.PowerOn();
            samsung2.IncreaseVolume();
            samsung2.ChangeChannel(13);
            Console.WriteLine("----------------------");
            //access all members
            IRemoteManufacturer samsung3 = new SamsungRemote();
            Console.WriteLine($"Samsung IRemoteManufacturer cost: {samsung3.getManufacturer()}");
            Console.WriteLine("Samsung IRemoteManufacturer remote price:" + samsung3.getPrice());
            samsung3.PowerOn();

            Console.WriteLine("----------------------");
            //access all members
            SamsungRemote AllinOne = new SamsungRemote();
            Console.WriteLine($"Samsung cost: {AllinOne.getManufacturer()}");

        }
    }
}

using System;
using System.Collections.Generic;

namespace Midterm3
{
    class Program
    {
        static void Main(string[] args)
        {
            FlowerStore flowerStore = new FlowerStore();

            BuyFlowerPage(flowerStore);
            ShowCart(flowerStore);

        }

        static void BuyFlowerPage(FlowerStore flowerStore) //แสดงหน้าเลือกดอกไม้
        {
            SelectFlowerHeader();
            AddFlower(flowerStore);
            StopProgess(flowerStore);
        }

        static void SelectFlowerHeader() //แสดงประเภทดอกไม้ที่ให้ซื้อ
        {
            Console.WriteLine("Select number for buy flower :");
            Console.WriteLine("1. Rose");
            Console.WriteLine("2. Lotus");
        }

        static int InputFlowerSelect() //เลือกดอกไม้
        {
            Console.Write("Input: ");
            return int.Parse(Console.ReadLine());            
        }
        static void AddFlower(FlowerStore flowerStore) //เพิ่มดอกไม้ในList
        {
            switch (InputFlowerSelect())
            {
                case 1:
                    flowerStore.AddFlowerToCart(flowerStore.flowerList[0]);
                    Console.WriteLine("Added " + flowerStore.flowerList[0]);
                    break;
                case 2:
                    flowerStore.AddFlowerToCart(flowerStore.flowerList[1]);
                    Console.WriteLine("Added " + flowerStore.flowerList[1]);
                    break;
                default:
                    Console.WriteLine("Not Added to cart. found select number of flower");
                    break;
            }
        }
        static void StopProgess(FlowerStore flowerStore) //หยุดซื้อดอกไม้เพิ่ม
        {
            string decide = "";
            
            Console.WriteLine("You can stop this progress ? exit for >> exit << progress and pressany key for continue");
            decide = Console.ReadLine();

            if (decide != "exit")
            {
                BuyFlowerPage(flowerStore);
            }
        }
        static void ShowCart(FlowerStore flowerStore) //แสดงดอกไม้ที่ซื้อ
        {
            Console.WriteLine("Current my cart");
            flowerStore.showCart();
        }
    }

}

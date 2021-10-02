using System;
using System.Collections.Generic;

class FlowerStore
{
    public List<string> flowerList = new List<string>();
    List<string> cart = new List<string>();

    public FlowerStore()
    {
        flowerList.Add("Rose");
        flowerList.Add("Lotus");
    }

    public void AddFlowerToCart(string name) //เพิ่มดอกไม้ในตระกร้าของเรา
    {
        cart.Add(name);
    }

    public void showCart() //แสดงหน้าดอกไม้ที่ซื้อ
    {
        if (cart.Count == 0)
        {
            Console.WriteLine("Cart is empty");
        }
        else
        {
            Console.WriteLine("My Cart :");
            foreach (string i in cart)
            {
                Console.WriteLine(i);
            }
        }
    }


}

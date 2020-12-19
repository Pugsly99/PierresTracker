using System.Collections.Generic;

namespace PierresTracker.Models
{
    public class Order
    {
      public string Title { get; set; }
      public string Description { get; set; }
      public int Id { get; }
      public int Price { get; set; }
      public int BreadAmount { get; set; }
      public int PastryAmount { get; set; }
      public string Date {get; set; }
      private static List<Order> _instances = new List<Order> { };

      public Order(string title)
      {
        Title = title;
        _instances.Add(this);
        Id = _instances.Count;
      }

      public void GetDescription(string description)
      {
        Description = description;
      }

      public void GetDate(string date)
      {
        Date = date;
      }



      public static List<Order> GetAll()
      {
        return _instances;
      }

      public static void ClearAll()
      {
        _instances.Clear();
      }

      public static Order Find(int searchId)
      {
        return _instances[searchId - 1];
      }

      public void Bread(int amount)
      {
        int free = 0;
        if (amount % 2 != 0)
        {
          amount -= 1;
          free = amount / 2;
          amount += 1;
          Price += amount * 5;
          amount += free;
          BreadAmount += amount;
        }
        else if (amount % 2 == 0)
        {
          free = amount / 2;
          Price += amount * 5;
          amount += free;
          BreadAmount += amount;
        }
      }

      public void Pastry(int amount)
      {
        int deal = 0;
        int nondeal = 0;
        if (amount >= 5)
        {
          PastryAmount += amount;
          nondeal = amount % 5;
          deal = amount - nondeal;
          deal = deal / 5;
          deal = deal * 7; 
          nondeal = nondeal * 2;
          Price += deal + nondeal;
        }
        else if (amount >= 3)
        {
          PastryAmount += amount;
          nondeal = amount % 3;
          deal = amount - nondeal;
          deal = deal / 3;
          deal = deal * 5; 
          nondeal = nondeal * 2;
          Price += deal + nondeal;
          
        }
        else 
        {
          PastryAmount += amount;
          nondeal = amount * 2;
          Price += nondeal;
        }
      }
    }
}
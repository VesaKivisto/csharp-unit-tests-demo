using System.Collections.Generic;

namespace UnitTests
{
    public class Basket
    {
        public string Customer { get; set; }
        public List<string> Contents { get; set; }
        public double Price { get; set; }

        public Basket(string customer, List<string> contents, double price)
        {
            this.Customer = customer;
            this.Contents = contents;
            this.Price = price;
        }

        public string ReturnCustomer()
        {
            return this.Customer;
        }

        public List<string> ReturnContents()
        {
            return this.Contents;
        }

        public double ReturnPrice()
        {
            return this.Price;
        }

        public void AddProduct(string product, double productPrice)
        {
            this.Contents.Add(product);
            this.Price += productPrice;
        }

        public void DeleteProduct(string product, double productPrice)
        {
            foreach (string item in this.Contents)
            {
                if (item == product)
                {
                    this.Contents.Remove(item);
                    this.Price -= productPrice;
                }
            }
        }

        public double CalculateDiscountPrice(double percent)
        {
            double discount = percent / 100;
            return this.Price - this.Price * discount;
        }

        public double CalculateAverageItemPrice()
        {
            return this.Price / this.Contents.Count;
        }
    }
}

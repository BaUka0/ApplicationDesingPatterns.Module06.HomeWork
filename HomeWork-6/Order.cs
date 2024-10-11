using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
    public interface ICloneable
    {
        Object Clone();
    }
    public class Product : ICloneable
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public Product() { }
        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }
        public Object Clone()
        {
            return new Product(Name, Price);
        }
    }
    public class Discount : ICloneable
    {
        public string Type { get; set; }
        public int Percentage { get; set; }
        public Discount() { }
        public Discount(string type, int percentage)
        {
            Type = type;
            Percentage = percentage;
        }
        public Object Clone()
        {
            return new Discount(Type, Percentage);
        }
    }

    public class Order : ICloneable
    {
        public List<Product> Products { get; set; }
        public int DeliveryPrice { get; set; }
        public List<Discount> Discounts { get; set; }
        public string PaymentMethod {  get; set; }
        public Order() { }
        public Order(List<Product> products, int deliveryPrice, List<Discount> discounts, string paymentMethod)
        {
            Products = products;
            DeliveryPrice = deliveryPrice;
            Discounts = discounts;
            PaymentMethod = paymentMethod;
        }
        public Object Clone()
        {
            return new Order(Products, DeliveryPrice, Discounts, PaymentMethod);

        }
    }
}

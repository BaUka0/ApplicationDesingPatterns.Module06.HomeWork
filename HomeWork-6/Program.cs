using System;
namespace HomeWork_6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*ReportDirector textReportDirector = new ReportDirector(new TextReportBuilder());
            textReportDirector.BuildReport("ЗReport Header", "This is the content of the report.", "Report Footer", new ReportStyle { BackgroundColor = "white", FontColor = "black", FontSize = 12 });
            Report textReport = textReportDirector.GetReport();
            Console.WriteLine(" report:");
            Console.WriteLine(textReport);

            ReportDirector htmlReportDirector = new ReportDirector(new HtmlReportBuilder());
            htmlReportDirector.BuildReport("Report Header", "This is the content of the report.", "Report Footer", new ReportStyle { BackgroundColor = "white", FontColor = "black", FontSize = 12 });
            Report htmlReport = htmlReportDirector.GetReport();
            Console.WriteLine("\nHTML-report:");
            Console.WriteLine(htmlReport);

            ReportDirector xmlReportDirector = new ReportDirector(new XmlReportBuilder());
            xmlReportDirector.BuildReport("Report Header", "This is the content of the report.", "Report Footer", new ReportStyle { BackgroundColor = "white", FontColor = "black", FontSize = 12 });
            Report xmlReport = xmlReportDirector.GetReport();
            Console.WriteLine("\nXML-report:");
            Console.WriteLine(xmlReport);*/

            /*Order originalOrder = new Order(
                new List<Product> { new Product("Cable typec", 20), new Product("Charger", 30) },
                10,
                new List<Discount> { new Discount("BlackFriday", 5) },
                "Kaspi"
            );

            Order clonedOrder = (Order)originalOrder.Clone();

            clonedOrder.Products[0].Price = 25;
            clonedOrder.Discounts.Add(new Discount("KaspiJuma", 10));

            Console.WriteLine("Original Order:");
            PrintOrder(originalOrder);

            Console.WriteLine("\nCloned Order:");
            PrintOrder(clonedOrder);*/

        }
        static void PrintOrder(Order order)
        {
            Console.WriteLine($"Delivery Price: {order.DeliveryPrice}");
            Console.WriteLine($"Payment Method: {order.PaymentMethod}");
            Console.WriteLine("Products:");
            foreach (Product product in order.Products)
            {
                Console.WriteLine($"\t{product.Name}: {product.Price}");
            }
            Console.WriteLine("Discounts:");
            foreach (Discount discount in order.Discounts)
            {
                Console.WriteLine($"\t{discount.Type}: {discount.Percentage}%");
            }
        }
    }
}
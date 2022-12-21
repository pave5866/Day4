namespace Day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("CTRL + K + D Kodları düzenliyor.");

            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId= 2;
            product1.ProductName = "Pepsi 2.5 Litre";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 15;

            Product product2 = new Product();
            product2.Id = 2;
            product2.CategoryId = 3;
            product2.ProductName = "Fanta 2.5 Litre";
            product2.UnitPrice = 300;
            product2.UnitsInStock = 25;

            Product[] products = new Product[] {product1 , product2 };

            foreach (Product product in products)
            {
                Console.WriteLine("Ürünün İsmi: " + product.ProductName);
                Console.WriteLine("Ürünün Fiyatı: " + product.UnitPrice);
                Console.WriteLine("Ürünün Stok Adedi: " + product.UnitsInStock);
                Console.WriteLine("Ürünün Id'si: " + product.Id);
                Console.WriteLine("Ürünün Kategory Id'si: " + product.CategoryId);
                Console.WriteLine("*****************");

            }
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Add(product2);

            Console.ReadKey();
        }
    }
}
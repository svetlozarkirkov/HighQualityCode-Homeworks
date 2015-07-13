namespace Orders
{
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    using Models;

    public class DataMapper
    {
        private readonly string categoriesFileName;
        private readonly string productsFileName;
        private readonly string ordersFileName;

        public DataMapper(string categoriesFileName, string productsFileName, string ordersFileName)
        {
            this.categoriesFileName = categoriesFileName;
            this.productsFileName = productsFileName;
            this.ordersFileName = ordersFileName;
        }

        public DataMapper()
            : this("../../Data/categories.txt", "../../Data/products.txt", "../../Data/orders.txt")
        {
        }

        public IEnumerable<Category> GetAllCategories()
        {
            var categories = ReadFileLines(this.categoriesFileName, true);

            return categories
                .Select(categoryLine => categoryLine.Split(','))
                .Select(categoryLine => new Category
                {
                    Id = int.Parse(categoryLine[0]),
                    Name = categoryLine[1],
                    Description = categoryLine[2]
                });
        }

        public IEnumerable<Product> GetAllProducts()
        {
            var products = ReadFileLines(this.productsFileName, true);

            return products
                .Select(productLine => productLine.Split(','))
                .Select(productLine => new Product
                {
                    Id = int.Parse(productLine[0]),
                    Name = productLine[1],
                    CategoryId = int.Parse(productLine[2]),
                    UnitPrice = decimal.Parse(productLine[3]),
                    UnitsInStock = int.Parse(productLine[4])
                });
        }

        public IEnumerable<Order> GetAllOrders()
        {
            var orders = ReadFileLines(this.ordersFileName, true);
            
            return orders
                .Select(orderLine => orderLine.Split(','))
                .Select(orderLine => new Order
                {
                    Id = int.Parse(orderLine[0]),
                    ProductId = int.Parse(orderLine[1]),
                    Quantity = int.Parse(orderLine[2]),
                    Discount = decimal.Parse(orderLine[3]),
                });
        }

        private List<string> ReadFileLines(string filename, bool hasHeader)
        {
            var allLines = new List<string>();
            
            using (var reader = new StreamReader(filename))
            {
                string currentLine;
                if (hasHeader)
                {
                    reader.ReadLine();
                }

                while ((currentLine = reader.ReadLine()) != null)
                {
                    allLines.Add(currentLine);
                }
            }

            return allLines;
        }
    }
}

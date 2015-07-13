namespace Orders
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Threading;

    class TestClass
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            var dataMapper = new DataMapper();
            var categories = dataMapper.GetAllCategories();
            var products = dataMapper.GetAllProducts();
            var orders = dataMapper.GetAllOrders();

            // Names of the 5 most expensive products
            var mostExpensiveProducts = products
                .OrderByDescending(product => product.UnitPrice)
                .Take(5)
                .Select(product => product.Name);
            
            Console.WriteLine(string.Join(Environment.NewLine, mostExpensiveProducts));

            Console.WriteLine(new string('-', 10));

            // Number of products in each category
            var second = products
                .GroupBy(product => product.CategoryId)
                .Select(group => new
                {
                    Category = categories.First(c => c.Id == group.Key).Name, 
                    Count = group.Count()
                })
                .ToList();
            
            foreach (var item in second)
            {
                Console.WriteLine("{0}: {1}", item.Category, item.Count);
            }

            Console.WriteLine(new string('-', 10));

            // The 5 top products (by order Quantity)
            var topProductsByOrderQuantity = orders
                .GroupBy(order => order.ProductId)
                .Select(group => new
                {
                    Product = products.First(p => p.Id == group.Key).Name, 
                    Quantities = group.Sum(grpgrp => grpgrp.Quantity)
                })
                .OrderByDescending(q => q.Quantities)
                .Take(5);
            
            foreach (var item in topProductsByOrderQuantity)
            {
                Console.WriteLine("{0}: {1}", item.Product, item.Quantities);
            }

            Console.WriteLine(new string('-', 10));

            // The most profitable category
            var mostProfitableCategory = orders
                .GroupBy(o => o.ProductId)
                .Select(g => new
                {
                    CategoryId = products.First(p => p.Id == g.Key).CategoryId, 
                    Price = products.First(p => p.Id == g.Key).UnitPrice, 
                    Quantity = g.Sum(p => p.Quantity)
                })
                .GroupBy(gg => gg.CategoryId)
                .Select(grp => new
                {
                    CategoryName = categories.First(c => c.Id == grp.Key).Name, 
                    TotalQuantity = grp.Sum(g => g.Quantity * g.Price)
                })
                .OrderByDescending(g => g.TotalQuantity)
                .First();
            Console.WriteLine("{0}: {1}", 
                mostProfitableCategory.CategoryName, mostProfitableCategory.TotalQuantity);
        }
    }
}

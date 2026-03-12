using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new BikeStoresContext())
        {

            try
            {
                var q1 = context.Customers
                    .Select(c => new { c.FirstName, c.LastName, c.Email })
                    .ToList();

                Console.WriteLine("Query 1");
                foreach (var c in q1)
                    Console.WriteLine($"{c.FirstName} {c.LastName} - {c.Email}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Query 1 Error: {ex.Message}");
            }



            try
            {
                var q2 = context.Orders.Where(o => o.StaffId == 3).ToList();

                Console.WriteLine("\nQuery 2");
                foreach (var o in q2)
                    Console.WriteLine($"Order ID: {o.OrderId}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Query 2 Error: {ex.Message}");
            }



            try
            {
                var q3 = context.Products
                    .Where(p => p.Category.CategoryName == "Mountain Bikes")
                    .ToList();

                Console.WriteLine("\nQuery 3");
                foreach (var p in q3)
                    Console.WriteLine(p.ProductName);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Query 3 Error: {ex.Message}");
            }



            try
            {
                var q4 = context.Orders
                    .GroupBy(o => o.StoreId)
                    .Select(g => new { Store = g.Key, TotalOrders = g.Count() })
                    .ToList();

                Console.WriteLine("\nQuery 4");
                foreach (var s in q4)
                    Console.WriteLine($"Store {s.Store} Orders {s.TotalOrders}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Query 4 Error: {ex.Message}");
            }



            try
            {
                var q5 = context.Orders.Where(o => o.ShippedDate == null).ToList();

                Console.WriteLine("\nQuery 5");
                foreach (var o in q5)
                    Console.WriteLine($"Order {o.OrderId} not shipped");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Query 5 Error: {ex.Message}");
            }



            try
            {
                var q6 = context.Customers
                    .Select(c => new
                    {
                        Name = c.FirstName + " " + c.LastName,
                        OrdersCount = c.Orders.Count()
                    }).ToList();

                Console.WriteLine("\nQuery 6");
                foreach (var c in q6)
                    Console.WriteLine($"{c.Name} Orders: {c.OrdersCount}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Query 6 Error: {ex.Message}");
            }



            try
            {
                var q7 = context.Products
                    .Where(p => !context.OrderItems.Any(oi => oi.ProductId == p.ProductId))
                    .ToList();

                Console.WriteLine("\nQuery 7");
                foreach (var p in q7)
                    Console.WriteLine(p.ProductName);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Query 7 Error: {ex.Message}");
            }



            try
            {
                var q8 = context.Stocks
                    .Where(s => s.Quantity < 5)
                    .Select(s => s.Product)
                    .Distinct()
                    .ToList();

                Console.WriteLine("\nQuery 8");
                foreach (var p in q8)
                    Console.WriteLine(p.ProductName);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Query 8 Error: {ex.Message}");
            }



            try
            {
                var q9 = context.Products.FirstOrDefault();

                Console.WriteLine("\nQuery 9");

                if (q9 != null)
                    Console.WriteLine(q9.ProductName);
                else
                    Console.WriteLine("No products found");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Query 9 Error: {ex.Message}");
            }



            try
            {
                var q10 = context.Products.Where(p => p.ModelYear == 2018).ToList();

                Console.WriteLine("\nQuery 10");
                foreach (var p in q10)
                    Console.WriteLine(p.ProductName);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Query 10 Error: {ex.Message}");
            }



            try
            {
                var q11 = context.Products
                    .Select(p => new
                    {
                        p.ProductName,
                        OrdersCount = p.OrderItems.Count()
                    }).ToList();

                Console.WriteLine("\nQuery 11");
                foreach (var p in q11)
                    Console.WriteLine($"{p.ProductName} Orders {p.OrdersCount}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Query 11 Error: {ex.Message}");
            }



            try
            {
                var q12 = context.Products
                    .Where(p => p.Category.CategoryName == "Mountain Bikes")
                    .Count();

                Console.WriteLine("\nQuery 12");
                Console.WriteLine($"Total Products: {q12}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Query 12 Error: {ex.Message}");
            }



            try
            {
                var q13 = context.Products.Average(p => p.ListPrice);

                Console.WriteLine("\nQuery 13");
                Console.WriteLine($"Average Price {q13}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Query 13 Error: {ex.Message}");
            }



            try
            {
                var q14 = context.Products.FirstOrDefault(p => p.ProductId == 5);

                Console.WriteLine("\nQuery 14");
                if (q14 != null)
                    Console.WriteLine(q14.ProductName);
                else
                    Console.WriteLine("Product not found");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Query 14 Error: {ex.Message}");
            }



            try
            {
                var q15 = context.OrderItems
                    .Where(oi => oi.Quantity > 3)
                    .Select(oi => oi.Product)
                    .Distinct()
                    .ToList();

                Console.WriteLine("\nQuery 15");
                foreach (var p in q15)
                    Console.WriteLine(p.ProductName);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Query 15 Error: {ex.Message}");
            }



            try
            {
                var q16 = context.Staffs
                    .Select(s => new
                    {
                        Name = s.FirstName + " " + s.LastName,
                        OrdersCount = s.Orders.Count()
                    }).ToList();

                Console.WriteLine("\nQuery 16");
                foreach (var s in q16)
                    Console.WriteLine($"{s.Name} Orders {s.OrdersCount}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Query 16 Error: {ex.Message}");
            }



            try
            {
                var q17 = context.Staffs
                    .Where(s => s.Active)
                    .Select(s => new { s.FirstName, s.LastName, s.Phone })
                    .ToList();

                Console.WriteLine("\nQuery 17");
                foreach (var s in q17)
                    Console.WriteLine($"{s.FirstName} {s.LastName} - {s.Phone}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Query 17 Error: {ex.Message}");
            }



            try
            {
                var q18 = context.Products
                    .Select(p => new
                    {
                        p.ProductName,
                        Brand = p.Brand.BrandName,
                        Category = p.Category.CategoryName
                    }).ToList();

                Console.WriteLine("\nQuery 18");
                foreach (var p in q18)
                    Console.WriteLine($"{p.ProductName} - {p.Brand} - {p.Category}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Query 18 Error: {ex.Message}");
            }



            try
            {
                var q19 = context.Orders.Where(o => o.OrderStatus == 4).ToList();

                Console.WriteLine("\nQuery 19");
                foreach (var o in q19)
                    Console.WriteLine($"Completed Order {o.OrderId}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Query 19 Error: {ex.Message}");
            }



            try
            {
                var q20 = context.Products
                    .Select(p => new
                    {
                        p.ProductName,
                        TotalSold = p.OrderItems.Sum(oi => (int?)oi.Quantity) ?? 0
                    }).ToList();

                Console.WriteLine("\nQuery 20");
                foreach (var p in q20)
                    Console.WriteLine($"{p.ProductName} Sold {p.TotalSold}");
            }
            catch (Exception ex)
            { 
                Console.WriteLine($"Query 20 Error: {ex.Message}");
            }

        }
    }
}
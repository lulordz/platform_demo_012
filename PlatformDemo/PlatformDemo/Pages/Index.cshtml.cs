using Data.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PlatformDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            //FOR TESTING PURPOSES OF ADDING RECORDS TO THE CUSTOMER AND ORDER
            /* 1st attempt of adding single customer with 1 order
            var context = new PlatformDemoContext();

            var customer = new Customer { Name = "John Doe", PhoneNumber = "09388829932" };
            context.Customers.Add(customer);

            var order = new Order { OrderNumber = 111, Amount = 5, Customer = customer };
            context.Orders.Add(order);

            context.SaveChanges();
            */
            
            /*2nd attempt on adding 2 customers with 1 customer of 2 orders and 1 customer of no orders
            var context = new PlatformDemoContext();

            var customer = new Customer { Name = "James Sy", PhoneNumber = "0966848584" };
            context.Customers.Add(customer);

            var order1 = new Order { OrderNumber = 112, Amount = 6, Customer = customer };
            context.Orders.Add(order1);

            var order2 = new Order { OrderNumber = 113, Amount = 9, Customer = customer };
            context.Orders.Add(order2);


            var customer2 = new Customer { Name = "Hey Test", PhoneNumber = "093483444" };
            context.Customers.Add(customer2);

            context.SaveChanges();
            */
        }
    }
}
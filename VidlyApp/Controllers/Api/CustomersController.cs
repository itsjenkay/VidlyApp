using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using VidlyApp.Models;

namespace VidlyApp.Controllers.Api
{
    public class CustomersController : ApiController
    {
        private VidlyContext _context;

        public CustomersController()
        {
            _context = new VidlyContext();
        }

        //GET /api/customer
        public IEnumerable<Customer> GetCustomers()
        {
            return _context.Customers.ToList();
        }
        //GET/api/customer/1
        public Customer GetCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            else
            {
                return customer;
            }
        }

        //POST /api/customers
       
        [HttpPost]
        public Customer CreateCustomer(Customer customer)
        {
            try
            {
                if (!ModelState.IsValid)
                    throw new HttpResponseException(HttpStatusCode.BadRequest);
                _context.Customers.Add(customer);
                _context.SaveChanges();

                return customer;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        //PUT/api/customer/1
        [HttpPut]
        public void UpdateCustomer(int id, Customer customer)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            var customerInDB = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDB == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            customerInDB.Birthdate = customer.Birthdate;
            customerInDB.Name = customer.Name;
            customerInDB.MembershipType = customer.MembershipType;
            customerInDB.IsSubscribedToNewsLetter = customer.IsSubscribedToNewsLetter;

            _context.SaveChanges();
        }

        [HttpDelete]
        public void DeleteCustomer(int id)
        {
            var customerInDB = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customerInDB == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            _context.Customers.Remove(customerInDB);
            _context.SaveChanges();
        }
    }
}

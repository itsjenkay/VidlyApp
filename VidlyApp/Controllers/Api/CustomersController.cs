using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using VidlyApp.Models;
using VidlyApp.App_Start;
using AutoMapper;
using VidlyApp.Dtos;
 

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
        public IEnumerable<CustomersDto> GetCustomers()
        {
          return _context.Customers.ToList().Select(Mapper.Map<Customer, CustomersDto>);
        }

        //GET/api/customer/1
        public IHttpActionResult GetCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return NotFound();
            else
            {
                return Ok( Mapper.Map<Customer, CustomersDto>(customer));
            }
        }

        //POST /api/customers
       
        [HttpPost]  
        public IHttpActionResult CreateCustomer(CustomersDto customerDto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();
                  //  throw new HttpResponseException(HttpStatusCode.BadRequest);

                var customer = Mapper.Map<CustomersDto, Customer>(customerDto);
                _context.Customers.Add(customer);
                _context.SaveChanges();
                customerDto.Id = customer.Id;

                return Created(new Uri(Request.RequestUri+"/"+customer.Id),customerDto);
            }
            catch (Exception )
            {
                return null;
            }
        }

        //PUT/api/customer/1
        [HttpPut]
        public void UpdateCustomer(int id, CustomersDto customerDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            var customerInDB = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDB == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(customerDto, customerInDB);
      
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

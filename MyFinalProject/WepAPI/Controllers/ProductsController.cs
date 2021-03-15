using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //Loosely coupled
        //Naming convention
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            //Dependency chain
            var result = _productService.GetAllByCategoryId(1);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
            //return new List<Product>
            //{
            //    new Product{ ProductId=1, ProductName="asd"},
            //    new Product{ ProductId=2, ProductName="qwe"}
            //};
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            //Dependency chain
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
           
        }


        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
    }
}

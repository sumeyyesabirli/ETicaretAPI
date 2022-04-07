﻿using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        readonly private IProductWriteRepository _productWriteRepository;
        readonly private IProductReadRepository _productReadRepository;


        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;

        }

        [HttpGet]
        public async Task Get()
        {
            await _productWriteRepository.AddAsync(new() { Name = "C Product", Price = 1.500F, Stock =10,CreatedDate= DateTime.UtcNow });
            await _productWriteRepository.SaveAsync();
        }

       [HttpGet("{id}")]
      
       public async Task<IActionResult> Get(string id)
       {
           Product product = await _productReadRepository.GetByIdAsync(id);
           return Ok(product);
       }


    }
}
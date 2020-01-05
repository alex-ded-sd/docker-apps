using api.Models;
using api.Services;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;

namespace api.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class ProductsController : ControllerBase
	{
		private readonly ProductService _productService;
		public ProductsController(ProductService productService)
		{
			this._productService = productService;
		}

		[HttpPost]
		[Route("create")]
		public IActionResult Create([FromBody]string productName)
		{
			var id = ObjectId.GenerateNewId().ToString();
			Product product = new Product
			{
				Id = id,
				Name = productName
			};
			_productService.Create(product);
			Product createdProduct = _productService.Get(id);
			return Ok(createdProduct);
		}
	}
}
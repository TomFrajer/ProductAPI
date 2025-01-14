using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/v1/products")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly ProductDbContext _context;

    public ProductsController(ProductDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] int page = 1, [FromQuery] int pageSize = 10)
    {
        var products = await _context.Products
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
        return Ok(products);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var product = await _context.Products.FindAsync(id);
        if (product == null) return NotFound();
        return Ok(product);
    }

    [HttpPatch("{id}")]
    public async Task<IActionResult> UpdateDescription(int id, [FromBody] string description)
    {
        var product = await _context.Products.FindAsync(id);
        if (product == null) return NotFound();
        product.Description = description;
        await _context.SaveChangesAsync();
        return NoContent();
    }
}

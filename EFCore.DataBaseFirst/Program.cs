using EFCore.DataBaseFirst.DAL;
using Microsoft.EntityFrameworkCore;

DbContextInitializer.Build();

using (var _context = new AppDbContext())
{
    var products = await _context.Products.ToListAsync();

    products.ForEach(p =>
    {
        Console.WriteLine($" Id: {p.Id} İsmi: {p.Name}  Fiyat : {p.Prices}  Stok: {p.Stock}");
    });
}
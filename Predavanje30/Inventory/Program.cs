using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Inventory.Data;

var serviceProvider = new ServiceCollection()
    .AddDbContext<InventoryContext>(options =>
        options.UseSqlServer("Server=DESKTOP-A9HN3IJ\\SQLEXPRESS;Database=Inventar;Trusted_Connection=True;"))
    .BuildServiceProvider();

// Stvaranje service scope-a za kontekst
using (var scope = serviceProvider.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<InventoryContext>();
    // Ovdje možeš dodati inicijalni kod za rad s bazom podataka
}

Console.WriteLine("Postavljanje projekta završeno.");

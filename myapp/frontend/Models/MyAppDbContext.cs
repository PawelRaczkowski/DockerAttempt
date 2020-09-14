using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore;


// W projektach w stylu zestawu SDK, takich jak ten, kilka atrybutów zestawu, kiedyś
// definiowanych w tym pliku, jest teraz automatycznie dodawanych podczas kompilacji
// i wypełnianych wartościami zdefiniowanymi we właściwościach projektu. Aby uzyskać
// szczegółowe informacje o tym, które atrybuty są dołączane i jak dostosować ten
// proces, zobacz: https://aka.ms/assembly-info-properties


// Ustawienie atrybutu ComVisible na wartość false sprawia, że typy w tym zestawie
// nie są widoczne dla składników modelu COM. Jeśli chcesz uzyskać dostęp do typu
// w tym zestawie z modelu COM, ustaw w tym typie atrybut ComVisible na wartość true.

//[assembly: ComVisible(false)]

// Następujący identyfikator GUID jest identyfikatorem elementu typelib w przypadku
// udostępnienia tego projektu w modelu COM.

//[assembly: Guid("ca22c5a9-035f-4f3a-b7ca-e406f1b70120")]

public class MyAppDbContext : DbContext
{
    public MyAppDbContext(DbContextOptions<MyAppDbContext> options) : base(options) { }
    public DbSet<Customer> Customers { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>().HasData(
            new Customer() 
            { Id = 1, Name = "Microsoft", VAT = "IE8256796U", Enabled = true },
            new Customer() { Id = 2, Name = "Google", VAT = "IE6388047V", Enabled = false })
            ; }
}
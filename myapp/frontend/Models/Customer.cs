using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

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

//[assembly: Guid("e18ee688-c3c8-4dc1-8fd3-f6bff3c1345f")]
public class Customer {
    public int Id { get; set; }
    [Required]
    [StringLength(200)]
    public string Name { get; set; }
    [Required] 
    [StringLength(16)]
    public string VAT { get; set; }
    public bool Enabled { get; set; }
}

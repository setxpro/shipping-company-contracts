namespace ShippingCompanyContracts.Contracts.Camilo;
public record CamiloDTO(string originUnit, string ufDestiny, string destinationCity, int term, string tda, string praca, string tipo);
public class Camilo
{
    public Guid Id { get; init; }
    public string OriginUnit { get; set; }
    public string UfDestiny { get; set; }
    public string DestinationCity { get; set; }
    public string Term { get; set; }
    public string Type { get; set; }

    public Camilo(string originUnit, string ufDestiny, string destinationCity, string term, string type)
    {
        Id = new Guid();
        OriginUnit = originUnit;
        UfDestiny = ufDestiny;
        DestinationCity = destinationCity;
        Term = term;
        Type = type;
    }
}
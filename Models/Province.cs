using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Province
{
    [Key]
    public string? ProvinceCode { get; set; }
    public string? ProvinceName { get; set; }
    public List<City>? Cities { get; set; }
}
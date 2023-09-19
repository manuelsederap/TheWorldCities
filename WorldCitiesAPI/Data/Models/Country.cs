using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace WorldCitiesAPI.Data.Models
{
    [Table("Countries")]
    [Index(nameof(Name))]
    [Index(nameof(ISO2))]
    [Index(nameof(ISO3))]
    public class Country
    {
        ///<summary>
        /// The unique id and primary key for this country
        /// </summary>
        [Key]
        [Required]
        public int Id { get; set; }

        ///<summary>
        /// Country Name (in UTF8 format)
        ///</summary>
        public string Name { get; set; } = null!;

        ///<summary>
        /// Country code (In ISO 3166-1 ALPHA-2 format)
        ///</summary>
        [JsonPropertyName("iso2")]
        public string ISO2 { get; set; } = null!;

        ///<summary>
        /// Country code (In ISO 3166-1 ALPHA-3 format)
        ///</summary>
        [JsonPropertyName("iso3")]
        public string ISO3 { get; set; } = null!;

        ///// Client side properties
        ///// <summary>
        ///// The number of cities related to this country.
        ///// </summary>
        //[NotMapped]
        //public int TotCities
        //{
        //    get
        //    {
        //        return (Cities != null)
        //        ? Cities.Count
        //        : _TotCities;
        //    }
        //    set
        //    {
        //        _TotCities = value;
        //    }
        //}

        //private int _TotCities = 0;


        /// Navigation Properties
        ///<summary>
        /// A collection of all the cities related to this country
        /// </summary>
        //[JsonIgnore]
        public ICollection<City> Cities { get; set; } = null!;
    }
}

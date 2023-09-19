using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorldCitiesAPI.Data.Models
{
    [Table("Cities")]
    [Index(nameof(Name))]
    [Index(nameof(Lat))]
    [Index(nameof(Lon))]
    public class City
    {
        /// <summary>
        /// The unique id and primary key for this city
        /// </summary>
        [Key]
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// City Name (in UTF8 format)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// City Latitude
        /// </summary>
        [Column(TypeName = "decimal(7,4)")]
        public decimal Lat { get; set; }

        ///<summary>
        /// City Longitude
        /// </summary>
        [Column(TypeName = "decimal(7,4)")]
        public decimal Lon { get; set; }

        ///<summary>
        /// Country Id (Foreign Key)
        /// </summary>
        [ForeignKey(nameof(Country))]
        public int CountryId { get; set; }

        ///<summary>
        /// The Country related to this City
        /// </summary>
        public Country? Country { get; set; } = null!;
    }
}

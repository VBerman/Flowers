using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace APIFlowers.Database.Models
{
    [Table("Order")]
    public class Order
    {
        public Order()
        {
            OrderServices = new HashSet<OrderService>();
            OrderFlowers = new HashSet<OrderFlower>();
        }
        [Key]
        public int Id { get; set; }
        [DataType(DataType.Date), Required]
        public DateTime Date { get; set; }

        [DataType(DataType.Date), Required]
        public DateTime ExpireDate { get; set; }

        [ForeignKey("Client"), Required]
        public int ClientId { get; set; }

        [ForeignKey("Status"), Required]
        public int StatusId { get; set; }

        public decimal BasicPrice { get; set; }


        public decimal TotalPrice { get; set; }

        //TODO need test [DataType(DataType.ImageUrl)]

        public string PhotoPath { get; set; }

        [JsonIgnore]
        public virtual ICollection<OrderService> OrderServices { get; set; }
        [JsonIgnore]
        public virtual ICollection<OrderFlower> OrderFlowers { get; set; }
    }
}

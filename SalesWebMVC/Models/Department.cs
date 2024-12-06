using System.Linq;
using Humanizer;

namespace SalesWebMVC.Models
{
    public class Department(int id, string name)
    {
        public int Id { get; set; } = id;
        public string Name { get; set; } = name;
        public ICollection<Seller> Sellers { get; set; } = [];

        public void AddSeller(Seller seller) { 
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}

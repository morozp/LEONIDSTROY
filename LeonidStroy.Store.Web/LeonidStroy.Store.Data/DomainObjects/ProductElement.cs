using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeonidStroy.Store.Data.DomainObjects
{
    public class ProductElement
    {
        
        public long Id { get; set; }
        public long ProductId { get; set; }
        public string Name { get; set; }
        public int CountInProduct { get; set; }
    }
}

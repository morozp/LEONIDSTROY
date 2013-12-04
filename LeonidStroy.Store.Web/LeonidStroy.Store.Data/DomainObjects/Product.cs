using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeonidStroy.Store.Data.DomainObjects
{
    public class Product
    {
        public long Id { get; set; }
        public long CategoryId { get; set; }
        public string Name { get; set; }
        public IList<ProductElement> Elements { get; set; }

    }
}
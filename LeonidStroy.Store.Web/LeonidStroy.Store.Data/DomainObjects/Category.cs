using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeonidStroy.Store.Data.DomainObjects
{
    public class Category
    {
        public long Id { get; set; }
        public long ParentId { get; set; }
        public string Name { get; set; }
        public IList<Product> Products { get; set; } 
    }
}

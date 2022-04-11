using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugConsume.Entity.Concrete
{
    public class DataEntity
    {
        public string Name { get; set; }
        public string GenericName { get; set; }
        public int Amount { get; set; }
        public string TypeOfMove { get; set; }
        public bool IsEntry { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime Date { get; set; }
    }
}

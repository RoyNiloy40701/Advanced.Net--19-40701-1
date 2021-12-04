using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BEnt
{
    public class ProductModel
    {
        public int pid { get; set; }
        public string pname { get; set; }
        public string description { get; set; }
        public string pcategory { get; set; }
        public int basicprice { get; set; }
        public Nullable<int> discountprice { get; set; }
        public Nullable<int> cid { get; set; }
    }
}

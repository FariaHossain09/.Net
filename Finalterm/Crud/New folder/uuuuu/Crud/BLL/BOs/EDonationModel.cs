using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BOs
{
    public class EDonationModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public Nullable<int> Ammount { get; set; }
    }
}

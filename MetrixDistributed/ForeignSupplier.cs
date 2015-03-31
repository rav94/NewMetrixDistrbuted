using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetrixDistributed
{
    class ForeignSupplier : Supplier
    {
        private string country;

        public string countryValue
        {
            get
            {
                return this.country;
            }
            set
            {
                country = value;
            }
        }
    }
}

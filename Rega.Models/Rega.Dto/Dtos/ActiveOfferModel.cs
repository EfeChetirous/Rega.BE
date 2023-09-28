using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rega.Dto.Dtos
{
    public class ActiveOfferModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string OfferResultMessage { get; set; }
        public string OfferDateRange { get; set; }
    }
}

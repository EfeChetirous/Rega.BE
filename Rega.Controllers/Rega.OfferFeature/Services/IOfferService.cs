using Rega.DataHandler.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rega.OfferFeature.Services
{
    public interface IOfferService
    {
        Product GetProductById(int id);
    }
}

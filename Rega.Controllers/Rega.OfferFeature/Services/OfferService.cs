using Rega.DataHandler.Entities;
using Rega.DataHandler.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rega.OfferFeature.Services
{
    public class OfferService : IOfferService
    {
        private readonly IRepository<Product> _productRepository;
        public OfferService(IRepository<Product> productRepository) 
        {
            _productRepository = productRepository;
        }

        public Product GetProductById(int id)
        {
            var entity = _productRepository.GetById(id);
            return entity;
        }
        
    }
}

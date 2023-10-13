using Rega.DataHandler.Entities;
using Rega.DataHandler.Repository;
using Rega.Dto.Dtos;
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
        private readonly IRepository<Offer> _offerRepository;
        public OfferService(IRepository<Product> productRepository, IRepository<Offer> offerRepository)
        {
            _productRepository = productRepository;
            _offerRepository = offerRepository;
        }

        public Offer GetActiveOfferByStaffId(int id)
        {
            var activeOffer = _offerRepository.Queryable().FirstOrDefault(x => x.UserId == id);
            return activeOffer;
        }
        public Product GetProductById(int id)
        {
            var entity = _productRepository.GetById(id);
            return entity;
        }

    }
}

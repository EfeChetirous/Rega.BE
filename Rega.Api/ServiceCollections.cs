using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Rega.DataHandler.Entities;
using Rega.DataHandler.Entity;
using Rega.DataHandler.Repository;
using Rega.OfferFeature.Services;
using Rega.OfferFeature.UseCases;
using Rega.OneToOneFeature.Services;
using Rega.OneToOneFeature.UseCases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Rega.OfferFeature
{
    public static class ServiceCollections
    {
        public static void AddCommonInfrastructure(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddDbContext<RegaDbContext>(opts => opts.UseSqlServer(configuration["ConnectionStrings:RegaDB"]));
            serviceCollection.AddScoped<IDataContext, RegaDbContext>();
            
            //repository
            serviceCollection.AddScoped<IRepository<Product>, Repository<Product>>();
            serviceCollection.AddScoped<IRepository<Offer>, Repository<Offer>>();
            serviceCollection.AddScoped<IRepository<OneToOne>, Repository<OneToOne>>();
            
            //services
            serviceCollection.AddScoped<IOfferService, OfferService>();
            serviceCollection.AddScoped<IOneToOneService, OneToOneService>();

            //usecases
            serviceCollection.AddScoped<IOfferUseCase, OfferUseCase>();
            serviceCollection.AddScoped<IOneToOneUseCase, OneToOneUseCase>();

        }
    }
}

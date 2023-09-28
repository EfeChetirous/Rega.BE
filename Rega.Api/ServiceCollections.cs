using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Rega.DataHandler.Entities;
using Rega.DataHandler.Entity;
using Rega.DataHandler.Repository;
using Rega.OfferFeature.Services;
using Rega.OfferFeature.UseCases;
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
            serviceCollection.AddScoped<IRepository<Product>, Repository<Product>>();
            serviceCollection.AddScoped<IOfferService, OfferService>();
            serviceCollection.AddScoped<IOfferUseCase, OfferUseCase>();
            
        }
    }
}

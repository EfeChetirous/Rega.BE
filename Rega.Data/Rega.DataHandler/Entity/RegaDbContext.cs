using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rega.DataHandler.Entity
{
    public class RegaDbContext : DataContext, IDisposable
    {
        public RegaDbContext(Microsoft.EntityFrameworkCore.DbContextOptions<RegaDbContext> options) : base(options)
        {

        }
    }
}

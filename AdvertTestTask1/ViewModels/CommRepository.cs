using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvertTestTask1.ViewModels
{
    public class CommRepository : ICommRepository
    {
        private CommissionContext _context;
        private ILogger<CommRepository> _loggerFactory;

        public CommRepository(CommissionContext context, ILogger<CommRepository> loggerFactory)
        {
            _context = context;
            _loggerFactory = loggerFactory;
        }
        public IEnumerable<Commission> GetAllCommissions()
        {
            _loggerFactory.LogInformation("Getting al commissions from the Database");
            return _context.Commissions.ToList();
        }
    }
}

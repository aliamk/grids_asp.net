using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grids.Context;
using Grids.IService;
using Grids.Models;

namespace Grids.Service
{
    public class FundService : IFundService             // implement interface
    {
        private readonly DatabaseContext _context;

        public FundService(DatabaseContext context)
        {
            _context = context;
        }
        public string Delete(int fundId)
        {
            var fund = _context.Funds.FirstOrDefault(x=>x.FundId == fundId);
            if (fund != null)
            {
                _context.Funds.Remove(fund);
                _context.SaveChanges();
            }

            return "Deleted";
        }

        public Fund GetById(int fundId)
        {
            return _context.Funds.SingleOrDefault(x => x.FundId == fundId);
        }

        public List<Fund> GetFunds()
        {
            return _context.Funds.ToList();
        }

        public void Save(Fund oFund)
        {
            _context.Funds.Add(oFund);
            _context.SaveChanges();
        }

        public void Update(Fund oFund)
        {
            _context.Funds.Update(oFund);
            _context.SaveChanges();
        }
    }
}

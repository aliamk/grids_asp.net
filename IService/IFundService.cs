using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grids.Models;

namespace Grids.IService
{
    public interface IFundService
    {
       
            List<Fund> GetFunds();
            Fund GetById(int fundId);
            void Save(Fund oFund);
            void Update(Fund oFund);
            string Delete(int fundId);
       
    }
}

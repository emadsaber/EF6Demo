using BL.Business.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Business.Contracts
{
    public interface IStandardHandler
    {
        StandardDTO GetStandardById(int id);
    }
}

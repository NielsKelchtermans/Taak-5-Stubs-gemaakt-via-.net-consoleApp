using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDoefening
{
    public class KostDAOStub : IKostDAO
    {
        public decimal TotaleKost()
        {
            return 100m;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDoefening
{
    public class WinstService
    {
        private readonly IOpbrengstDAO opbrengstDAO;
        private readonly IKostDAO kostDAO;
        public WinstService(IOpbrengstDAO opbrengstDAO, IKostDAO kostDAO)
        {
            this.kostDAO = kostDAO;
            this.opbrengstDAO = opbrengstDAO;
        }
        //property readonly
        public decimal Winst
        {
            get
            {
                throw new NotImplementedException();
            }
        }
            
    }
}

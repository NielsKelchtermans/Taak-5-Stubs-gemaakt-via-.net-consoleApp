using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDoefening;

namespace WinstServiceUnitTest
{
    [TestClass]
    public class WinstServiceTest
    {
        //initializeren van de interfacetypes en obj winstservice
        private IKostDAO kostDAO;
        private IOpbrengstDAO opbrengstDAO;
        private WinstService winstService;

        [TestInitialize]
        public void Initialize()
        {
            kostDAO = new KostDAOStub();
            opbrengstDAO = new OpbrengstDAOStub();
            winstService = new WinstService(opbrengstDAO, kostDAO);
        }

        [TestMethod]
        public void VindWinst()
        {
            
            Assert.AreEqual(900m, winstService.Winst);
        }
    }
}

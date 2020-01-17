using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDoefening;
using Moq;

namespace WinstServiceUnitTest
{
    [TestClass]
    public class WinstServiceTest
    {
        //initializeren van de interfacetypes en obj winstservice
        private IKostDAO kostDAO;
        private IOpbrengstDAO opbrengstDAO;
        private WinstService winstService;

        private Mock<IOpbrengstDAO> mockOpbrengstDAO;
        private Mock<IKostDAO> mockKostDAO;

        [TestInitialize]
        public void Initialize()
        {
            //kostDAO = new KostDAOStub();
            //opbrengstDAO = new OpbrengstDAOStub();
            mockOpbrengstDAO = new Mock<IOpbrengstDAO>();
            mockKostDAO = new Mock<IKostDAO>();
            opbrengstDAO = mockOpbrengstDAO.Object;
            kostDAO = mockKostDAO.Object;

            mockKostDAO.Setup(eenKostDAO => eenKostDAO.TotaleKost()).Returns(169m);
            mockOpbrengstDAO.Setup(eenOpbrengstDAO => eenOpbrengstDAO.TotaleOpbrengst()).Returns(200m);



            winstService = new WinstService(opbrengstDAO, kostDAO);
        }

        [TestMethod]
        public void VindWinst()
        {
            Assert.AreEqual(31m, winstService.Winst);
            mockKostDAO.Verify(eenKostDAO => eenKostDAO.TotaleKost());
            mockOpbrengstDAO.Verify(eenOpbrengstDAO => eenOpbrengstDAO.TotaleOpbrengst());
        }
    }
}

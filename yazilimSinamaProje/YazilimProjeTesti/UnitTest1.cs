using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using yazilimSinamaProje;
namespace YazilimProjeTesti
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DemirbasAdetBulTesti()
        {

            DemirbasStok DS = new DemirbasStok();
            int result = DS.demirbasAdediBul(15);
            Assert.AreEqual(172, result);
        }
        [TestMethod]
        public void KisiDogrulamaTesti()
        {
            kullanicilar kul = new kullanicilar();
            string result2 = kul.kisiDogrula("Kaan", "1111", 1);
            Assert.AreEqual("yetkili", result2);
        }
        [TestMethod]
        public void FakulteIDBulTesti()
        {
            fakulteBilgi fakulte = new fakulteBilgi();
            int result3 = fakulte.fakulteIDBul("Teknoloji");
            Assert.AreEqual(1, result3);
        }
    }
}

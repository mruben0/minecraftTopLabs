using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using minecraftTopLabs;

namespace mineTest
{
    [TestClass]
    public class minecraftTest
    {
        public mine testMine = new minecraftTopLabs.mine();
        public miner mukuch = new minecraftTopLabs.miner();


        [TestMethod]
        public void TestMethod1()
        {
            //փորձարկում եմ mine-ին amount կապելը

            testMine.gAmount = 7;
            Assert.AreEqual(7, testMine.gAmount);
        }

        [TestMethod]
        public void TestMethod2()
        {

            // փորձարկում եմ, որ հանքափորի առողջությունը հնարավոր չի 20-ից ավել դնել
            mukuch.gHealth = 8000;
            Assert.AreNotSame(8000, mukuch.gHealth);
            mukuch.gminerName = "MKO";
            testMine.gName = "MayBeURAN";

            //ստուգում եմ հանքափորի անունը
            Assert.AreEqual("MKO", mukuch.gminerName);
            
            //նշանակում և ստուգում եմ հանքի type-ը
            testMine.type = mineType.uran;
            Assert.AreNotEqual(mineType.silver, testMine.type);

            //amount-ը նշանակում եմ տաս հազարից ավել
            //ստուգում եմ դրա հնարավոր չլինելը
            testMine.gAmount = 10001;
            Assert.AreNotEqual(10001, testMine.gAmount);
            Assert.AreEqual(10000, testMine.gAmount);

            //Առողջւթյունը նշանակում եմ 1200
            //ստուգում եմ, որ քսանից ավել նշանակել չլինի
            mukuch.gHealth = 1200;
            Assert.AreEqual(20, mukuch.gHealth);
            mukuch.gPerHit = 150;
            Assert.AreEqual(100, mukuch.gPerHit);

            testMine.PH = mukuch.gPerHit;
            mukuch.mining = testMine.pooring;

            mukuch.working();
            //ստուգում եմ mining ֆունկցիան, որի դեպքում
            //delegate-ի շնորհիվ amount-ից կհանվի խաղացողի perHit-ը
            Assert.AreEqual(9900, testMine.gAmount);
            
        }

    }
}

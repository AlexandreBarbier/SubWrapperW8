using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using SubsonicWS;
using SubsonicWSTestUnit.Common;
using System;

namespace SubsonicWSTestUnit
{
    [TestClass]
    public class SubsonicWSTestSystem
    {
        [TestMethod()]
        public void TestConnectionPass()
        {
            ConnectionInformations.initConnection(Constants.Login, Constants.Password, Constants.Server, Constants.Port, Constants.Version, Constants.UniqId);
            SubsonicWS.SubSystem.Ping p = new SubsonicWS.SubSystem.Ping();
            var t = p.Init();
            while (!t.IsCompleted)
                t.Wait(10);
            Assert.AreEqual(SubsonicWS.Common.ResponseStatus.Ok, p.StatusValue);
        }

        [TestMethod()]
        public void TestConnectionError()
        {
            ConnectionInformations.initConnection("", Constants.Password, Constants.Server, Constants.Port, Constants.Version, Constants.UniqId);
            SubsonicWS.SubSystem.Ping p = new SubsonicWS.SubSystem.Ping();
            Assert.ThrowsException<AggregateException>(() =>
            {
                var t = p.Init();
                while (!t.IsCompleted)
                    t.Wait(10);
                Assert.AreEqual(SubsonicWS.Common.ResponseStatus.Ok, p.StatusValue);
            });
        }

        [TestMethod()]
        public void TestGetLicense()
        {
            ConnectionInformations.initConnection(Constants.Login, Constants.Password, Constants.Server, Constants.Port, Constants.Version, Constants.UniqId);
            SubsonicWS.SubSystem.GetLicence p = new SubsonicWS.SubSystem.GetLicence();
            var t = p.Init();
            while (!t.IsCompleted)
                t.Wait(10);
            
            Assert.IsNotNull(p.License);
        }
    }
}
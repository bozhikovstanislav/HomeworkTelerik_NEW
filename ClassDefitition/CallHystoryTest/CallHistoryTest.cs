
namespace CallHystoryTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using GSM;
    using System.Collections.Generic;
    
    [TestClass]
    public class CallHistoryTest
    {
        [TestMethod]
        public void readCall()
        {
            // arrange

            GSMPhone phone = new GSMPhone();
            Calls call1test=new Calls(DateTime.Now.Date,DateTime.Now,"8562231112",466,0.37);
            Calls call2 = new Calls(DateTime.Now.Date.AddDays(2), DateTime.Now.AddHours(2), "8566722344", 156,0.37);
            Calls call3 = new Calls(DateTime.Now.Date.AddDays(-4), DateTime.Now.AddHours(5), "8568905335", 500,0.37);

            // act

            phone.addCall(call1test);
            phone.addCall(call2);
            phone.addCall(call3);


            Calls callexpected = new Calls();
            callexpected = phone.CallHistory[0];

            // assert

            Assert.IsTrue(callexpected.Equals(call1test));
        }
    }
}

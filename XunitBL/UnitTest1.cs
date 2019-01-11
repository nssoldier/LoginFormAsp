using System;
using Xunit;
using BL;

namespace XunitBL
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            UserBl ubl = new UserBl();
            Assert.NotNull(ubl.GetAUser("account1","password1"));
        }
    }
}

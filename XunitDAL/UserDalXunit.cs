using System;
using Xunit;
using DAL;
namespace XunitDAL
{
    public class UserDalXunit
    {
        [Fact]
        public void Test1()
        {
            UserDal udal = new UserDal();
            Assert.NotNull(udal.GetUserByUserName("account1"));
            Console.WriteLine(udal.GetUserByUserName("account1").userName);
        }
    }
}

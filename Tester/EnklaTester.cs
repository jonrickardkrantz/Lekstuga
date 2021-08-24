using System;
using Xunit;

namespace Tester
{
    public class EnklaTester
    {
        [Fact]
        public void Test1()
        {
            int bigNumber = 215621;
            bigNumber = bigNumber + 1;
        }
        [Fact]
        public void Test2()
        {
            Assert.Equal(expected: 5, actual:2+3);
        }

        [Fact]
        public void purchaseDrink()
        {
            string purchaseADrink;
            int age = 20;

            if (age > 18)
            {
                purchaseADrink = "Beer";
            }
            else
            {
                purchaseADrink = "Coca-cola";
            }

            Assert.Equal(expected:"Beer", actual:purchaseADrink);
        }
    }
}

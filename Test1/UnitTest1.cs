using Xunit;

namespace Test1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arange 
            byte minValue;
            byte maxValue;

            //Act
            minValue = 0;
            maxValue = 255;

            //Assert

            Assert.Equal(minValue,byte.MinValue);
            Assert.Equal(maxValue,byte.MaxValue);
        }
    }
}
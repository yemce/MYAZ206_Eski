using Xunit;

namespace ValueAndReferenceTypesTests
{
    public class ValueAndReferenceTypesTests
    {
        [Fact]
        public void ReferenceTypesTests()
        {
            //Arrange

            var p1 = new ValueAndReferenceTypes.ReferenceTypes(3, 4);

            var p2 = p1;
            //Act
            
            p2.X = 10;

            //Assert

            Assert.Equal(p1.X , p2.X);
        }

        [Fact]

        public void ValueTypesTests()
        {
            //Arrange

            var s1 = new ValueAndReferenceTypes.ValueTypes(3, 4);
            var s2 = s1;

            //Act

            s2.X = 10;

            //Assert
            Assert.NotEqual(s1.X, s2.X);

        }
    }
}
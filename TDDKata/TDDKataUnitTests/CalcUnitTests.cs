using TDDKataCalc;
using Xunit;

namespace TDDKata;

public class CalcUnitTests
{
    [Theory]
    [InlineData(null, 0)]
    [InlineData("", 0)]
    [InlineData("   ", 0)]
    [InlineData("1", 1)]
    [InlineData("1,2", 3)]
    [InlineData("1,2,3", 6)]
    public void Add_Positive_SumEquals(string digits, int expectedResult)
    {
        // Arrange
        var target = new Calc();
        
        // Act
        var actualResult = target.Add(digits);
        
        // Assert
        Assert.Equal(expectedResult, actualResult);
    }

    [Theory]
    [InlineData("asd")]
    [InlineData("1,asd")]
    [InlineData("asd,1")]
    [InlineData("asd,1,1")]
    [InlineData("1,asd,1")]
    [InlineData("1,1,asd")]
    [InlineData(",")]
    [InlineData(",,")]
    [InlineData("999999999999999999999999999999")]
    [InlineData("999999999999999999999999999999,1")]
    [InlineData("1,999999999999999999999999999999")]
    [InlineData("999999999999999999999999999999,1,1")]
    [InlineData("1,999999999999999999999999999999,1")]
    [InlineData("1,1,999999999999999999999999999999")]
    public void Calc_Negative_ReturnsNegative1(string digits)
    {
        // Arrange
        var target = new Calc();
        const int expectedResult = -1;
        
        // Act
        var actualResult = target.Add(digits);
        
        // Assert
        Assert.Equal(expectedResult, actualResult);
    }
}
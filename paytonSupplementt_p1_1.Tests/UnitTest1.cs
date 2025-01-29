namespace paytonSupplementt_p1_1.Tests;

public class UnitTest1
{
    [Fact]
    public void ShouldCalcAreaOfRectangeWithDifferentLenAndWid()
    {
        Assert.True(50.0 == paytonSupplementt_p1_1.AreaOfRect(5.0, 10.0));
    }
}
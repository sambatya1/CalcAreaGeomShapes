
using CalcArea;
namespace MsTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void CalcTriangleArea()
    {
        // Tests that we expect to return true.       
        Triangle t = new Triangle(3, 4, 5);
        
            bool result = t.GetArea()==6.0;
            Assert.IsTrue(result,
                   string.Format("Expected for '{0}': true; Actual: {1}",
                                 6.0, result));
        
    }
    [TestMethod]
    public void CalcCircleArea()
    {
        // Tests that we expect to return true.       
        Circle c = new Circle(15);
        
            bool result = Math.Round(c.GetArea(),4)==706.8583;
            Assert.IsTrue(result,
                   string.Format("Expected for '{0}': true; Actual: {1}",
                                 6.0, result));
        
    }
}
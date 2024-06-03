using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_2;
using NUnit.Framework;

[TestFixture]
public class ProductTests
{
    // ProductID tests
    [Test]
    public void ProductID_SetCorrectly()
    {
        var product = new Product(1, "TestProduct", 10.0m, 5);
        Assert.That(product.ProductID, Is.EqualTo(1));
    }

    [Test]
    public void ProductID_MinimumValue()
    {
        var product = new Product(1, "TestProduct", 10.0m, 5);
        Assert.That(product.ProductID, Is.EqualTo(1));
    }

    [Test]
    public void ProductID_MaximumValue()
    {
        var product = new Product(1000, "TestProduct", 10.0m, 5);
        Assert.That(product.ProductID, Is.EqualTo(1000));
    }

    // ProductName tests
    [Test]
    public void ProductName_SetCorrectly()
    {
        var product = new Product(1, "TestProduct", 10.0m, 5);
        Assert.That(product.ProductName, Is.EqualTo("TestProduct"));
    }

    [Test]
    public void ProductName_EmptyString()
    {
        var product = new Product(1, "", 10.0m, 5);
        Assert.That(product.ProductName, Is.EqualTo(""));
    }

    [Test]
    public void ProductName_LongString()
    {
        var longName = new string('a', 100);
        var product = new Product(1, longName, 10.0m, 5);
        Assert.That(product.ProductName, Is.EqualTo(longName));
    }

    // Price tests
    [Test]
    public void Price_SetCorrectly()
    {
        var product = new Product(1, "TestProduct", 10.0m, 5);
        Assert.That(product.Price, Is.EqualTo(10.0m));
    }

    [Test]
    public void Price_MinimumValue()
    {
        var product = new Product(1, "TestProduct", 1.0m, 5);
        Assert.That(product.Price, Is.EqualTo(1.0m));
    }

    [Test]
    public void Price_MaximumValue()
    {
        var product = new Product(1, "TestProduct", 5000.0m, 5);
        Assert.That(product.Price, Is.EqualTo(5000.0m));
    }

    // Stock tests
    [Test]
    public void Stock_SetCorrectly()
    {
        var product = new Product(1, "TestProduct", 10.0m, 5);
        Assert.That(product.Stock, Is.EqualTo(5));
    }

    [Test]
    public void Stock_MinimumValue()
    {
        var product = new Product(1, "TestProduct", 10.0m, 1);
        Assert.That(product.Stock, Is.EqualTo(1));
    }

    [Test]
    public void Stock_MaximumValue()
    {
        var product = new Product(1, "TestProduct", 10.0m, 1000);
        Assert.That(product.Stock, Is.EqualTo(1000));
    }

    // IncreaseStock tests
    [Test]
    public void IncreaseStock_IncreaseStock()
    {
        var product = new Product(1, "TestProduct", 10.0m, 5);
        product.IncreaseStock(5);
        Assert.That(product.Stock, Is.EqualTo(10));
    }

    [Test]
    public void IncreaseStock_Zero()
    {
        var product = new Product(1, "TestProduct", 10.0m, 5);
        product.IncreaseStock(0);
        Assert.That(product.Stock, Is.EqualTo(5));
    }

    [Test]
    public void IncreaseStock_LargeValue()
    {
        var product = new Product(1, "TestProduct", 10.0m, 5);
        product.IncreaseStock(1000);
        Assert.That(product.Stock, Is.EqualTo(1005));
    }

    // DecreaseStock tests
    [Test]
    public void DecreaseStock_DecreaseStock()
    {
        var product = new Product(1, "TestProduct", 10.0m, 5);
        product.DecreaseStock(3);
        Assert.That(product.Stock, Is.EqualTo(2));
    }

    [Test]
    public void DecreaseStock_Zero()
    {
        var product = new Product(1, "TestProduct", 10.0m, 5);
        product.DecreaseStock(0);
        Assert.That(product.Stock, Is.EqualTo(5));
    }

    [Test]
    public void DecreaseStock_ShouldThrowException()
    {
        var product = new Product(1, "TestProduct", 10.0m, 5);
        Assert.Throws<InvalidOperationException>(() => product.DecreaseStock(6));
    }
}

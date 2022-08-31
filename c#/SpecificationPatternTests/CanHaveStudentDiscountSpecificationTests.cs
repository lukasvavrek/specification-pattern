using SpecificationPattern;

namespace SpecificationPatternTests;

public class CanHaveStudentDiscountSpecificationTests
{
    [Test]
    public void IsSatisfiedBy_PersonWith18yoAndStudent_ShouldHaveDiscount()
    {
        var person = new Person
        {
            Name = "John Doe",
            Age = 18,
            IsStudent = true
        };

        var canHaveDiscount = new CanHaveStudentDiscountSpecification().IsSatisfiedBy(person);
        
        Assert.IsTrue(canHaveDiscount);
    }
    
    [Test]
    public void IsSatisfiedBy_PersonWith18yoAndNotStudent_ShouldNotHaveDiscount()
    {
        var person = new Person
        {
            Name = "John Doe",
            Age = 18,
            IsStudent = false
        };

        var canHaveDiscount = new CanHaveStudentDiscountSpecification().IsSatisfiedBy(person);
        
        Assert.IsFalse(canHaveDiscount);
    }
    
    [Test]
    public void IsSatisfiedBy_PersonWith17yoAndStudent_ShouldHaveDiscount()
    {
        var person = new Person
        {
            Name = "John Doe",
            Age = 17,
            IsStudent = true
        };

        var canHaveDiscount = new CanHaveStudentDiscountSpecification().IsSatisfiedBy(person);
        
        Assert.IsTrue(canHaveDiscount);
    }
    
    [Test]
    public void IsSatisfiedBy_PersonWith17yoAndNotStudent_ShouldHaveDiscount()
    {
        var person = new Person
        {
            Name = "John Doe",
            Age = 17,
            IsStudent = false
        };

        var canHaveDiscount = new CanHaveStudentDiscountSpecification().IsSatisfiedBy(person);
        
        Assert.IsTrue(canHaveDiscount);
    }
}
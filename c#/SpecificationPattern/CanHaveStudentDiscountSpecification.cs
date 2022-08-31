namespace SpecificationPattern;

public sealed class CanHaveStudentDiscountSpecification : BaseSpecification<Person>
{
    public override bool IsSatisfiedBy(Person candidate) => 
        new HasLegalAgeSpecification().Not().Or(new IsStudentSpecification()).IsSatisfiedBy(candidate);
}
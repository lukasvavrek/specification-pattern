namespace SpecificationPattern;

public sealed class CanHaveStudentDiscountSpecification : BaseSpecification<Person>
{
    public override bool IsSatisfiedBy(Person candidate)
    {
        return new OrSpecification<Person>(
            new NotSpecification<Person>(new HasLegalAgeSpecification()),
            new IsStudentSpecification()
        ).IsSatisfiedBy(candidate);
    }
}
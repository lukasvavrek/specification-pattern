namespace SpecificationPattern;

public sealed class HasLegalAgeSpecification : BaseSpecification<Person>
{
    public override bool IsSatisfiedBy(Person candidate) => candidate.Age >= 18;
}
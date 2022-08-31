namespace SpecificationPattern;

public sealed class IsStudentSpecification : BaseSpecification<Person>
{
    public override bool IsSatisfiedBy(Person candidate) => candidate.IsStudent;
}
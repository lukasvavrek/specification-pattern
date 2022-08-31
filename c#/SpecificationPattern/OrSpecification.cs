namespace SpecificationPattern;

public sealed class OrSpecification<T> : BaseSpecification<T>
{
    public ISpecification<T> First { get; }
    public ISpecification<T> Second { get; }
    
    public OrSpecification(ISpecification<T> first, ISpecification<T> second)
    {
        First = first;
        Second = second;
    }

    public override bool IsSatisfiedBy(T candidate) => First.IsSatisfiedBy(candidate) || Second.IsSatisfiedBy(candidate);
}
namespace SpecificationPattern;

public abstract class BaseSpecification<T> : ISpecification<T>
{
    public abstract bool IsSatisfiedBy(T candidate);
}
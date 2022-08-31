namespace SpecificationPattern;

public interface ISpecification<in T>
{
    bool IsSatisfiedBy(T candidate);
}
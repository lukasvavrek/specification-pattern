namespace SpecificationPattern;

public sealed class NotSpecification<T> : BaseSpecification<T>
{
    public ISpecification<T> Subject { get; }
    
    public NotSpecification(ISpecification<T> subject)
    {
        Subject = subject;
    }

    public override bool IsSatisfiedBy(T candidate) => !Subject.IsSatisfiedBy(candidate);
}
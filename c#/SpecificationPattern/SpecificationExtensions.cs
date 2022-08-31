namespace SpecificationPattern;

public static class SpecificationExtensions
{
    public static ISpecification<T> Or<T>(this ISpecification<T> spec1, ISpecification<T> spec2) =>
        new OrSpecification<T>(spec1, spec2);
    
    public static ISpecification<T> And<T>(this ISpecification<T> spec1, ISpecification<T> spec2) => 
        new AndSpecification<T>(spec1, spec2);

    public static ISpecification<T> Not<T>(this ISpecification<T> spec) => 
        new NotSpecification<T>(spec);
}
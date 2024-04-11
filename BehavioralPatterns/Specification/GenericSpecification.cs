namespace Specification;

public class GenericSpecification<T>
{
    Expression<Func<T, bool>> Expression;
    public GenericSpecification(Expression<Func<T, bool>> expression)
    {
        Expression = expression;
    }

    public bool IsSatisfiedBy(T entity)
    {
        Expression.Compile().Invoke(entity);
    }
}
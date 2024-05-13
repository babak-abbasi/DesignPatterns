using System;
using System.Linq.Expressions;

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
        return Expression.Compile().Invoke(entity);
    }
}
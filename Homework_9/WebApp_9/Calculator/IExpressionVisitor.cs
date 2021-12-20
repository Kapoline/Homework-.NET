using System.Linq.Expressions;

namespace WebApp_9.Calculator
{
    public interface IExpressionVisitor
    {
        public Expression Visit(Expression expression);
    }
}
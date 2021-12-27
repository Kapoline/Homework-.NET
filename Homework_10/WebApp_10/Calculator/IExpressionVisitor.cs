using System.Linq.Expressions;

namespace WebApp_10.Calculator
{
    public interface IExpressionVisitor 
    {
        public Expression Visit(Expression expression);
    }
}
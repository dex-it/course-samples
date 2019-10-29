using System;
using System.Linq.Expressions;
using NUnit.Framework;

namespace Stage1
{
    public class ExpressionTests
    {
        [Test]
        public void ManuallyConfigureExpressionTest()
        {
            ParameterExpression numParam = Expression.Parameter(typeof(int), "num");
            ConstantExpression five = Expression.Constant(5, typeof(int));
            BinaryExpression numLessThanFive = Expression.LessThan(numParam, five);
            Expression<Func<int, bool>> lambda1 = Expression.Lambda<Func<int, bool>>(numLessThanFive,new ParameterExpression[] {numParam});
            var func = lambda1.Compile();

            Assert.IsTrue(func(4));
        }

        [Test]
        public void AutoConfigureExpressionTest()
        {
            Expression<Func<int, bool>> expr = num => num < 5;
            Func<int, bool> func = expr.Compile();  // компилируем наше дерево выражения в функцию

            Assert.IsFalse(func(5));
        }
    }
}
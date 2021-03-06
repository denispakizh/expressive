﻿using Expressive.Expressions;
using Expressive.Expressions.Binary.Bitwise;

namespace Expressive.Operators.Bitwise
{
    internal class BitwiseOrOperator : OperatorBase
    {
        #region OperatorBase Members

        public override string[] Tags => new[] { "|" };

        public override IExpression BuildExpression(Token previousToken, IExpression[] expressions, ExpressiveOptions options)
        {
            return new BitwiseOrExpression(expressions[0], expressions[1], options);
        }

        public override OperatorPrecedence GetPrecedence(Token previousToken)
        {
            return OperatorPrecedence.BitwiseOr;
        }

        #endregion
    }
}

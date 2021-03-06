﻿using System;
using System.Collections.Generic;
using Expressive.Exceptions;
using Expressive.Expressions;
using Expressive.Expressions.Binary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Expressive.Tests.Expressions.Binary
{
    [TestClass]
    public class BinaryExpressionBaseTests
    {
        [TestMethod, ExpectedException(typeof(MissingParticipantException))]
        public void TestNullLeftEvaluate()
        {
            var expression = new BinaryExpressionBaseImplementation(null, null, ExpressiveOptions.All);

            expression.Evaluate(null);
        }

        [TestMethod, ExpectedException(typeof(MissingParticipantException))]
        public void TestNullRightEvaluate()
        {
            var expression = new BinaryExpressionBaseImplementation(new BinaryExpressionBaseImplementation(null, null, ExpressiveOptions.All), null, ExpressiveOptions.All);

            expression.Evaluate(null);
        }

        private class BinaryExpressionBaseImplementation : BinaryExpressionBase
        {
            public BinaryExpressionBaseImplementation(IExpression lhs, IExpression rhs, ExpressiveOptions options) : base(lhs, rhs, options)
            {
            }

            protected override object EvaluateImpl(object lhsResult, IExpression rightHandSide, IDictionary<string, object> variables)
            {
                throw new NotImplementedException();
            }
        }
    }
}

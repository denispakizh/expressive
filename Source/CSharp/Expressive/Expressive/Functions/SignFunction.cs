﻿using Expressive.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expressive.Functions
{
    internal class SignFunction : FunctionBase
    {
        #region FunctionBase Members

        public override string Name { get { return "Sign"; } }

        public override object Evaluate(IExpression[] participants)
        {
            this.ValidateParameterCount(participants, 1, 1);

            var value = participants[0].Evaluate(Arguments);

            if (value != null)
            {
                var valueType = Type.GetTypeCode(value.GetType());

                switch (valueType)
                {
                    case TypeCode.Decimal:
                        return Math.Sign(Convert.ToDecimal(value));
                    case TypeCode.Double:
                        return Math.Sign(Convert.ToDouble(value));
                    case TypeCode.Int16:
                        return Math.Sign(Convert.ToInt16(value));
                    case TypeCode.UInt16:
                        return Math.Sign(Convert.ToUInt16(value));
                    case TypeCode.Int32:
                        return Math.Sign(Convert.ToInt32(value));
                    case TypeCode.UInt32:
                        return Math.Sign(Convert.ToUInt32(value));
                    case TypeCode.Int64:
                        return Math.Sign(Convert.ToInt64(value));
                    case TypeCode.SByte:
                        return Math.Sign(Convert.ToSByte(value));
                    case TypeCode.Single:
                        return Math.Sign(Convert.ToSingle(value));
                    default:
                        break;
                }
            }

            return null;
        }

        #endregion
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devsense.PHP.Syntax.Ast;

namespace Pchp.CodeAnalysis.Semantics
{
    static class ExpressionsExtension
    {
        public static T WithAccess<T>(this T expr, BoundAccess access) where T : BoundExpression
        {
            expr.Access = access;
            return expr;
        }

        public static T WithSyntax<T>(this T expr, LangElement syntax) where T : IPhpOperation
        {
            expr.PhpSyntax = syntax;
            return expr;
        }

        /// <summary>
        /// Gets value indicating the object will be an empty string after converting to string.
        /// </summary>
        public static bool IsEmptyStringValue(object value)
        {
            if (value == null)
                return true;

            if (value is string && ((string)value).Length == 0)
                return true;

            if (value is bool && ((bool)value) == false)
                return true;

            return false;
        }
    }
}

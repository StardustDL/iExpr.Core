﻿using System;
using System.Collections.Generic;
using System.Text;

namespace iExpr.Values
{
    public class ExprValue : IValue
    { 
        public IExpr Expr { get; set; }

        public string[] VariableNames { get; set; } 

        public bool IsConstant
        {
            get
            {
                return true;//TODO: Attention
                switch (Expr)
                {
                    case ConcreteToken c:
                        if (c.IsConstant == false) return false;
                        break;
                    default:
                        return false;
                }
                return true;
            }
        }

        public bool Equals(IExpr other)
        {
            if (!(other is ExprValue)) return false;
            return other.ToString() == this.ToString();
        }

        public override string ToString()//TODO: 注意这里实现不同，不是()=>()实现
        {
            return Expr?.ToString();
        }
    }
}

﻿using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Smc.Syntax
{
    public class Logic : Collection<Transition>, ISyntax
    {
        public Logic(IList<Transition> toList) : base(toList)
        {
        }

        public void Accept(ISyntaxVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
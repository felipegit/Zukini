﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zukini.PageSupport
{
    public class CurrentPageException 
        : Exception
    {
        public CurrentPageException(string message) 
            : base(message)
        {
        }
    }
}
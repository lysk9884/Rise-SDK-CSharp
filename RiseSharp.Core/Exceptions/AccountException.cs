﻿#region copyright
// <copyright file="AccountException.cs" >
// Copyright (c) 2016 Raj Bandi All Rights Reserved
// Licensed under MIT
// </copyright>
// <author>Raj Bandi</author>
// <date>16/7/2016</date>
// <summary></summary>
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiseSharp.Core.Exceptions
{
    public class AccountException : RiseSharpException
    {
        public AccountException()
        {
            
        }

        public AccountException(string message) : base(message)
        {
            
        }
    }
}

﻿#region copyright
// <copyright file="MultiSignaturesPendingRequest.cs" >
// Copyright (c) 2016 Raj Bandi All Rights Reserved
// Licensed under MIT
// </copyright>
// <author>Raj Bandi</author>
// <date>16/7/2016</date>
// <summary></summary>
#endregion
using RiseSharp.Core.Api.Messages.Common;
using RiseSharp.Core.Attributes;

namespace RiseSharp.Core.Api.Messages.Node
{
    public class MultiSignaturesPendingRequest : BaseRequest
    {
        [QueryParam(Name="publicKey")]
        public string PublicKey { get; set; }
    }
}

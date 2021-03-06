﻿#region copyright
// <copyright file="DelegateAddRequest.cs" >
// Copyright (c) 2016 All Rights Reserved
// Licensed under MIT
// </copyright>
// <author>Raj Bandi</author>
// <date>26/6/2016</date>
// <summary></summary>
#endregion
using System.Runtime.Serialization;
using RiseSharp.Core.Api.Messages.Common;

namespace RiseSharp.Core.Api.Messages.Node
{
    [DataContract]
    public class DelegateAddRequest : BaseRequest
    {
        [DataMember(Name = "secret")]
        public string Secret { get; set; }

        [DataMember(Name = "secondSecret")]
        public string SecondSecret { get; set; }

        [DataMember(Name = "publicKey")]
        public string PublicKey { get; set; }

        [DataMember(Name = "username")]
        public string Username { get; set; }
    }
}

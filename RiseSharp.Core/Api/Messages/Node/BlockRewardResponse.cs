﻿#region copyright
// <copyright file="BlockRewardResponse.cs" >
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
    public class BlockRewardResponse : BaseResponse
    {
        [DataMember(Name = "reward")]
        public int Reward { get; set; }
    }

}
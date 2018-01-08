#region copyright
// <copyright file="TransactionHelper.cs" >
// Copyright (c) 2016 All Rights Reserved
// Licensed under MIT
// </copyright>
// <author>Raj Bandi</author>
// <date>26/6/2016</date>
// <summary></summary>
#endregion
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiseSharp.Core.Extensions;
using NBitcoin;
using NBitcoin.BouncyCastle.Math;
using RiseSharp.Core.Api.Messages.Node;
using Transaction = RiseSharp.Core.Common.Transaction;

namespace RiseSharp.Core.Helpers
{
    public static class TransactionHelper
    {
        public static void SignTransaction(ref Transaction trs, string secret , string secondSecret = "")
        {
            var address = CryptoHelper.GetAddress(secret);
            var keyPair = address.KeyPair;

            trs.SenderId = address.IdString;
            trs.SenderPublicKey = keyPair.PublicKey.ToHex().ToLower();
           
            var hash = CryptoHelper.Sha256(trs.GetBytes());
            var signature = CryptoHelper.Sign(hash, keyPair.PrivateKey);
            trs.Signature = signature.ToHex().ToLower();

            if (!string.IsNullOrWhiteSpace(secondSecret))
            {
                signature = CryptoHelper.Sign(hash, CryptoHelper.GetKeyPair(secondSecret).PrivateKey);
                trs.SignSignature = signature.ToHex().ToLower();
            }

            trs.Id = CryptoHelper.GetId(trs.GetBytes());
        }

        public static int GetUnixTransactionTime()
        {
            var beginEpochTime = new DateTime(2016,05,24,17,0,0,DateTimeKind.Utc);
            var currentTime = DateTime.UtcNow;

            var beginEpochSeconds = beginEpochTime.ToUnixTimeInSeconds();
            var currentTimeSeconds = currentTime.ToUnixTimeInSeconds();

            var seconds = currentTimeSeconds - beginEpochSeconds;

            return seconds;
        }

        public static DateTime GetTransactionTime(int seconds)
        {
            var beginEpochTime = new DateTime(2016, 05, 24, 17, 0, 0, DateTimeKind.Utc);
            var epochTime = beginEpochTime.AddSeconds(seconds);
            var unixSeconds = epochTime.ToUnixTimeInSeconds();
            var utcDate = unixSeconds.FromUnixTimeSeconds();
            return utcDate;
        }

    }
}

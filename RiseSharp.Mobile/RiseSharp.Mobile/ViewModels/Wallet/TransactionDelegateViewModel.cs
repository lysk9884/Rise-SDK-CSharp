﻿#region copyright
// <copyright file="transactiondelegateviewmodel.cs" >
// Copyright (c) 2016 Raj Bandi All Rights Reserved
// Licensed under Apache 2.0
// </copyright>
// <author>Raj Bandi</author>
// <date>28/7/2016</date>
// <summary></summary>
#endregion
using RiseSharp.Mobile.Common;
using RiseSharp.Mobile.Models;

namespace RiseSharp.Mobile.ViewModels.Wallet
{
    public class TransactionDelegateViewModel : DetailViewModel
    {
        private WalletAddress _address;

        public TransactionDelegateViewModel() : base(Constants.TransactionDelegate)
        {
            
        }
        public WalletAddress Address
        {
            get
            {
                return _address;
            }
            set
            {
                SetProperty(ref _address, value);

            }
        }
    }
}

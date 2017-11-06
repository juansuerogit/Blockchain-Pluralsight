﻿using System;

namespace BlockChainCourse.BlockWithSingleTransaction
{
    public interface IBlock
    {
        string ClaimNumber { get; set; }
        decimal SettlementAmount { get; set; }
        DateTime SettlementDate { get; set; }
        string CarRegistration { get; set; }
        int Mileage { get; set; }
        ClaimType ClaimType { get; set; }

        int BlockNumber { get; }
        DateTime CreatedDate { get; }
        string BlockHash { get; }
        string PreviousBlockHash { get; set; }

        string CalculateBlockHash(string previousBlockHash);
        void SetBlockHash(IBlock parent);
        IBlock NextBlock { get; set; }
        void IsValidChain(string prevBlockHash);
    }
}

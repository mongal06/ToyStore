﻿namespace Contracts.Responses
{
    public class GetTransactionResponse
    {
        public int TransactionID { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionType { get; set; } = null!;
        public decimal Amount { get; set; }
        public string Description { get; set; } = null!;
    }
}
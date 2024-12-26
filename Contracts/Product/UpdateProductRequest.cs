﻿namespace Contracts.Requests
{
    public class UpdateProductRequest
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; } = null!;
        public int CategoryID { get; set; }
        public int SupplierID { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
    }
}
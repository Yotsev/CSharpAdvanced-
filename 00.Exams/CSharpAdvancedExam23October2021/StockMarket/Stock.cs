﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket
{
    public class Stock
    {

        public Stock(string companyName, string director, decimal pricePerShare, int totalNumberOfShares)
        {
            this.CompanyName = companyName;
            this.Director = director;
            this.PricePerShare = pricePerShare;
            this.TotalNumberOfShares = totalNumberOfShares;
        }

        public string CompanyName { get; set; }
        public string Director { get; set; }
        public decimal PricePerShare { get; set; }
        public int TotalNumberOfShares { get; set; }
        public decimal MarketCapitalization { 
            get 
            {
                decimal result = this.PricePerShare * this.TotalNumberOfShares;
                return result;
            }  
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Company: {CompanyName}");
            sb.AppendLine($"Director: {Director}");
            sb.AppendLine($"Price per share: ${PricePerShare}");
            sb.Append($"Market capitalization: ${MarketCapitalization}");

            return sb.ToString().Trim();
        }
    }
}

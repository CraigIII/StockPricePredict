using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StockPricePredictApp
{
    public class ModelOutput
    {
        [ColumnName(@"Date")]
        public float[] date { get; set; }

        [ColumnName(@"Open")]
        public float open { get; set; }

        [ColumnName(@"High")]
        public float high { get; set; }

        [ColumnName(@"Low")]
        public float low { get; set; }

        [ColumnName(@"Last")]
        public float last { get; set; }

        [ColumnName(@"Close")]
        public float close { get; set; }

        [ColumnName(@"Total Trade Quantity")]
        public float total_Trade_Quantity { get; set; }

        [ColumnName(@"Turnover (Lacs)")]
        public float turnover__Lacs_ { get; set; }

        [ColumnName(@"Features")]
        public float[] features { get; set; }

        [ColumnName(@"Score")]
        public float score { get; set; }

    }
}

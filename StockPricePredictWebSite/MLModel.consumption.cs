﻿// This file was auto-generated by ML.NET Model Builder.
using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
namespace StockPricePredict
{
    public partial class MLModel
    {
        /// <summary>
        /// model input class for MLModel.
        /// </summary>
        #region model input class
        public class ModelInput
        {
            [LoadColumn(0)]
            [ColumnName(@"Date")]
            public string Date { get; set; }

            [LoadColumn(1)]
            [ColumnName(@"Open")]
            public float Open { get; set; }

            [LoadColumn(2)]
            [ColumnName(@"High")]
            public float High { get; set; }

            [LoadColumn(3)]
            [ColumnName(@"Low")]
            public float Low { get; set; }

            [LoadColumn(4)]
            [ColumnName(@"Last")]
            public float Last { get; set; }

            [LoadColumn(5)]
            [ColumnName(@"Close")]
            public float Close { get; set; }

            [LoadColumn(6)]
            [ColumnName(@"Total Trade Quantity")]
            public float Total_Trade_Quantity { get; set; }

            [LoadColumn(7)]
            [ColumnName(@"Turnover (Lacs)")]
            public float Turnover__Lacs_ { get; set; }

        }

        #endregion

        /// <summary>
        /// model output class for MLModel.
        /// </summary>
        #region model output class
        public class ModelOutput
        {
            [ColumnName(@"Date")]
            public float[] Date { get; set; }

            [ColumnName(@"Open")]
            public float Open { get; set; }

            [ColumnName(@"High")]
            public float High { get; set; }

            [ColumnName(@"Low")]
            public float Low { get; set; }

            [ColumnName(@"Last")]
            public float Last { get; set; }

            [ColumnName(@"Close")]
            public float Close { get; set; }

            [ColumnName(@"Total Trade Quantity")]
            public float Total_Trade_Quantity { get; set; }

            [ColumnName(@"Turnover (Lacs)")]
            public float Turnover__Lacs_ { get; set; }

            [ColumnName(@"Features")]
            public float[] Features { get; set; }

            [ColumnName(@"Score")]
            public float Score { get; set; }

        }

        #endregion

        private static string MLNetModelPath = Path.GetFullPath("MLModel.mlnet");

        public static readonly Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictEngine = new Lazy<PredictionEngine<ModelInput, ModelOutput>>(() => CreatePredictEngine(), true);


        private static PredictionEngine<ModelInput, ModelOutput> CreatePredictEngine()
        {
            var mlContext = new MLContext();
            ITransformer mlModel = mlContext.Model.Load(MLNetModelPath, out var _);
            return mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
        }

        /// <summary>
        /// Use this method to predict on <see cref="ModelInput"/>.
        /// </summary>
        /// <param name="input">model input.</param>
        /// <returns><seealso cref=" ModelOutput"/></returns>
        public static ModelOutput Predict(ModelInput input)
        {
            var predEngine = PredictEngine.Value;
            return predEngine.Predict(input);
        }

    }
}

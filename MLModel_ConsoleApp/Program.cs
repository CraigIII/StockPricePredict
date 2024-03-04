﻿
// This file was auto-generated by ML.NET Model Builder. 

using MLModel_ConsoleApp;

// Create single instance of sample data from first line of dataset for model input
MLModel.ModelInput sampleData = new MLModel.ModelInput()
{
    Date = @"2018-09-27",
    Open = 234.55F,
    High = 236.8F,
    Low = 231.1F,
    Last = 233.8F,
    Total_Trade_Quantity = 5082859F,
    Turnover__Lacs_ = 11859.95F,
};



Console.WriteLine("Using model to make single prediction -- Comparing actual Close with predicted Close from sample data...\n\n");


Console.WriteLine($"Date: {@"2018-09-27"}");
Console.WriteLine($"Open: {234.55F}");
Console.WriteLine($"High: {236.8F}");
Console.WriteLine($"Low: {231.1F}");
Console.WriteLine($"Last: {233.8F}");
Console.WriteLine($"Close: {233.25F}");
Console.WriteLine($"Total_Trade_Quantity: {5082859F}");
Console.WriteLine($"Turnover__Lacs_: {11859.95F}");


var predictionResult = MLModel.Predict(sampleData);
Console.WriteLine($"\n\nPredicted Close: {predictionResult.Score}\n\n");

Console.WriteLine("=============== End of process, hit any key to finish ===============");
Console.ReadKey();


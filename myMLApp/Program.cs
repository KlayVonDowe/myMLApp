using System;
using myMLApp;
using MyMLApp;

namespace myMLApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sampleData = new SentimentModel.ModelInput()
            {
                Col0 = "This restraunt was wonderful."
            };

            var result = SentimentModel.Predict(sampleData);

            string sentiment = result.Prediction == 1 ? "Positive" : "Negative";
            Console.WriteLine($"Text: {sampleData.Col0}\nSentiment: {sentiment}");
        }
    }
}

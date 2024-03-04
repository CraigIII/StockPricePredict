using System.Text;
using System.Text.Json;

namespace StockPricePredictApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnPredictClicked(object sender, EventArgs e)
        {
            string BaseAddress = DeviceInfo.Platform == DevicePlatform.Android
                    ? "https://10.0.2.2:57603" : "https://localhost:57603";
#if DEBUG
            HttpsClientHandlerService handler = new HttpsClientHandlerService();
            HttpClient Client = new HttpClient(handler.GetPlatformMessageHandler());
#else
            HttpClient Client = new HttpClient();
#endif
            object data = new
            {
                Date = Date.Date,
                Open = Open.Text,
                High = High.Text,
                Low = Low.Text,
                Last = Last.Text,
                Total_Trade_Quantity = Total_Trade_Quantity.Text,
                Turnover__Lacs = Turnover__Lacs.Text,
            };
            string Uri = $"{BaseAddress}/predict";
            string strContent = JsonSerializer.Serialize(data);
            var content = new StringContent(strContent, Encoding.UTF8, "application/json");
            HttpResponseMessage Response = await Client.PostAsync(Uri, content);
            Response.EnsureSuccessStatusCode();
            string Json = await Response.Content.ReadAsStringAsync();
            var Result = JsonSerializer.Deserialize<ModelOutput>(Json);
            float score = Result.score;
            await DisplayAlert("預測股價", $"{score}元", "關閉");
        }
    }

}

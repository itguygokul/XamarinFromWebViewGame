using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WebViewGame
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


          //  var htmlSource = new HtmlWebViewSource()
            //{
            //    Html = "<html><head><title>Xamarin Forms</title><script type=\"text/javascript\">function factorial(num) {       if (num === 0 || num === 1)                return 1;            for (var i = num - 1; i >= 1; i--)            {                num *= i;            }            return num;        }</script></head><body><h1>Xamrin.Forms</h1><p>This is an iOS web page.</p></body></html>"
            //};
            //webview1.Source = htmlSource;

          //  webview1.Source = new WebViewSource(){  }



        }

        async Task Handle_ClickedAsync(object sender, System.EventArgs e)
        {
            int number = 10;
            string result = await webview1.EvaluateJavaScriptAsync($"factorial({number})");
            await DisplayAlert("Call from Javascript", $"Factorial of {number} is {result}.", "OK");
        }
    }
}

using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace ServiceHost.Areas.Admininstration.Pages
{
    [Authorize()]
    public class IndexModel : PageModel
    {
        public List<Chart> BarLineDataSet { get; set; }

        public void OnGet()
        {

            BarLineDataSet = new List<Chart>
            {
                new Chart
                {
                    Label = "Apple",
                    Data = new List<int>{100,200,320,245,40},
                    BackgroundColor = "#ffcdb2",
                    BorderColor = "#b5838d"
                },                new Chart
                {
                    Label = "Samsung",
                    Data = new List<int>{100,75,125,300,20},
                    BackgroundColor = "#ffcdb2",
                    BorderColor = "#b5838d"
                }
            };
        }
    }

    public class Chart
    {
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }
        public List<int> Data { get; set; }
        public string BackgroundColor { get; set; }
        public string BorderColor { get; set; }

    }
}

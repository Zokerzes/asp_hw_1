using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;

namespace asp_hw_1.Pages
{
    public class InfoRestModel : PageModel
    {
        public List<Dictionary<string, string>> Restaurants = new List<Dictionary<string, string>>()
        {
            {new Dictionary<string, string>()
                {
                    {"restName","Кафе Графин"},
                    {"restStars","4,5"},
                    {"restKithenType","Итальянская, Русская, Бар, Европейская, Восточноевропейская"}
                }
            },
            {new Dictionary<string, string>()
                {
                    {"restName","Старый Мельник"},
                    {"restStars","4,5"},
                    {"restKithenType","Итальянская, Японская, Европейская, Гриль, Бар, Морепродукты, Барбекю, Суши, Русская, Восточноевропейская"}
                }
            },
            {new Dictionary<string, string>()
                {
                    {"restName","Римские Kаникулы"},
                    {"restStars","4"},
                    {"restKithenType","Итальянская, Морепродукты, Средиземноморская, Европейская, Центральноевропейская"}
                }
            } 
        };

        public Dictionary<string, string> RestDefault = new Dictionary<string, string>();
        public string restName ="", restStars = "", restKithenType ="";
        public int restSelect { get; set; } = 0;
        public int restCount = 1;

		public void RestSel(int num)
        {
            restSelect = num;
        }

        public void OnGet()
        {
            restCount = Restaurants.Count;
			RestDefault = Restaurants[restSelect];
            restName = RestDefault.GetValueOrDefault("restName").ToString();
            restStars = RestDefault.GetValueOrDefault("restStars").ToString();
            restKithenType = RestDefault.GetValueOrDefault("restKithenType").ToString();
        }
		//public IActionResult OnPost()
		//{
		//	return Page("/InfoRest");
		//}
	}
}

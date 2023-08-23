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
                    {"restName","���� ������"},
                    {"restStars","4,5"},
                    {"restKithenType","�����������, �������, ���, �����������, �������������������"}
                }
            },
            {new Dictionary<string, string>()
                {
                    {"restName","������ �������"},
                    {"restStars","4,5"},
                    {"restKithenType","�����������, ��������, �����������, �����, ���, ������������, �������, ����, �������, �������������������"}
                }
            },
            {new Dictionary<string, string>()
                {
                    {"restName","������� K�������"},
                    {"restStars","4"},
                    {"restKithenType","�����������, ������������, �����������������, �����������, ���������������������"}
                }
            } 
        };

        public Dictionary<string, string> RestDefault = new Dictionary<string, string>();
        public string restName ="", restStars = "", restKithenType ="";

        public void OnGet()
        {
            RestDefault = Restaurants[0];
            restName = RestDefault.GetValueOrDefault("restName").ToString();
            restStars = RestDefault.GetValueOrDefault("restStars").ToString();
            restKithenType = RestDefault.GetValueOrDefault("restKithenType").ToString();

        }
    }
}

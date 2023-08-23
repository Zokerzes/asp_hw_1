using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace asp_hw_1.Pages
{
    public class IndexModel : PageModel
    {
        Random rnd = new Random();
        public string? letter;
       
        char[] letters = Enumerable.Range('a', 'z' - 'a' + 1).Select(c => (char)c).ToArray();
        public IndexModel()
        {
            
        }

        public void OnGet()
        {
            letter = letters[rnd.Next(letters.Length)].ToString();
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesMovie.Pages;

public class IndexModel : PageModel
{
    public string ContentHello(){
        List<string> hello = new List<string>(){
        "Hello","std:cout >> \"Hello\"","System.out.println(\"Hello\")","Console.log(\"Hello\")","Console.WriteLine(\"Hello\")","printf(\"Hello\")"
        };
        Random ran = new Random();
        int ra = ran.Next(0,hello.Count - 1);
        string printHello = hello[ra];
        return printHello;
    }
    public int Rand (){
        Random ran = new Random();
        return ran.Next(0,999);
    }
    public string Total {get; set;}
    public void OnGet()
    {
        ViewData["Des"] = "Description: ";
        Total = "Total: ";
    }
}

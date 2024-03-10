using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PLACEMENT_CELL.Pages
{
    public class DetailsModel : PageModel
    {
        public bool hasData = false;
        public string firstName = "";
        public string lastName = "";
        public string companyName = "";



        public void OnGet()
        {
        }
        public void OnPost()
        {
            hasData = true;
            firstName = Request.Form["firstname"];
            lastName =  Request.Form["lastname"];
            companyName = Request.Form["companyname"];
        }
    }
}

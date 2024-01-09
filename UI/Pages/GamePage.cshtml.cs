using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;
using Models.Dto;

namespace UI.Pages
{
    public class GamePage : PageModel
    {
	    private readonly string GameFightUrl = "http://localhost:5096/controller/processFight";
		    
	    [BindProperty] public Player Player { get; set; } = new();
	    public Monster Monster { get; set; }
	    public ResultDto? Result;
	    
        public void OnGet()
        {
        }

		public async Task OnPostAsync()
		{
			if (!ModelState.IsValid) return;
			using var client = new HttpClient();
			var result = await client.PostAsJsonAsync(GameFightUrl, Player);
			Result = await result.Content.ReadFromJsonAsync<ResultDto>();
		}
    }
}
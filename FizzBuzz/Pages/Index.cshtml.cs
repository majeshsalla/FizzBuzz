using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace FizzBuzz.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public string Input { get; set; }

        public List<string> Result { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnPost()
        {
            try
            {
                Result = new List<string>();
                if (Input != null)
                {
                    var inputList = Input.Split(',');

                    foreach (var item in inputList)
                    {
                        if (Int64.TryParse(item, out _))
                        {
                            var parsedItem = Int64.Parse(item);

                            if (parsedItem % 3 == 0 && parsedItem % 5 == 0)
                                Result.Add("FizzBuzz");
                            else if (parsedItem % 3 == 0)
                                Result.Add("Fizz");
                            else if (parsedItem % 5 == 0)
                                Result.Add("Buzz");
                            else
                            {
                                Result.Add($"Divided {item} by 3");
                                Result.Add($"Divided {item} by 5");
                            }

                        }
                        else
                        {
                            Result.Add("Invalid Item");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
            }
        }

        public ActionResult OnPostWay2()
        {
            return RedirectToPage();
        }
    }
}

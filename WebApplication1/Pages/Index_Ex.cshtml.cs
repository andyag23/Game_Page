using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Pages
{
    public class Index_ExModel : PageModel
    {
        private readonly ILogger<Index_ExModel> _logger;

        public Index_ExModel(ILogger<Index_ExModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}

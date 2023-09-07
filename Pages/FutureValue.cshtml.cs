using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RazorApp.Models;

namespace RazorApp.Pages
{
    /**
    this is a constructor, the name must match the name of the class
    */
    public class FutureValueModel : PageModel
    {
        public decimal MonthlyInvestment { get; set; }
        public decimal YearlyInterestRate { get; set; }
        public int Years { get; set; }

        private readonly ILogger<FutureValueModel> _logger;

        public FutureValueModel(ILogger<FutureValueModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ViewData["FV"] = 0;
        }
        public void OnPost(FutureValue model)
        {
            ViewData["FV"] = model.CalculateFutureValue();
        }
    }
}
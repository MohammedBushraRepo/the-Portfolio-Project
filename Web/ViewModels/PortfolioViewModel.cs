using Microsoft.AspNetCore.Http;
using System;

namespace Web.ViewModels
{
    public class PortfolioViewModel
    {
        public Guid Id { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile File { get; set; } // For Files Which Comes from the Http Request

    }
}

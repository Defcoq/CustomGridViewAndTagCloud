using CustomGridViewAndTagCloud.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomGridViewAndTagCloud.ViewComponents
{
    public class ArtistCardViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(Artist artist)
        {
            return View(artist);
        }

    }
}

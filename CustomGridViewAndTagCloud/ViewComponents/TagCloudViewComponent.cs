using CustomGridViewAndTagCloud.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomGridViewAndTagCloud.ViewComponents
{
    public class TagCloudViewComponent : ViewComponent
    {
        private readonly DataContext _context;
        public TagCloudViewComponent()
        {
            _context = new DataContext(); ;
        }

        public IViewComponentResult Invoke()
        {
            var items = (from songs in _context.GetSong()
                         join genres in _context.GetAllGenre() on songs.GenreId equals
                         genres.GenreLookUpId
                         where songs.GenreId.HasValue
                         select new { genres.GenreName, songs.GenreId }).ToList();

            var grouped = items.GroupBy(s => s.GenreName).Select(
            gen => new { Name = gen.Key, Count = gen.Count() });


            var model = new TagCloud();


            foreach (var item in grouped)
            {
                var cti = new TagCloudItem
                {
                    DisplayText = item.Name,
                    Url = string.Concat("/Genres/", item.Name),
                    Weight = item.Count
                };

                model.AddItem(cti);
            }
            return View(model);
        }
    }
}

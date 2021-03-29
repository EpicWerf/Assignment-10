using Assignment_10.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_10.Components
{
    public class BowlingTeamViewComponent : ViewComponent
    {
        private BowlingLeagueContext context;
        public BowlingTeamViewComponent (BowlingLeagueContext ctx)
        {
            context = ctx;
        }

        public IViewComponentResult Invoke()
        {
            return View(context.Teams
                .Distinct()
                .OrderBy(b => b));
        }
    }
}

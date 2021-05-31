using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_School.Data;

namespace MVC_School.Components
{
    public class VakStudentenViewComponent : ViewComponent
    {
        private readonly SchoolDbContext _context;

        public VakStudentenViewComponent(SchoolDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var vakStudenten = await _context.VakStudenten
                .Include(b => b.Student)
                .Where(d => d.VakId == id)
                .ToListAsync();

            return View(vakStudenten);
        }
    }
}

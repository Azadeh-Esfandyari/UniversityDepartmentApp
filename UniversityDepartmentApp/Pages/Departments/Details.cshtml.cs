using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UniversityDepartmentApp.Data;
using UniversityDepartmentApp.Models;

namespace UniversityDepartmentApp.Pages.Departments
{
    public class DetailsModel : PageModel
    {
        private readonly UniversityDepartmentApp.Data.UniContext _context;

        public DetailsModel(UniversityDepartmentApp.Data.UniContext context)
        {
            _context = context;
        }

        public Department Department { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var department = await _context.Departments.FirstOrDefaultAsync(m => m.Id == id);
           
            if (department == null)
            {
                return NotFound();
            }
            else
            {
                ////Set the university property to be displayed in Details page
                var university = await _context.Universities.FindAsync(department.UniversityId);
                department.University = university;

                Department = department;
            }
            return Page();
        }
    }
}

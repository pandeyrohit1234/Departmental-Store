using AutoMapper;
using DepartmentalStore.Data.Model;
using DepartmentalStore.Data.Models;
using DepartmentalStore.UI;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDepartmentalStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly DepartmentalContext _context;

        private readonly IMapper _mapper;
        public StaffController(DepartmentalContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        


        [HttpGet]
        public List<StaffModel> GetStaff()
        {
            var query = _context.Staff.Include(a => a.Address).Include(b => b.Role);
            var result = query.ToList();
            return _mapper.Map<List<StaffModel>>(result);
        }

        // GET: api/Staffs/5
        [HttpGet("staff-member")]
        public List<StaffModel> GetByRole(string role,bool address=false)
        {
            
            IQueryable<Staff> query = _context.Staff.Where(A=>A.Role.RoleName==role).Include(b => b.Role);
            if (address == true)
            {
                query = query.Include(x => x.Address);
            }
            List<Staff> result = query.ToList();
            return _mapper.Map<List<StaffModel>>(result);
        }


         // POST: api/Staffs
        [HttpPost]
        public Staff CreateStaff(Staff staff)
            
        {
            _context.Staff.Add(staff);
            _context.SaveChanges();
            return null; 
        }

        // DELETE: api/Staffs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Staff>> DeleteStaff(long id)
        {
            var staff = await _context.Staff.FindAsync(id);
            if (staff == null)
            {
                return NotFound();
            }

            _context.Staff.Remove(staff);
            await _context.SaveChangesAsync();

            return staff;
        }

        private bool StaffExists(long id)
        {
            return _context.Staff.Any(e => e.StaffId == id);
        }
    }
}

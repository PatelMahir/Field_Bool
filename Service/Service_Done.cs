using Field_Bool.DB_Context;
using Field_Bool.DTOs;
using Field_Bool.Models;

namespace Field_Bool.Service
{
    public class Service_Done
    {
        private readonly AppDbContext _context;
        public Service_Done(AppDbContext context)
        {
            _context = context;
        }
        public Response GetZero()
        {
            var employees = _context.ABCs.ToList();             //.ToList(); // Fetch all employees
            var zeroIndices = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                if (employees[i].IsAvail)
                {
                    zeroIndices.Add(i);
                }
            }
            return new Response
            {
                Indices = zeroIndices.ToArray(),
                TotalCount = zeroIndices.Count
            };
        }
        //public Response GetZero()
        //{
        //    var employees = _context.ABCs.ToList(); // Fetch all employees
        //    var zeroIndices = employees
        //        .Select((employee, index) => new { employee, index })
        //        .Where(e => e.employee.IsAvail)
        //        .Select(e => e.index)
        //        .ToList();
        //    return new Response
        //    {
        //        Indices = zeroIndices.ToArray(),
        //        TotalCount = zeroIndices.Count
        //    };
        //}
    }
}
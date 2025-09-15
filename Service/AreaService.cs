using Case.Data;
using Case.Models;
using Microsoft.EntityFrameworkCore;

namespace Case.Service
{
    public class AreaService : IAreaService
    {
        private readonly AppDbContext _context;

        public AreaService(AppDbContext context)
        {
            _context = context;
        }
        public List<Area> GetAll()
        {
            var dbArea = _context.Areas.ToList();
            return dbArea;
        }

        public Area GetById(int id)
        {
            var areaId = _context.Areas.FirstOrDefault(c => c.Id == id);
            return areaId;
        }

        public Area AddArea(Area areaNova)
        {
            _context.Areas.Add(areaNova);
            _context.SaveChanges();
            return areaNova;
        }
    }
}

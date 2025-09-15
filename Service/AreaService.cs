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
            return _context.Areas.Where(c => c.Status == true).ToList();
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
        public Area SoftDelete(int id)
        {
           var area= _context.Areas.Find(id);
           if(area == null)
            {
                throw new Exception("Key nao encontrada");
            }
           if(area.Status == true)
            {
                area.Status = false;
                _context.SaveChanges();
                return area;
            }
            else
            {
                throw new Exception("Item ja deletado");
            }
        }
    }
}

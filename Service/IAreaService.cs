using Case.Models;

namespace Case.Service
{
    public interface IAreaService
    {
        public List<Area> GetAll();
        public Area GetById(int id);

        public Area AddArea(Area areaNova);
    }
}

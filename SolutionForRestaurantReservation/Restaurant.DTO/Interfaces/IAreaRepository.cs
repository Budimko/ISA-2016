using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DTO
{
    public interface IAreaRepository
    {
        int AddArea(Area area);
        void UpdateArea(Area area);
        void DeleteArea(int areaId);
        IEnumerable<Area> GetAllAreas();
        
    }
}

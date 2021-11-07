using System.Linq;
using System.Threading.Tasks;
using HotelManagement.Application.Contracts.Infrastructure;
using HotelManagement.Domain;

namespace HotelManagement.Infrastructure.Repositories
{
    public class RoomRepository : GenericRepository<Room>, IRoomRepository
    {
        public RoomRepository(ApplicationDbContext context) : base(context)
        {
        }

        public Task<string> GetLassRoomName(string floor)
        {
            string result;
            try
            {
                result = Context.Rooms
                    .Where(x => x.Name.Contains(floor))
                    .OrderByDescending(x => x.Name).First()
                    .Name;
            }
            catch
            {
                result = "P00";
            }
            return Task.FromResult(result);
        }
    }
}
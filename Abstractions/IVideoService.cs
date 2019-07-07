using System.Collections.Generic;
using System.Threading.Tasks;
using VideoChatApp.Models;

namespace VideoChatApp.Abstractions
{
    public interface IVideoService
    {
        string GetTwilioJwt(string identity);
        Task<IEnumerable<RoomDetails>> GetAllRoomsAsync();
    }
}

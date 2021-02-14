using GameExample.Entities;

namespace GameExample.Abstract
{
    public interface IGamerCheckService
    {
        bool CheckIfRealGamer(Gamer gamer);
    }
}

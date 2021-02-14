using GameExample.Abstract;
using GameExample.Entities;

namespace GameExample.Adapter
{
    public class GamerControlManagerAdapter:IGamerCheckService
    {
        public bool CheckIfRealGamer(Gamer gamer)
        {
            if (gamer.Id==1 && gamer.Name=="Onur"& gamer.LastName=="Altıntaş" && gamer.BirthOfDate.Year==1985 && gamer.NationalityId=="11111111111")
            {
                return true;
            }

            return false;
        }
    }
}

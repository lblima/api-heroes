using HerosApi2.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace HerosApi2.Controllers
{
    [Authorize]
    public class HeroesController : BaseApiController
    {
        private static List<Hero> HeroList;

        public HeroesController()
        {
            HeroList = new List<Hero>() { new Hero(1, "Hero 01"), new Hero(2, "Hero 02"), new Hero(3, "Hero 03") };
        }

        // GET api/values
        public IEnumerable<Hero> Get()
        {
            System.Threading.Thread.Sleep(1000);

            return HeroList;
        }

        // GET api/values/5
        public Hero Get(int id)
        {
            return HeroList.Find(x => x.Id == id);
        }
    }
}
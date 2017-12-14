using Microsoft.EntityFrameworkCore;

namespace BodySafe
{
    public class LobbyFactory
    {
        //--------------------------------------db static ----------------------------------------
        public static DbContextOptions<ApiContext> options = new DbContextOptions<ApiContext>();
        public static ApiContext db = new ApiContext(Options);
        public static DbContextOptions<ApiContext> Options { get => options; set => options = value; }
        //------------------------------------------------------------------------------------------

    }

}

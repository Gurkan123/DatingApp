using System.Threading.Tasks;
using DatingApp.API.Models;

namespace DatingApp.API.Data
{
    public interface IAuthRepository
    {
         Task<User> Register(User user, string password); //userdan oluşturacagı için User alıyor
         Task<User> Login(string username, string password);//alttakiyle aynı şekilde

         Task<bool> UserExists(string username);/*var olana bakıyor o yüzden string ayrıca
          bool true false işte var mı yok mu bu isimden*/
    }
}



using SelfTrainProject.Abstract;
using SelfTrainProject.Entities;
using SelfTrainProject.Services;
using System.Runtime.CompilerServices;

namespace SelfTrainProject
{
    public class Program
    {

        private static List<User> _users = new List<User>();
        static void Main(string[] args)
        {
            User updateduser = new User();
            IUserService simpleDatabase = new SimpleDatabase();

            DateTime dogumYili;

            Console.WriteLine("Kayıt ol!");
            Console.WriteLine("-----------");

            Console.WriteLine("TC Kimlik Numaranız:");
            string tcKimlikNo = Console.ReadLine();

            if (tcKimlikNo.Length == 11 && tcKimlikNo.All(char.IsDigit))
            {

            }
            else
            {
                Console.WriteLine("Geçersiz TC Kimlik Numarası!");
                tcKimlikNo = null;
            }


            Console.WriteLine("İsminiz:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Soy isminiz:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Doğum yılınızı YYYY-MM-DD formatında giriniz:");
            dogumYili = DateTime.Parse(Console.ReadLine());

            User user = new User(tcKimlikNo, firstName, lastName, dogumYili);


            simpleDatabase.UserRegister(user);
            Console.WriteLine($"Kullanıcı ismi : {user.FirstName}");
            Console.WriteLine("İsmini güncellemek istediğiniz TC Kimlik numarasını giriniz:");
            string Tckn = Console.ReadLine();
            Console.WriteLine("İsminizi giriniz:");
            string newFirstName = Console.ReadLine();
            updateduser.TcKimlikNo = Tckn;
            updateduser.FirstName = newFirstName;
            simpleDatabase.UpdateUser(updateduser);
            Console.WriteLine($"Kullanıcının güncellenmiş ismi : {user.FirstName}");

            GameServices.AddGame("RDR2", "Red Dead Redemption 2", 59.99);
            GameServices.AddGame("GTA5", "Grand Theft Auto V", 69.99);
            GameServices.AddGame("TLOU", "The Last Of Us", 49.99);


            GameServices.DisplayGames();







        }
    }
}
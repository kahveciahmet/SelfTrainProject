using SelfTrainProject.Abstract;
using SelfTrainProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfTrainProject.Services
{
    public class SimpleDatabase : IUserService
    {
        private List<User> _users;
        

        public SimpleDatabase() 
        { 
            
            _users = new List<User>();
        }
        public void UserRegister(User user)
        {
            SimpleDatabase simpleDatabase = new SimpleDatabase();

            if (ValidateUser(user)){
                _users.Add(user);
                Console.WriteLine("Kayıt Başarılı!");
            }
            else
            {
                Console.WriteLine("Geçersiz kullanıcı bilgileri! Kayıt başarısız oldu.");
            }
            

        }

        public void DeleteUser(User user)
        {
            if (user == null) {
                Console.WriteLine("Kullanıcı bulunamadı!");
            }
            _users.Remove(user);
            Console.WriteLine("Kullanıcı başarıyla silindi.");
        }

        public void UpdateUser(User user)
        {
           var updateduser = _users.Find(x=>x.TcKimlikNo== user.TcKimlikNo);
            updateduser.FirstName = user.FirstName;

        }



        private bool ValidateUser(User user)
        {
            return !string.IsNullOrEmpty(user.TcKimlikNo) && !string.IsNullOrEmpty(user.FirstName) && !string.IsNullOrEmpty(user.LastName) && user.DogumYili != DateTime.MinValue;
        }


    }
}

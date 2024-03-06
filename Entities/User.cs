using SelfTrainProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfTrainProject.Entities
{
    public class User:IEntity
    {
        public string TcKimlikNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DogumYili { get; set; }

        public User(string tcKimlikNo,string firstName,string lastName,DateTime dogumYili) 
        {
            TcKimlikNo = tcKimlikNo;
            FirstName = firstName;
            LastName = lastName;
            DogumYili = dogumYili;
        }

        public User()
        {

        }
    }


}

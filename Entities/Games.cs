using SelfTrainProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfTrainProject.Entities
{
    public class Games:IEntity
    {
        public string GameName { get; set; }
        public string GameData { get; set; }
        public double GamePrice { get; set; }

        
    }
}

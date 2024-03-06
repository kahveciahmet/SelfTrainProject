using SelfTrainProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfTrainProject.Entities
{
    public class Campaigns:IEntity
    {
        public string CampaignName { get; set; }
        public double DiscountRate { get; set;}
    }
}

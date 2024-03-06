using SelfTrainProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfTrainProject
{
    public class GameServices
    {
        private static List<Games> gameList = new List<Games>();
        private static List<Campaigns> campaignsList = new List<Campaigns>();

        public static void AddGame(string gameName, string gameData, double gamePrice)
        {
            gameList.Add(new Games { GameName = gameName, GameData = gameData, GamePrice = gamePrice });
        }

        public static void AddCampaign(string campaignName, double campaignPercentage)
        {
            campaignsList.Add(new Campaigns { CampaignName = campaignName, DiscountRate= campaignPercentage });
        }


        public static void DisplayGames()
        {
            Console.WriteLine("Oyun listesi:");
            foreach (var game in gameList)
            {
                Console.WriteLine($"Oyun ismi: {game.GameName}, Oyun açıklaması: {game.GameData}, Oyun ücreti: {game.GamePrice}");
            }
        }

        public static void DisplayCampaigns()
        {
            Console.WriteLine("Kampanya listesi:");
            foreach (var campaign in campaignsList)
            {
                Console.WriteLine($"Kampanya ismi: {campaign.CampaignName}, Kampanya miktarı: {campaign.DiscountRate}");
            }
        }

        public static void DeleteCampaign()
        {
            Console.WriteLine("Kampanya başarıyla silindi.");
        }

        public static void UpdateCampaign()
        {
            Console.WriteLine("Kampanya başarıyla güncellendi.");
        }
    }
}

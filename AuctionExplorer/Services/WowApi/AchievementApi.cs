using System;
using System.Threading.Tasks;
using AuctionExplorer.Models;

namespace AuctionExplorer.Services.WowApi
{
    public class AchievementApi
    {
        public AchievementApi(WowApiBase wowApiBase)
        {
            WowApiBase = wowApiBase;
        }

        private WowApiBase WowApiBase { get; }

        public async Task<GameAchievement> GetAchievement(int id, string nspace = "static-eu")
        {
            var requestedAchievement = await WowApiBase.WarcraftClient.GetAchievementAsync(id, nspace);

            if (requestedAchievement.Success)
            {
                return new GameAchievement()
                {
                    Id = requestedAchievement.Value.Id,
                    Name = requestedAchievement.Value.Name,
                    Description = requestedAchievement.Value.Description
                };
            }

            throw new Exception($"Failed to get achievement with id {id}");
        }
    }
}
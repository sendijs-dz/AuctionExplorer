using System;
using System.Threading.Tasks;
using AuctionExplorer.Models;

namespace AuctionExplorer.Services.WowApi
{
    public class ItemApi
    {
        public ItemApi(WowApiBase wowApiBase)
        {
            WowApiBase = wowApiBase;
        }

        private WowApiBase WowApiBase { get; }

        public async Task<GameItem> GetItem(int id, string nspace = "static-eu")
        {
            var requestedItem = await WowApiBase.WarcraftClient.GetItemAsync(id, nspace);

            if (requestedItem.Success)
            {
                return new GameItem()
                {
                    Id = requestedItem.Value.Id,
                    Name = requestedItem.Value.Name
                };
            }

            throw new Exception($"Failed to get item with id {id}");
        }
    }
}
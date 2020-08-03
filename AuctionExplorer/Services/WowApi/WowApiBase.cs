using ArgentPonyWarcraftClient;

namespace AuctionExplorer.Services.WowApi
{
    public class WowApiBase
    {
        internal WarcraftClient WarcraftClient { get; }

        public AchievementApi Achievement { get; private set; }
        
        public ItemApi Item { get; private set; }

        public WowApiBase(string clientId, string clientSecret)
        {
            WarcraftClient = new WarcraftClient(clientId, clientSecret);
            Achievement = new AchievementApi(this);
            Item = new ItemApi(this);
        }
    }
}
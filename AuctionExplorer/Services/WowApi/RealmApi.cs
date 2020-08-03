using System.Threading.Tasks;
using ArgentPonyWarcraftClient;

namespace AuctionExplorer.Services.WowApi
{
    public class RealmApi
    {
        private WowApiBase WowApiBase { get; }

        public RealmApi(WowApiBase wowApiBase)
        {
            WowApiBase = wowApiBase;
        }

        public async Task<RequestResult<RealmsIndex>> GetAllRealms(string nspace = "dynamic-eu")
        {
            return await WowApiBase.WarcraftClient.GetRealmsIndexAsync(nspace);
        }

        public async Task<RequestResult<ConnectedRealmsIndex>> GetAllConnectedRealms(string nspace = "dynamic-eu")
        {;
            return await WowApiBase.WarcraftClient.GetConnectedRealmsIndexAsync(nspace);
        }
    }
}
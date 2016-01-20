using System;
using System.Reflection;
using log4net;
using ServiceStack;

namespace api.boilerplate.Endpoints.GetPing
{
    public class GetPingService : Service
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private readonly IGetPingQuery _getPingQuery;

        public GetPingService(IGetPingQuery getPingQuery)
        {
            _getPingQuery = getPingQuery;
        }

        public GetPingResponse Get(GetPingRequest request)
        {
            Log.Debug("Ping GET accessed");

            try
            {
                var number = _getPingQuery.Get();

                var pingResponse = new GetPingResponse {Number = number};

                return pingResponse;
            }
            catch (Exception ex)
            {
                Log.Error("Number not found", ex);
                throw;
            }
        }
    }
}

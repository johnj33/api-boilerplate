namespace api.boilerplate.Endpoints.GetPing
{
    public interface IGetPingQuery
    {
        int Get();
    }

    public class GetPingQuery : IGetPingQuery
    {
        private int _number;

        public int Get()
        {
            _number = 123456789;

            return _number;
        }
    }
}

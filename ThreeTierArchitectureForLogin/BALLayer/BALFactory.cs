namespace BALLayer
{
    public class BALFactory
    {
        public static IAuthenticateBAL GetBALObject()
        {
            return new BALAuthenticate();
        }
    }
}
namespace Apex.GameZone.Shared.CustomExceptions
{
    public class BadDataException : Exception
    {
        public const string DefaultMessage = "Bad data";

        public BadDataException(string message = DefaultMessage) : base(message)
        {
        }
    }
}

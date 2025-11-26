namespace Basis.Store.Domain.Shared
{
    public class BusinessValidationException : Exception
    {
        public BusinessValidationException(string message)
            :base(message)
        {
                
        }
    }
}

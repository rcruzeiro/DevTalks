namespace IoCExamples
{
    public class DataAccessFactory
    {
        public static ICustomerDataAccess GetDataAccessObj()
        {
            return new CustomerDataAccess();
        }
    }
}

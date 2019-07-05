namespace IoCExamples
{
    public class CustomerDataAccess : ICustomerDataAccess
    {
        public CustomerDataAccess()
        { }

        public string GetCustomerName(int id)
        {
            return "John Doe";
        }
    }
}

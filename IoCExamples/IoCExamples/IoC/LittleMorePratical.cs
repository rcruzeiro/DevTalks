using System;

namespace IoCExamples
{
    public class CustomerBusinessLogic
    {
        ICustomerDataAccess _dataAccess;

        public CustomerBusinessLogic(ICustomerDataAccess dataAccess)
        {
            _dataAccess = dataAccess ?? throw new ArgumentNullException(nameof(dataAccess));
        }

        public string GetCustomerName(int id)
        {
            return _dataAccess.GetCustomerName(id);
        }
    }

    public class DataAccess
    {
        public DataAccess()
        { }

        public string GetCustomerName(int id)
        {
            return "John Doe";
        }
    }
}

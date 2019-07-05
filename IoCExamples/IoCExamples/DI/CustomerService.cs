namespace IoCExamples
{
    public class CustomerService
    {
        CustomerBusinessLogic _customerBL;

        public CustomerService()
        {
            _customerBL = new CustomerBusinessLogic(new CustomerDataAccess());
        }

        public string GetCustomerName(int id)
        {
            return _customerBL.GetCustomerName(id);
        }
    }

    // Property Injection
    //public class CustomerService
    //{
    //    CustomerBusinessLogic _customerBL;

    //    public CustomerService()
    //    {
    //        _customerBL = new CustomerBusinessLogic();
    //        _customerBL.DataAccess = new CustomerDataAccess();
    //    }

    //    public string GetCustomerName(int id)
    //    {
    //        return _customerBL.GetCustomerName(id);
    //    }
    //}

    // Method (by Interface segregation) injection
    //interface IDataAccessDependency
    //{
    //    void SetDependency(ICustomerDataAccess customerDataAccess);
    //}

    //public class CustomerBusinessLogic : IDataAccessDependency
    //{
    //    ICustomerDataAccess _dataAccess;

    //    public CustomerBusinessLogic()
    //    {
    //    }

    //    public string GetCustomerName(int id)
    //    {
    //        return _dataAccess.GetCustomerName(id);
    //    }

    //    public void SetDependency(ICustomerDataAccess customerDataAccess)
    //    {
    //        _dataAccess = customerDataAccess;
    //    }
    //}

    //public class CustomerService
    //{
    //    CustomerBusinessLogic _customerBL;

    //    public CustomerService()
    //    {
    //        _customerBL = new CustomerBusinessLogic();
    //        ((IDataAccessDependency)_customerBL).SetDependency(new CustomerDataAccess());
    //    }

    //    public string GetCustomerName(int id)
    //    {
    //        return _customerBL.GetCustomerName(id);
    //    }
    //}
}

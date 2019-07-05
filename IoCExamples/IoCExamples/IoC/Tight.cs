namespace IoCExamples
{
    public class A
    {
        readonly B _b;

        public A()
        {
            _b = new B();
        }

        public void Task1()
        {
            // do something here..
            _b.SomeMethod();
            // do something here..
        }

    }

    public class B
    {
        public void SomeMethod()
        {
            //do something..
        }
    }
}

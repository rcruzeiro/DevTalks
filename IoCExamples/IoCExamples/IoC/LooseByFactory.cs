namespace IoCExamples
{
    public class A2
    {
        readonly B _b;

        public A2()
        {
            _b = Factory.GetObjectOfB();
        }

        public void Task1()
        {
            // do something here..
            _b.SomeMethod();
            // do something here..
        }
    }

    public class Factory
    {
        public static B GetObjectOfB()
        {
            return new B();
        }
    }
}

namespace OS7.Data
{
    public class Student : User, IAuthorisable
    {
        public void Authorisation() => Console.WriteLine("Authorised");

        public override void Execute()
        {
            Authorisation();
        }
    }
}

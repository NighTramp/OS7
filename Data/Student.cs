namespace OS7.Data
{
    internal class Student : User, IAuthorisable, ILearn
    {
        public void Authorisation() => Console.WriteLine("Authorised");
        public void Learn() => Console.WriteLine("Learning...");

        public override void Execute()
        {
            Authorisation();
            Learn();
        }

        
    }
}

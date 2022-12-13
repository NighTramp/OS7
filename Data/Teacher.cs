namespace OS7.Data
{
    internal class Teacher : User, IAuthorisable, ITeach
    {
        public void Authorisation() => Console.WriteLine("Authorised");
        public void Teach() => Console.WriteLine("Teaching...");

        public override void Execute()
        {
            Authorisation();
            Teach();
        }
    }
}

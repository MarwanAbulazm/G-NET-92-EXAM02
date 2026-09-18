namespace G_NET_92_EXAM02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject(1, "OOP");
            subject.CreateExam();

            Console.WriteLine("Do You Want To Start Exam (Y | N)");
            string answer = Console.ReadLine();

            if (answer == "Y" || answer == "y")
            {
                subject.Exam.ShowExam();
            }
        }
    }
}

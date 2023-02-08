namespace SelectionStatementsExercise2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            var favSubject = Console.ReadLine();

            switch (favSubject.ToLower())
            {
                case "math":
                    Console.WriteLine("Ew thats gross I hate math!");
                    break;

                case "english":
                    Console.WriteLine("Hey I really like english too, thats awesome.");
                    break;

                case "science":
                    Console.WriteLine("I really enjoy Science too! My favorite type of science is Chemistry.");
                    break;

                case "history":
                    Console.WriteLine("I always really liked my history teachers, most of them also coached a sport");
                    break;

                case "band":
                    Console.WriteLine("Band was a lot of fun but I wasn't a huge fan of our conductor!");
                    break;

                default: 
                    Console.WriteLine("ohh that sounds like a lot of fun you'll have to tell me more about it!");
                    break;
            }






        }
    }
}
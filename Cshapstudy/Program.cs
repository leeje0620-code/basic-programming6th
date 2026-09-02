namespace Cshapstudy
{
    internal class Program
    {

        //진입점(Entry Point)
        //프로그램은 Main함수에서 시작해서 Main함수로 끝난다.
        static void Main(string[] args)
        {
            //Console.Write("당신의 이름은 무엇입니까? ");
            //string name = Console.ReadLine();

            //Console.WriteLine("정말 당신의 이름이 " + name + "입니까?");

            //먼저 이름을 물어봄.
            //나이를 물어봄
            //국어 성적을 물어봄.
            //수학 성적. 영어성적을 물어봄

            //당신은 누구이며, 나이는 얼마고, 국어, 수학, 영어는 얼마다.

            Console.Write("당신의 이름은 무엇입니까?");
            string name = Console.ReadLine();

            Console.WriteLine("당신의 나이는 몇 살입니까?");
            string age = Console.ReadLine();

            Console.WriteLine("당신의 국어 성적은 몇입니까?");
            string A = Console.ReadLine();

            Console.WriteLine("당신의 수학 성적은 몇입니까?");
            string B = Console.ReadLine();

            Console.WriteLine("당신의 영어 성적은 몇입니까?");
            string C = Console.ReadLine();

            Console.WriteLine("당신의 이름은 " + name + "이며, 나이는 " + age + "살 이며, 국어는 " + A + "점, 수학은 " + B + "점, 영어는 " + C + "점 입니다.");



        }
    }
}

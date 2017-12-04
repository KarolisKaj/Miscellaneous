using System;

namespace LowestCommonAncestor
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(CommonAnscestor.CommonAnscestorFinder(
            new Node<int>(new[] {
                new Node<int>(new[]
                {
                    new Node<int>(new Node<int>[0], 4),
                    new Node<int>(new[] { new Node<int>(new Node<int>[0], 5)}, 6),
                    new Node<int>(new[] { new Node<int>(new[] { new Node<int>(new Node<int>[0], 22) , new Node<int>(new Node<int>[0], 13) }, 14)}, 40),
                    new Node<int>(new[] { new Node<int>(new Node<int>[0], 33)}, 5)}
                , 19),
                new Node<int>(new Node<int>[0], 7),
                new Node<int>(new[]{
                                new Node<int>(new[]
                                {
                                    new Node<int>(new Node<int>[0], 9),
                                    new Node<int>(new[] { new Node<int>(new Node<int>[0], 3)}, 2)}
                                , 8),}, 13)},
            1), 22, 13));
            Console.ReadKey();
        }
    }
}

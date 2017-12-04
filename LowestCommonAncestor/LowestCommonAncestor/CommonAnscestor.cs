using System;

namespace LowestCommonAncestor
{
    public static class CommonAnscestor
    {
        public static int CommonAnscestorFinder(Node<int> node, int x, int y)
        {
            foreach (var leaf in node.Leafs)
            {
                var result = CommonAnscestorFinder(leaf, x, y);
                if (result == -1)
                {
                    if (PathToX(leaf, x) && PathToX(leaf, y))
                        return leaf.Value;
                }
                else
                    return result;


            }
            return -1;
        }

        private static bool PathToX(Node<int> node, int x)
        {
            foreach (var leaf in node.Leafs)
            {
                if (leaf.Value == x)
                {
                    return true;
                }
                else
                {
                    var result = PathToX(leaf, x);
                    if (result)
                    {
                        return result;
                    }
                }
            }
            return false;
        }
    }
}

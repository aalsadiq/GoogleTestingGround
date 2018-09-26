using System;
using System.Collections;

namespace GoogleTestingGround
{
    class Fruits
    {
        public static int TotalFruit(int[] treeArray)
        {
            var maxCount = 0;
            var tree1 = treeArray[0];
            var tree2 = -1;
            var lastFruit = tree1;
            ArrayList tempLongList = new ArrayList();
            ArrayList tempShortList = new ArrayList();
            tempLongList.Add(treeArray[0]);
            tempShortList.Add(treeArray[0]);

            for (int index = 1; index < treeArray.Length; index++)
            {
                if (treeArray[index] == tree1 || treeArray[index] == tree2)
                {
                    tempLongList.Add(treeArray[index]);
                }
                else if (treeArray[index] != tree1 && tree2 < 0)
                {
                    tempLongList.Add(treeArray[index]);
                    tree2 = treeArray[index];

                }
                else
                {
                    maxCount = Math.Max(maxCount, tempLongList.Count);
                    tree1 = lastFruit;
                    tree2 = treeArray[index];
                    tempLongList = new ArrayList(tempShortList);
                    tempLongList.Add(treeArray[index]);
                }

                if (treeArray[index] != lastFruit)
                {
                    lastFruit = treeArray[index];
                    tempShortList.Clear();
                    tempShortList.Add(lastFruit);
                }
                else
                {
                    tempShortList.Add(treeArray[index]);

                }
                //lastFruit = treeArray[index];
            }
            maxCount = Math.Max(maxCount, tempLongList.Count);
            return maxCount;
        }

        /*public static void Main(string[] args)
        {
            int[] array = new int[]{1, 0, 1, 4, 1, 4, 1, 2, 3};
            var max = TotalFruit(array);
            Console.WriteLine(max);
            Console.ReadKey();
  
        }*/
    }
}

using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        List<int> commonList = new List<int>();

        if (list1.Count != 0 && list2.Count != 0)
        {
            list1.Sort();
            list2.Sort();

            foreach (var item in list1)
            {
                foreach (var item2 in list2)
                {
                    if (item2 == item)
                    {
                        commonList.Add(item2);
                        break;
                    }
                }
            }
        }

        return (commonList);
    }
}
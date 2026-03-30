using System;
using System.Collections.Generic;
using System.Linq;

namespace ListNumsActions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string[] cmd = Console.ReadLine().Split().ToArray();
                string command = cmd[0];
                if (command.ToLower() == "finish")
                {
                    break;
                }
                switch (command)
                {
                    case "ins":
                        //TODO
                        break;
                    case "del":
                        //TODO
                        break;
                    case "contains":
                        //TODO
                        break;
                    case "remove":
                        //TODO
                        break;
                    case "countl":
                        int numCount = int.Parse(cmd[1]);
                        int count = nums.Count(x => x > numCount);
                        Console.WriteLine(count);
                        break;
                    case "cut":
                        int cutCount = int.Parse(cmd[1]);
                        if (cutCount >= nums.Count)
                        {
                            nums.Clear();
                        }
                        else
                        {
                            nums = nums.Skip(cutCount).ToList();
                        }
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", nums));
                        break;
                    default:
                        break;
                }
            }
        }
    }
}

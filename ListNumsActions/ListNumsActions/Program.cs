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
                        nums.Insert(int.Parse(cmd[1]), int.Parse(cmd[2]));
                        break;
                    case "del":
                        nums.Remove(int.Parse(cmd[1]));
                        break;
                    case "contains":
                        if (nums.Contains(int.Parse(cmd[1])))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No");
                        }
                            break;
                    case "remove":
                        //TODO
                        break;
                    //TODO

                    default:
                        break;
                }
            }
        }
    }
}

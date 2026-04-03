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
                        int index = int.Parse(cmd[1]);
                        if (index >= 0 && index < nums.Count)
                        {
                            nums.RemoveAt(index);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;

                    case "add":
                        int num1 = int.Parse(cmd[1]);
                        int num2 = int.Parse(cmd[2]);
                        nums.Add(num1 + num2);
                        break;

                    case "large":
                        int number = int.Parse(cmd[1]);
                        List<int> result = nums.Where(x => x > number).ToList();
                        Console.WriteLine(string.Join(" ", result));
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
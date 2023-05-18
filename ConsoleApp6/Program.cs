using System;
using System.Collections.Generic;

using System.Diagnostics;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var lists = new List<string>[]
            {
            new List<string> { "A", "B", "C" },
            new List<string> { "x", "y", "Z" },
            new List<string> { "a", "b", "c" },
            new List<string> { "1", "2", "3" },
                //new List<string> { "甲", "乙", "丙" },
            };

            
            var ds = new List<string>();
            ds = lists[0];
            int i = 1;
            do
            {
                ds = sub2(ds, lists[i]);
                i++;
            } while (i < lists.Length);


            var count = 1;
            ds.ForEach(s => Trace.WriteLine($"{count++:000}:{s}"));
        }


        static List<string> sub2(List<string> initList, List<string> list)
        {
            var ds = new List<string>();
            initList.ForEach(lhs =>
            {
                list.ForEach(rhs => {
                    ds.Add(lhs + rhs);
                });
            });


            return ds;

        }

    }
}
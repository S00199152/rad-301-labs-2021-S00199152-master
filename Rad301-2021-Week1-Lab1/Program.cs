using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracker.WebAPIClient;

namespace Rad301_2021_Week1_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            ActivityAPIClient.Track(StudentID: "S00199152", StudentName: "Shayaan Khan", activityName: "Rad301 2021 Week 1 Lab 1 Part 2", Task: "Designing class Model");
        }
    }
}

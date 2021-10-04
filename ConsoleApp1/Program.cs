using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracker.WebAPIClient;

namespace Week2Lab1ConsoleApp2021
{
    class Program
    {
        static void Main(string[] args)
        {
            ActivityAPIClient.Track(StudentID: "S00199152",
                StudentName: "Shayaan Khan",
                activityName: "Rad301 2021 Week 2 Lab 1",
                Task: "Creating Console App");
        }
    }
}

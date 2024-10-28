using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab9.Program;

namespace Lab9
{
    //2
    public class Student : IStudent
    {
        public int StudID { get; set; }
        public string StudName { get; set; }
        public string StudGender { get; set; }
        public int StudAge { get; set; }
        public string StudClass { get; set; }
        private float studAvgMark;
        public float StudAvgMark => studAvgMark;

        private int[] MarkList = new int[3];

        public void Print()
        {
            Console.WriteLine($"ID: {StudID}, Name: {StudName}, Gender: {StudGender}, Age: {StudAge}, Class: {StudClass}, Average Mark: {StudAvgMark}");
        }

        public int this[int index]
        {
            get { return MarkList[index]; }
            set { MarkList[index] = value; }
        }

        public void CalAvg()
        {
            studAvgMark = (float)MarkList.Average();
        }
    }
}

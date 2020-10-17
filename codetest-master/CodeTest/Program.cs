using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CodeTest
{
    //Shapes Inc. has requested your services to build an application that automates calculations that they currently perform manually
    //They have provided you with a csv file (available in this solution)
    //The first column in the csv file denotes the shape, "C" for Circle, "R" for rectangle
    //The second column represents either the radius of a circle or the length of the rectangle (depending on the value of the first column)
    //The 3rd column will not be filled for a circle, but will represent the height of a rectangle

    //Shapes Inc. would like an application that prints information regarding the 5 largest shapes by area
    //They would also like the aplication to print 5 smallest shapes by perimeter

    //Shapes Inc. have requested this code be of production quality and to have confidence that this code
    //won't break after future development. Add anything that you think may be relevant to satisfy this request
    class Program
    {
        static void Main(string[] args)
        {
            var Path = @"../../../Shapedata.csv";
            var lines = File.ReadAllLines(Path).Select(a => a.Split(';'));

            List<double> area = new List<double>();
            List<double> perimeter = new List<double>();
            foreach (var item in lines)
            {
                foreach (var record in item.Select(a => a.Split(',')))
                {
                    var calculateShape = new CalculateShape(Utility.ObjToDouble(record[1]));
                    switch (record[0])
                    {
                        case "C":
                            area.Add(calculateShape.CalculateCircleArea());
                            perimeter.Add(calculateShape.CalculateCirclePerimeter());
                            break;
                        case "R":
                            area.Add(calculateShape.CalculateRectangleArea(Utility.ObjToDouble(record[2])));
                            perimeter.Add(calculateShape.CalculateRectanglePerimeter(Utility.ObjToDouble(record[2])));
                            break;
                        default:
                            break;
                    }
                }
            }

            Console.WriteLine("Largest 5 shape by area are :- \n{0}\n", string.Join<double>("\n", area.OrderByDescending(s => s).Take(5)));

            Console.WriteLine("Smallest 5 shape by perimeter are :- \n{0}\n", string.Join<double>("\n", perimeter.OrderBy(s => s).Take(5)));
        }
    }
}

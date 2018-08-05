using System;

namespace _04._Trainers_Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the input data from the console
            double lectures = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double lecturesJelev = 0.0;
            double lecturesRoYal = 0.0;
            double lecturesRoli = 0.0;
            double lecturesTrofon = 0.0;
            double lecturesSino = 0.0;
            double lecturesOthers = 0.0;

            // Check who is the current lecturer and record it
            for (int i = 0; i < lectures; i++)
            {
                string currentLecturer = Console.ReadLine();
                switch (currentLecturer)
                {
                    case "Jelev":
                        lecturesJelev++;
                        break;
                    case "RoYaL":
                        lecturesRoYal++;
                        break;
                    case "Roli":
                        lecturesRoli++;
                        break;
                    case "Trofon":
                        lecturesTrofon++;
                        break;
                    case "Sino":
                        lecturesSino++;
                        break;
                    default:
                        lecturesOthers++;
                        break;
                }
            }

            // Calculate the money per lecture and print the salaries
            double moneyPerLecture = budget / lectures;
            Console.WriteLine($"Jelev salary: {lecturesJelev * moneyPerLecture:f2} lv");
            Console.WriteLine($"RoYaL salary: {lecturesRoYal * moneyPerLecture:f2} lv");
            Console.WriteLine($"Roli salary: {lecturesRoli * moneyPerLecture:f2} lv");
            Console.WriteLine($"Trofon salary: {lecturesTrofon * moneyPerLecture:f2} lv");
            Console.WriteLine($"Sino salary: {lecturesSino * moneyPerLecture:f2} lv");
            Console.WriteLine($"Others salary: {lecturesOthers * moneyPerLecture:f2} lv");

        }
    }
}

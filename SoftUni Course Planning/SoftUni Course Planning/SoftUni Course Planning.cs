using System.Collections.Generic;
using System;

namespace SoftUni_Course_Planning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine().Split(", ").ToList();
            
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "course start")
                {
                    break;
                }

                string[] parts = command.Split(":");

                switch (parts[0])
                {
                    case "Add":
                        if (schedule.IndexOf(parts[1]) < 0)
                        {
                            schedule.Add(parts[1]);
                        }
                        break;
                    case "Insert":
                        if (schedule.IndexOf(parts[1]) < 0)
                        {
                            schedule.Insert(int.Parse(parts[2]), parts[1]);
                        }
                        break;
                    case "Remove": 
                        {
                            schedule.Remove(parts[1]);
                            string exercise = $"{parts[1]}-Exercise";

                            schedule.Remove(parts[1]);
                            schedule.Remove(exercise);
                            break;
                        }
                    case "Swap": 
                        {
                            bool hasExercise1 = schedule.Remove($"{parts[1]}-Exercise");
                            bool hasExercise2 = schedule.Remove($"{parts[2]}-Exercise");


                            int index1 = schedule.IndexOf(parts[1]);
                            int index2 = schedule.IndexOf(parts[2]);

                            if (index1 > -1 && index2 > -1)
                            {
                                string t = schedule[index1];
                                schedule[index1] = schedule[index2];
                                schedule[index2] = t;

                                if (hasExercise1)
                                {
                                    schedule.Insert(schedule.IndexOf(parts[1]) + 1, $"{parts[1]}-Exercise");
                                }
                                if (hasExercise2)
                                {
                                    schedule.Insert(schedule.IndexOf(parts[2]) + 1, $"{parts[2]}-Exercise");
                                }
                            }
                            break;
                        }
                    case "Exercise": //:{ lessonTitle}
                        {
                            int index = schedule.IndexOf(parts[1]);
                            if (index < 0)
                            {
                                schedule.Add(parts[1]);
                                index = schedule.Count - 1;
                            }

                            string exercise = $"{parts[1]}-Exercise";
                            if (schedule.IndexOf(exercise) < 0)
                            {
                                schedule.Insert(index + 1, exercise);
                            }

                            break;
                        }
                }
            }

            for (int i=0; i<schedule.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{schedule[i]}");
            }
        }
    }
}
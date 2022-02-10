using System;
using System.Collections.Generic;

namespace HaciSongur
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Prsn> json_data = new List<Prsn>();
            List<Prsn> removed_data = new List<Prsn>();
            List<Prsn> male_data = new List<Prsn>();
            List<Prsn> female_data = new List<Prsn>();

            json_data = data.jsn;

            
            Console.WriteLine(data.jsn.Count);

            for (int i = 0; i < json_data.Count; i++)
            {
                for (int j = 0; j < json_data.Count; j++)
                {
                    if (json_data[i].FirstName == json_data[j].FirstName && json_data[i].LastName == json_data[j].LastName && i != j)
                    {
                        
                        Console.WriteLine("Kaldırıldı: "+json_data[i].FirstName+" "+ json_data[i].LastName);
                        json_data.RemoveAt(j);


                    }
                }
            }
            for (int i = 0; i < json_data.Count; i++)
            {
                Console.WriteLine(json_data[i].FirstName + "\n");
            }

            for (int i = 0; i < json_data.Count; i++)
            {

                if (json_data[i].Gender == "Female")
                {
                    female_data.Add(json_data[i]);
                } else
                {
                    male_data.Add(json_data[i]);
                }

            }

            Console.WriteLine("Kadınlar");
            for (int i = 0; i < female_data.Count; i++)
            {
                Console.WriteLine(female_data[i].FirstName +" "+female_data[i].LastName+"\t");
            }
            Console.WriteLine("\n Erkekler");
            for (int i = 0; i < male_data.Count; i++)
            {
                Console.WriteLine(male_data[i].FirstName + " " + male_data[i].LastName + "\t");
            }
        }
    }
}

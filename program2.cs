using System;

public class Class1
{
	public Class1()
	{
		static void Main(string[] args)
		{
			List<Prsn> json_data = new List<Prsn>();
			json_data = data.jsn;
			Console.WriteLine(data.jsn.Count);

			for (int i = 0; i < json_data.Count; i++)
            {
                
                   

                        Console.WriteLine("Kadın: " + json_data[i].Female + " Erkek :" + json_data[i].Male);
                        json_data.Add(i);


                
            }
		}
}

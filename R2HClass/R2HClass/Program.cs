using System;
using System.Collections.Generic;
namespace R2HClass
{
    class Program
    {

		static void Main(string[] args)
        {
			Dictionary<string, int> R2Hclass =
			new Dictionary<string, int>();

			R2Hclass.Add("Ivan", 18);
			R2Hclass.Add("Juan", 19);
			R2Hclass.Add("Ian", 21);
			R2Hclass.Add("Angel", 19);
			R2Hclass.Add("Micky", 19);
			R2Hclass.Add("Miguel", 22);
			R2Hclass.Add("lesly", 18);
			R2Hclass.Add("Markus", 18);
			R2Hclass.Add("Chris", 21);
			R2Hclass.Add("malik", 22);
			R2Hclass.Add("Brittny", 24);
			R2Hclass.Add("Victoria", 24);
			R2Hclass.Add("Hunter", 20);
			R2Hclass.Add("Teia", 20);
			R2Hclass.Add("derp", 20);



            int count1 =  R2Hclass.Count;

            Console.WriteLine(count1);

			R2Hclass.Remove("derp");


			Console.WriteLine("removed derp");

            int count2 = R2Hclass.Count;

			Console.WriteLine(count2);

            if(R2Hclass.ContainsKey("Ivan")){
				Console.WriteLine("Ivan is located within the dictionary");
                Console.WriteLine("Key = {0}, Value = {1}", R2Hclass.Key, R2Hclass.Value);


			}else{
				Console.WriteLine("Ivan is not located within the dictionary");

			}




		}
    }
}

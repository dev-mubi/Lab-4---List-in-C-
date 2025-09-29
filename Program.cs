namespace Lab_4 // 29 Sept 2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Name Space in C#
            // List
            List<int> nums = new List<int>() { 4, 5, 3, 5 }; //initialization

            //or

            // List<int> num;
            // num = new List<int>(); // Memory alloted but empty.

            //size --> count --> property --> returns elements present

            Console.WriteLine("Size of list: " + nums.Count);

            nums.Add(4);
            nums.AddRange(new int[] { 5, 9, 77 }); //takes array
            Console.WriteLine("Updated Size of list: " + nums.Count);
            //printing
            Console.WriteLine(String.Join(",", nums)); // Convert to string using , as delimeter.
            // or use loop
            Console.WriteLine("Printing using loop: ");
            foreach(int x in nums)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("-----------");

            //remove

            nums.Remove(77);
            nums.RemoveAt(4);
            Console.WriteLine("After Removal: ");
            Console.WriteLine(String.Join(",", nums));


            //Size is dynamic.

            List<String> name = new List<String>() { "Fariha", "Mubi", "Ali" };

            string[] names = name.ToArray(); //List to Array

            //Array to List.

            String[] test = new string[] { "Shahzaib" };
            List<string> xyz = test.ToList();

            //Adding at specific location in array.

            nums.Insert(2, 4); //add 4 at index 2 and move already present value one index forward.
            nums.InsertRange(4, new List<int>() { 4, 7, 3 });
            Console.WriteLine("After Inserting: ");
            Console.WriteLine(String.Join(",", nums));

            // search

            Console.WriteLine(nums.Contains(4));
            Console.WriteLine(nums.IndexOf(7));
            //use nums.find to add condition... like value over 10... returns first occurance. findAll will return all values meeting condition.

            Console.WriteLine(nums.Find(x => x>10)); //returns 0 if no element meets condition.
            nums.RemoveAll(x => x > 4);
            Console.WriteLine("After Remove all > 4: ");
            Console.WriteLine(String.Join(",", nums));

            // sort
            nums.Sort();
            Console.WriteLine("Sorted: ");
            Console.WriteLine(String.Join(",", nums));

            // reverse
            Console.WriteLine("Reversed: ");

            Console.WriteLine(String.Join(",", nums));
            nums.Reverse();
            //clear
            Console.WriteLine("List cleared: ");
            nums.Clear();
            Console.WriteLine("Size of list: " + nums.Count);

            //passing to function
            display(nums);

            //Dictionary --> grneric type
            // is a collection to store key-value pairs.

           // Dictionary<Tkey, Tvalue> xyz = new Dictionary<Tkey, Tvalue>();
           //keys have to be unique and not null. values can be duplicate and null.

            // implements IDictionary<Tkey,Tvalue> interface

            // value can be accessed --> xyz[key] --> using keys
            // indivisual pair are stored as KEY VALUE PAIR --> KVP<Tkey,Tvalue>

            // .key and .value

            Dictionary<string, int> students = new Dictionary<string, int>();
            // adding records.
            // add or INDEXER --> two methods
            students.Add("Fariha", 300);
            students.Add("Shahzaib", 900);
            students.Add("Laiba", 600);
            //  students.Add("Shahzaib", 900); -->ERROR ... duplicate key
            //But indexer will modify the record with that key.

            students["Shahzaib"] = 1200; // Modification
            // If key is not present then add new record.

            // Access loop
            foreach(KeyValuePair<string,int> st in students)
            {
                // st.key and st.value are READ ONLY props. Cannot update record just access.
                //Console.WriteLine(st.Key + " : " + st.Value ); // just st prints pair itself
                Console.WriteLine(st);
            }


        }












        static void display(List<int> nums)        // Pass by reference

        {
            Console.WriteLine("Use me to print list but make sure to pass one");
        }
    }
}

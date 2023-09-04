using System;

namespace LinqTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*  Task 1 
            int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };   
            var query= number.Where(s=>s%2==0);
            Console.Write("The numbers which produce the remainder 0 after divided by 2 are : ");
            foreach ( var item in query )
            {
                Console.Write(item+" " );
            }
            */

            /* Task 2 
            int[] input = { 1, 5, 7, 9, -11, -12, -34, -44, -1, -3, 0, };                     
            var query = input.Where(x => x > 0 && x<12);
            Console.Write("The numbers within the range of 1 to 11 are: ");
            foreach (int x in query) 
            {
                Console.Write(x + " ");
            }
            */

            /* Task 3 
            int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
            var squares = number.Select(x => new { number = x, SqrNo = x * x });

            foreach (var square in squares)
            {
                Console.WriteLine(square);
            }
            */

            /* Task 4 
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7,5,2,1,4,4,4,5,6,6,6,6,6 };
            var n = numbers.GroupBy(x => x);
            foreach (var x in n)
            {
                Console.WriteLine("Number " + x.Key + " appears " + x.Count() + " times");
            }
            */

            /* Task 5 
            string input = "apple";
            var frequency = input.GroupBy(x => x);
            foreach(var x in frequency)
            {
                Console.WriteLine("Character "+ x.Key+ $": {x.Count()} times");
            }
            */

            /* Task 6 
            string[] dayWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };       
            var days = dayWeek.Select(x=> x);
            foreach(var day in days)
            {
                Console.WriteLine(day);
            }
           */

            /* Task 7 
            Console.WriteLine("Numbers: 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2");
            int[] numbers = { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };
            var result = numbers.GroupBy(x => x)
           .Select(group => new
           {
               Number = group.Key,
               NumberTimesFrequency = group.Key * group.Count(),
               Frequency = group.Count()
           });
            Console.WriteLine("Number   Number*Frequency    Frequency");
            Console.WriteLine("-------------------------------------");
            foreach (var x in result)
            {
                Console.WriteLine($"{x.Number} {x.NumberTimesFrequency} {x.Frequency}");
            }
            */

            /* Task 8
            string[] cities = { "ROME", "LONDON" ,"NAIROBI" ,"CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            Console.Write("LINQ : Find the string which starts and ends with a specific character : ");
            Console.WriteLine();
            Console.WriteLine();
           
            Console.WriteLine("The cities: 'ROME','LONDON','NAIROBI','CALIFORNIA','ZURICH','NEW DELHI','AMSTERDAM','ABU DHABI','PARIS' ");
            Console.WriteLine();
            Console.Write("Input starting character for the string : ");
            char start = Console.ReadLine()[0];

            Console.Write("Input ending character for the string : ");
            char end = Console.ReadLine()[0];
          
            var result = cities.Where(x => x.StartsWith(start)).Where(x => x.EndsWith(end));
            foreach (var city in result)
            {
                Console.Write("The city starting with {0} and ending with {1} is : {2} \n", start, end, city);
            }
            */
            /* Task 9 
            List<int> number = new List<int>() { 55, 200, 740, 76, 230, 482, 95 };
            var result = number.Where(x => x > 80);
            foreach(var item  in result)
            {
                Console.WriteLine(item);
            }
            */

            /* Task 10 
            int i =0;
            List<int> number = new List<int>();
            Console.Write("Input the number of members on the List : ");

            int memberCount = int.Parse(Console.ReadLine());

            for (i = 0; i < memberCount; i++)
            {
                Console.Write($"Input member {i} : ");
                int inputNumber = int.Parse(Console.ReadLine());
                number.Add(inputNumber);
            }
            Console.Write("Input the value above you want to display the members of the List : ");
            int value = int.Parse(Console.ReadLine());
            var result = number.Where(x => x > value);
            foreach (int x in result)
            {
                Console.Write(x);
            }
            */

            /* Task 11 
            List<int> members = new List<int> { 5, 7, 13, 24, 6, 9, 8, 7 };
            members.Sort((a, b) => b - a);
            Console.WriteLine("The members of the list are : 5, 7, 13, 24, 6, 9, 8, 7 ");
          
            Console.WriteLine();
          
            Console.Write("How many records you want to display ? : ");
            int value = int.Parse(Console.ReadLine());
            foreach(int member in members.Take(value))
            {
                Console.WriteLine(member);
            }
            */

            /* Task 12 
            string input = "this IS a STRING";
            Console.Write("The UPPER CASE words are :");

            string[] inputSplit = input.Split(' ');

            foreach(var word in inputSplit)
            {
                if(!string.IsNullOrEmpty(word)&& word == word.ToUpper())
                {
                    Console.Write(word +" ");
                }
            }
          */
            /* Task 13
            Console.Write("Input number of strings to store in the array : ");
            int value = int.Parse(Console.ReadLine());
            string[] arry = new string [value];
            Console.WriteLine($"Input {value} strings for the array : ");
            
            for(int i = 0; i < value; i++)
            {              
                Console.Write("Element[{0}] : ", i);
                arry[i] = Console.ReadLine();
            }
            string @string = String.Join(", ", arry);
                        
            Console.Write("Here is the string below created with elements of the above array  : ");
            Console.WriteLine(@string);
            */

            /*Task 15    

             string[] files = { "aaa.frx", "bbb.TXT", "xyz.dbf","abc.pdf", "aaaa.PDF","xyz.frt", "abc.xml", "ccc.txt", "zzz.txt" };

             var result = files
                 .Select(file => Path.GetExtension(file).ToLower())
                 .GroupBy(extension => extension)
                 .Select(group => new { Extenson = group.Key, Count = group.Count() });
             Console.WriteLine("Here is the group of extension of the files:");
             foreach (var extensionCount in result)
             {
                 Console.WriteLine($"{extensionCount.Count} File(s) with {extensionCount.Extenson} Extension");
             }
            */
            /* Task 16
            string[] files = Directory.GetFiles(@"C:\\Users\\Senan\\Downloads\\Internet Presets 6-11-2012\\Van Halen");
            var avgFsize = files.Select(file => new FileInfo(file).Length).Average();
            avgFsize = Math.Round(avgFsize / 10, 1);
            Console.WriteLine("The Average file size is {0} MB", avgFsize);
            */
            /* Task 17
            List<string> list = new List<string>();
            list.Add("m");
            list.Add("n");
            list.Add("o");
            list.Add("p");
            list.Add("q");
            Console.WriteLine("Main list:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Write which charecter do you want remove : ");
            string input = Console.ReadLine();
            bool removed = list.Remove(input);
            Console.WriteLine("Updated list:");
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
            */
            /*Task 19
            List<string> list = new List<string>
            {
            "Char: m",
            "Char: n",
            "Char: o",
            "Char: p",
            "Char: q"
            };

            Console.WriteLine("Here is the list of items:");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Enter the filter to remove items: ");
            string filter = Console.ReadLine();
            list.RemoveAll(item => item.Contains(filter));
            Console.WriteLine("Here is the list after removing items matching the filter:");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            */
            /* Task 20
            List<string> list = new List<string>
            {
            "Char: m",
            "Char: n",
            "Char: o",
            "Char: p",
            "Char: q"
            };

            Console.WriteLine("Here is the list of items:");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Enter the index of the item to remove: ");
            int indexToRemove = int.Parse(Console.ReadLine());
            list.RemoveAt(indexToRemove);

            Console.WriteLine($"Here is the list after removing item index {indexToRemove} from the list:");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            */

            /*Task 21
            List<string> list = new List<string>
            {
            "Char: m",
            "Char: n",
            "Char: o",
            "Char: p",
            "Char: q"
            };

            Console.WriteLine("Here is the list of items:");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Strat inddex");
            int start =int.Parse(Console.ReadLine());
            Console.WriteLine("How many elements would you like to remove ");
            int element = int.Parse(Console.ReadLine());
            list.RemoveRange(start, element);
            Console.WriteLine($"Here is the list after removing {element} items starting from index {start} from the list:");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            */
            /*Task 22
            Console.Write("Input number of strings to store in the array :");
            int input = int.Parse(Console.ReadLine());
            string[] stringArray = new string[input];
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.Write("Element[{0}] : ", i);
                stringArray[i] = Console.ReadLine();
            }
            Console.WriteLine("Input the minimum length of the item you want to find : ");
            int minLength = int.Parse(Console.ReadLine());
            var result= stringArray.Where(x=>x.Length >= minLength);
            Console.WriteLine("The items of minimum " + minLength + " characters are:");

            foreach (string item in result)
            {
                Console.WriteLine("Item: " + item);
            }
            */
            /* Task 23 
            char[] chars = { 'A', 'B', 'C' };
            int[] intSet = { 1, 2, 3};

            var result = chars.SelectMany(letterList => intSet, (letterList, numberList) =>
             new { letterList, numberList });

            foreach (var item in result)
            {
                Console.WriteLine($"Letter: {item.letterList}, Number: {item.numberList}");
            }
            */
            /*Task24
            char[] chars = { 'A', 'B', 'C', };
            int[] number = { 1, 2, 3, };
            string[] colour = { "Green", "Orange" };
            

            var x = chars.SelectMany
               (letter => number,(letter, num) => new { Letter = letter, Number = num });

            var result = x.SelectMany
                (all => colour,(product, col) => new { product.Letter, product.Number, Colour = col });
            foreach (var item in result)
            {
                Console.WriteLine($"Letter: {item.Letter}, Number: {item.Number},Colour:{item.Colour}");
            }
            */

            string[] cities =
            {
                "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS"
            };
            Console.Write("\nLINQ : Display the list according to the length then by name in ascending order : ");
            Console.Write("\n--------------------------------------------------------------------------------\n");
            Console.Write("\nThe cities are : 'ROME','LONDON','NAIROBI','CALIFORNIA','ZURICH','NEW DELHI','AMSTERDAM','ABU DHABI','PARIS' \n");
            Console.Write("\nHere is the arranged list :\n");
            IEnumerable<string> cityOrder = cities
           .OrderBy(str => str.Length)
           .ThenBy(str => str);

            foreach (string city in cityOrder)
            {
                Console.WriteLine(city);
            }

        }

    }   
}
    
    

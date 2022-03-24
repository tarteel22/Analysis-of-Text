namespace CMP1903M_Assessment_1_Base_Code

{

    class Program

    {

        static void Main(string[] args)

        {

            //Local list of integers to hold the first five measurements of the text

            List<int> parameters = new List<int>();

            bool showMenu = true;

            while (showMenu)

            {

                showMenu = MainMenu();

            }

        }

        private static bool MainMenu()

        {

            Console.Clear();

            Console.WriteLine("Choose an option : ");

            Console.WriteLine("1. Do you want to enter the text via the keyboard?");

            Console.WriteLine("2. Do you want to read in the text from a file?");

            Console.Write("\r\nSelect an option : ");



            switch (Console.ReadLine())

            {

                case "1":

                    Console.WriteLine("Now enter your text : ");

                    string text = Console.ReadLine();

                    char[] sperator = { '*' };

                    string[] sentences = text.Split(sperator);

                    int s = 0;

                    foreach (var sentence in sentences)

                    {

                        s++;

                    }

                    int i, upper = 0, lower = 0, vowels = 0, consonant = 0, len = text.Length;

                    for (i = 0; i < len; i++)

                    {

                        char ch = text[i];

                        if (ch >= 'A' && ch <= 'Z')

                            upper++;

                        else if (ch >= 'a' && ch <= 'z')

                            lower++;

                        if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))

                        {

                            ch = char.ToLower(ch);



                            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')

                                vowels++;

                            else

                                consonant++;

                        }

                    }

                    Console.WriteLine("Number frequency of individual letters : ");

                    var characterCount = new Dictionary<char, int>();

                    foreach (var c in text)

                    {

                        if (characterCount.ContainsKey(c))

                            characterCount[c]++;

                        else

                            characterCount[c] = 1;

                    }

                    foreach (var pair in characterCount)

                    {

                        Console.WriteLine("\n{0} - {1}", pair.Key, pair.Value);

                    }

                    Console.WriteLine("\nNumber of sentences : " + s);

                    Console.WriteLine("Number of vowels : " + vowels);

                    Console.WriteLine("Number of consonants : " + consonant);

                    Console.WriteLine("Number of upper case letters : " + upper);

                    Console.WriteLine("Number of lower case letters : " + lower);

                    Console.ReadLine();

                    Console.ReadLine();

                    Console.ReadLine();

                    return true;



                case "2":

                    string filename = Console.ReadLine();

                    string file = File.ReadAllText(filename);

                    Console.WriteLine(file);

                    char[] sperator2 = { '*' };

                    string[] sentences2 = file.Split(sperator2);

                    int s2 = 0;

                    foreach (var sentence in sentences2)

                    {

                        s2++;

                    }

                    int upper2 = 0, lower2 = 0, vowels2 = 0, consonant2 = 0, len2 = file.Length;

                    for (i = 0; i < len2; i++)

                    {

                        char ch = file[i];

                        if (ch >= 'A' && ch <= 'Z')

                            upper2++;

                        else if (ch >= 'a' && ch <= 'z')

                            lower2++;

                        if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))

                        {

                            ch = char.ToLower(ch);



                            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')

                                vowels2++;

                            else

                                consonant2++;

                        }

                    }

                    Console.WriteLine("Number frequency of individual letters : ");

                    var characterCount2 = new Dictionary<char, int>();

                    foreach (var c2 in file)

                    {

                        if (characterCount2.ContainsKey(c2))

                            characterCount2[c2]++;

                        else

                            characterCount2[c2] = 1;

                    }

                    foreach (var pair in characterCount2)

                    {

                        Console.WriteLine("\n{0} - {1}", pair.Key, pair.Value);

                    }

                    Console.WriteLine("\nNumber of sentences : " + s2);

                    Console.WriteLine("Number of vowels : " + vowels2);

                    Console.WriteLine("Number of consonant : " + consonant2);

                    Console.WriteLine("Number of upper case letters : " + upper2);

                    Console.WriteLine("Number of lower case letters : " + lower2);

                    Console.WriteLine("Count of words: " + sentences2.Length);

                    string myfile = @"C:\\Users\\tarte\\OneDrive\\Desktop\\CMP1903M Object-Oriented Programming\\Assessment 1\\Text\\Analysis of Text\\Analysis of Text\bin\\Debug\\net6.0\\text1.txt";

                    using (StreamWriter sw = File.AppendText(myfile))

                    {

                        if (sentences2.Length > 7)

                            sw.WriteLine(sentences2);

                    }

                    Console.ReadLine();

                    Console.ReadLine();

                    Console.ReadLine();

                    return true;

                default:

                    return true;

            }

            //Create 'Input' object

            //Get either manually entered text, or text from a file

            //Create an 'Analyse' object

            //Pass the text input to the 'analyseText' method

            //Receive a list of integers back

            //Report the results of the analysis

            //TO ADD: Get the frequency of individual letters?

        }

    }

}
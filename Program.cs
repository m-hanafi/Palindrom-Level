// See https://aka.ms/new-console-template for more information


namespace Palindrom_Level
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text:");
            string x = Console.ReadLine(); //get text from user input.
            int res = Palindrom(x);
            Console.WriteLine($"Palindrom level:{res}");
        }

        static int lvl = 0;
        static int Palindrom(string x)
        {
            x = x.Replace(" ",""); //remove space
            x = x.ToLower(); //convert text to lowercase

            //reverse the text by re-order the charater from last index
            string rev=string.Empty;
            for (int i=x.Length-1;i>=0;i--)
            {
                rev +=x[i];
            }

            //check if palindrom
            if (x == rev)
            {
                lvl++; //increase palindrom level by 1
                int x_len;
                
                if(x.Length%2!=0) 
                {
                    //take character in the middle if length is odd number
                   x_len = x.Length / 2 + 1;

                }
                else{
                    x_len = x.Length / 2;
                }

                x = x.Substring(0, x_len); //split the text to get another palindrom level
                Palindrom(x); //recursive function
            }

            return lvl;

        }
    }
}

string[] ones = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
string[] tens = {"x", "x", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety"};

Console.Write("<num> ");
string num = Console.ReadLine();

if (num.Length == 2)
{
    string num_tens = num.Substring(0, (int)(num.Length / 2));
    string num_ones = num.Substring((int)(num.Length / 2), (int)(num.Length / 2));

    if (num_tens == "1")
    {
        if (num == "10")
        {
            Console.WriteLine("ten");
        }
        else if (num == "11")
        {
            Console.WriteLine("eleven");
        }
        else if (num == "12")
        {
            Console.WriteLine("twelve");
        }
        else if (num == "13")
        {
            Console.WriteLine("thirteen");
        }
        else if (num == "14")
        {
            Console.WriteLine("fourteen");
        }
        else if (num == "15")
        {
            Console.WriteLine("fifteen");
        }
        else if (num == "16")
        {
            Console.WriteLine("sixteen");
        }
        else if (num == "17")
        {
            Console.WriteLine("seventeen");
        }
        else if (num == "18")
        {
            Console.WriteLine("eighteen");
        }
        else if (num == "19")
        {
            Console.WriteLine("nineteen");
        }
    }else
    {
        string conv_tens = tens[Convert.ToInt32(num_tens)];
        string conv_ones = "";
        if (num_ones == "0")
        {
            conv_ones = "";
        }else
        {
            conv_ones = ones[Convert.ToInt32(num_ones)];
        }
        string conv = conv_tens + " " + conv_ones;

        Console.WriteLine(conv);
    }
}else if (num.Length == 1)
{
    string conv = ones[Convert.ToInt32(num)];
    Console.WriteLine(conv);
}else
{
    Console.WriteLine("this program is meant for 1 - 99");
}
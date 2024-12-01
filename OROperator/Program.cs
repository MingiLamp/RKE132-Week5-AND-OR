// Math >= 90 OR Chem >= 90

//Math && chem || math && || chem && bio

int math, bio, chem;

Console.WriteLine("Enter your Math result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your biology result:");
bio = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Chemistry result:");
chem = Int32.Parse(Console.ReadLine());

if((math >= 90 && chem >= 90) || (math >= 90 && bio >= 90) || (chem >= 90 && bio >= 90))
{
    Console.WriteLine("Congratulation! You got accepted");
}
else
{
    Console.WriteLine("Your application can't be approved.");
}

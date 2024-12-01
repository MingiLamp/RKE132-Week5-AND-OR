//Math >= 90; Bio >=90, Chem >=90;

int math, bio, chem;

Console.WriteLine("Enter your Math result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Biology result:");
bio = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Chemistry result:");
chem = Int32.Parse(Console.ReadLine());


if (math >= 90 && bio >= 90 && chem >= 90)
{
    Console.WriteLine("Congratulation! You got accepted");

}else
{
    Console.WriteLine("Your appl;ication cannot be approved.");
}

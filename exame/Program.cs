//q1 simple adding 
int num =0;
int total = 0;
Console.ReadLine();
for (int i=0;i<= 5;i++) {
    
    total+=i;
}
Console.WriteLine("totall is ; " + total );


Console.WriteLine("-------------------------------------");

//q2
int VowelCount;
string str="axzi";
string vowels = "aeiouAEIOU";
int count = 0;

Console.ReadLine();
foreach (char c in str)
{
    if (vowels.Contains(c))
    {
        count++;
        
    }
    return count;   
}

Console.WriteLine(count);   

  

Console.WriteLine("-------------------------------------");



////q3 

int result = 1;

Console.ReadLine();

for (int i = 1; i <= result; i++)
        {
            result *= i;
        }



Console.WriteLine(result);
return 0;




//////task4 






string simpleEvens()
{
    string numStr = num.ToString();
    string r = "";
    Console.ReadLine();
    foreach (char digit in numStr)
    {
        int digitValue = int.Parse(digit.ToString());

        if (digitValue % 2 != 0)
        {
            r= "false";
        }
 
    }
            Console.WriteLine(r);



   
    return r;
}





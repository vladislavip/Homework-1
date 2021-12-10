/*1.    1 - 50(1 ve 50 daxil olmaqla) butun ededleri cap edin
2.    50-1  (50 ve 1 daxil olmaqla) butun ededleri cap edin
3.    1-50   (1 ve 50 daxil olmaqla) butun 2 - ye bolunen ededleri cap edin
4.    50-1   (50 ve 1 daxil olmaqla) butun 3 - e bolunen ededleri cap edin
5.    50-1   (50 ve 1 daxil olmaqla) butun 3 - e ve eyni zamanda 7-ye bolunen ededleri cap edin   (hem 3-e hem 7ye bolune bilen ededler) */

#region 1-50
// 1-50 
Console.WriteLine("-------------------------");
Console.WriteLine("1-50");


for (int i = 1; i <= 50; i++)
{
    Console.WriteLine(i);
}

#endregion 1-50 

Console.WriteLine("----------------------------------");

#region 50-1
Console.WriteLine("50-1");
// 50-1 
for (int i = 50; i > 0; i--)
{
    Console.WriteLine(i);
}
#endregion 50-1

Console.WriteLine("-----------------------------------------");
Console.Write("1-50 All even");
// 1-50 All even 
for (int i = 0; i <= 50; i += 2)
{
    Console.WriteLine(i); 

}

Console.WriteLine("-----------------------------------------");
Console.Write("1-50 All even rev.2");
for(int i=0;i<50;i++)
{if (i%2==0)
    { Console.WriteLine(i); }

}



Console.WriteLine("-----------------------------");
Console.WriteLine("50-1 Div. by 3");
// 50-1 Div. by 3
for (int i=51;i>=0;i-=3)
{
    if (i <= 48 && i>0)
    {
        Console.WriteLine(i);
    }
}

Console.WriteLine("-----------------------------");
Console.WriteLine("50-1 Div. by 3 Rev.2");
for (int i=50;i>0;i--)
{
    if(i%3 == 0)
    { 
        Console.WriteLine(i); 
    }
}



Console.WriteLine("----------------------------");
Console.WriteLine( "50-1 div by 3 and 7");
//50-1 Div. by 3 and by 7
for (int i=50;i>0;i--)
{if (i%3 ==0 && i%7 ==0)
    { Console.WriteLine(i); }
 
}
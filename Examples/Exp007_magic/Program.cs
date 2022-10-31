Console.Clear();
//Concole.SetCursorPosition(10, 4);
//Console.WriteLine("*");

int Xa = 1, Ya = 1,
    Xb = 1, Yb = 15,
    Xc = 60, Yc = 15;

Console.SetCursorPosition(Xa,Ya);
Console.WriteLine("*");

Console.SetCursorPosition(Xb,Yb);
Console.WriteLine("*");

Console.SetCursorPosition(Xc,Yc);
Console.WriteLine("*");

int x=Xa, y=Ya;

int count =0;
while (count<10000)
{
    int tochcka= new Random().Next(0,3);
    if (tochcka==0)
    {
        x=(x+Xa)/2;
        y=(y+Ya)/2;
    }
    
    if (tochcka==1)
    {
        x=(x+Xb)/2;
        y=(y+Yb)/2;
    }

    if (tochcka==2)
    {
        x=(x+Xc)/2;
        y=(y+Yc)/2;
    }

    Console.SetCursorPosition(x,y);
    Console.WriteLine("+");
    count++;
}


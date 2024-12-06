int hp;
string userinput;              //global variables
bool main = false;

while(main == false)
{

    //checks how much health the user wants and gives it to them if it is within the limit
    Console.WriteLine("How much health do you wish to have 1-20"); 
    userinput = Console.ReadLine();
    if(int.TryParse(userinput, out hp))
    {
        
    if(hp == 20)
    {
        Console.WriteLine("HP: [====================]");        
    }else if(hp == 19)
    {
        Console.WriteLine("HP: [===================]");                 //depending on input the program gives the user its designated wish, could not come up with a better solution to specificy the users input
    }else if(hp == 18)
    {
        Console.WriteLine("HP: [==================]");  
    }else if(hp == 17)
    {
        Console.WriteLine("HP: [=================]");  
    }else if(hp == 16)
    {
        Console.WriteLine("HP: [================]");  
    }else if(hp == 15)
    {
        Console.WriteLine("HP: [===============]");  
    }else if(hp == 14)
    {
        Console.WriteLine("HP: [==============]");  
    }else if(hp == 13)
    {
        Console.WriteLine("HP: [=============]");  
    }else if(hp == 12)
    {
        Console.WriteLine("HP: [============]");  
    }else if(hp == 11)
    {
        Console.WriteLine("HP: [===========]");  
    }else if(hp == 10)
    {
        Console.WriteLine("HP: [==========]");  
    }else if(hp == 9)
    {
        Console.WriteLine("HP: [=========]");  
    }else if(hp == 8)
    {
        Console.WriteLine("HP: [========]");  
    }else if(hp == 7)
    {
        Console.WriteLine("HP: [=======]");  
    }else if(hp == 6)
    {
        Console.WriteLine("HP: [======]");  
    }else if(hp == 5)
    {
        Console.WriteLine("HP: [=====]");  
    }else if(hp == 4)
    {
        Console.WriteLine("HP: [====]");  
    }else if(hp == 3)
    {
        Console.WriteLine("HP: [===]");  
    }else if(hp == 2)
    {
        Console.WriteLine("HP: [==]");  
    }else if(hp == 1)
    {
        Console.WriteLine("HP: [=]");  
    }else{
        Console.WriteLine("Maybe try writing a number that is within the limit");
        Thread.Sleep(1500);
        Console.Clear();
        continue;
    }        
    }else if(string.IsNullOrWhiteSpace(userinput)){                             //last 3 else's makes it bulletproof to missinputs where it detects the issue
        Console.WriteLine("Wrong, perhaps you should try and write something");
        Thread.Sleep(1500);
        Console.Clear();
        continue;
    }else{
        Console.WriteLine("You're not supposed to write letters");
        Thread.Sleep(1500);
        Console.Clear();
        continue;
    }

for(int i = 0; i < hp;)
{

    hp = hp -+ 1;                        
    Console.WriteLine("A wild foe appeared, he dealt 1 damage!");
        if(hp == 20)
    {
        Console.WriteLine("HP: [====================]");        
    }else if(hp == 19)
    {
        Console.WriteLine("HP: [===================]");                 //could not come up with a better solution to specificy the users input
    }else if(hp == 18)                                                  //types out the health of the current user after it has been deducted
    {
        Console.WriteLine("HP: [==================]");  
    }else if(hp == 17)
    {
        Console.WriteLine("HP: [=================]");                    
    }else if(hp == 16)
    {
        Console.WriteLine("HP: [================]");  
    }else if(hp == 15)
    {
        Console.WriteLine("HP: [===============]");  
    }else if(hp == 14)
    {
        Console.WriteLine("HP: [==============]");  
    }else if(hp == 13)
    {
        Console.WriteLine("HP: [=============]");  
    }else if(hp == 12)
    {
        Console.WriteLine("HP: [============]");  
    }else if(hp == 11)
    {
        Console.WriteLine("HP: [===========]");  
    }else if(hp == 10)
    {
        Console.WriteLine("HP: [==========]");  
    }else if(hp == 9)
    {
        Console.WriteLine("HP: [=========]");  
    }else if(hp == 8)
    {
        Console.WriteLine("HP: [========]");  
    }else if(hp == 7)
    {
        Console.WriteLine("HP: [=======]");  
    }else if(hp == 6)
    {
        Console.WriteLine("HP: [======]");  
    }else if(hp == 5)
    {
        Console.WriteLine("HP: [=====]");  
    }else if(hp == 4)
    {
        Console.WriteLine("HP: [====]");  
    }else if(hp == 3)
    {
        Console.WriteLine("HP: [===]");  
    }else if(hp == 2)
    {
        Console.WriteLine("HP: [==]");  
    }else if(hp == 1)
    {
        Console.WriteLine("HP: [=]");  
    }

}
Console.WriteLine();
Console.WriteLine("Shutting down...");
Thread.Sleep(10000);
break;

}
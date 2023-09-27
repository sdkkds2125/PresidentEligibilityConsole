bool naturalBornResult = promptNatBorn();
bool over35Result = promptYearBorn();
bool yearsResidedResult = prompTimeInUS();
bool termsServedResult = prompTermsServed();
bool rebelledResult = promptRebelled();
if (naturalBornResult && over35Result && yearsResidedResult && termsServedResult && !rebelledResult)
{
    Console.WriteLine("Congrats you are eligible to run for president");
}
else
{
    Console.WriteLine("Congrats you are not eligible to run for president (you dodged a bullet there)");
}

static bool promptNatBorn()
{
    String naturalBornAns = "";
    while (naturalBornAns != "y" && naturalBornAns != "n")
    {
        Console.WriteLine("Are you a natural born citizen (y/n)");
        naturalBornAns = Console.ReadLine();
        if (naturalBornAns != "y" && naturalBornAns != "n")
        { Console.WriteLine("Please only answer with a y or an n \ntry again"); }
    }
    return naturalBornAns == "y";
}

static bool promptYearBorn()
{
    int yearBorn = 0;
    while (yearBorn == 0)
    {
        Console.WriteLine("What year were you born (ex: 1993)");
        bool parsable = Int32.TryParse(Console.ReadLine(), out int temp);
        if (!parsable)
        {
            Console.WriteLine("Enter a valid number \ntry again");
        }
        else if (temp < 1000 || temp > 10_000)
        { Console.WriteLine("Please enter a four digit year  \ntry again"); }
        else { yearBorn = temp; }
    }
    return DateTime.Now.Year - yearBorn >= 35;
}

static bool prompTimeInUS()
{
    int yearsResided = -1;
    while (yearsResided == -1)
    {
        Console.WriteLine("How many years have you resided in the US?");
        bool parsable = Int32.TryParse(Console.ReadLine(), out int temp);
        if (!parsable)
        {
            Console.WriteLine("Enter a valid number \ntry again");
        }
        else if(temp < 0 || temp > 200)
        { Console.WriteLine("Please enter a one to three digit number  \ntry again"); }
        else { yearsResided = temp; }
    }
    return yearsResided >= 14;
}

static bool prompTermsServed()
{
    int termsServed = -1;
    while (termsServed == -1)
    {
        Console.WriteLine("How many terms have you served as president?");
        bool parsable = Int32.TryParse(Console.ReadLine(), out int temp);
        if (!parsable)
        {
            Console.WriteLine("Enter a valid number \ntry again");
        }
        else if (temp < 0)
        {
            Console.WriteLine("You could not have served less than zero terms  \ntry again");
        }
        else if (temp > 2)
        {
            Console.WriteLine("It isn't possible to have served more than 2 terms Roosevelt is the only one \n" +
            "and he is dead \ntry again" );
        }
        else { termsServed = temp; }
    }
    return termsServed <= 1;
}

static bool promptRebelled()
{
    String rebelledAns = "";
    while (rebelledAns != "y" && rebelledAns != "n")
    {
        Console.WriteLine("Have you ever rebelled against the US government (y/n)");
        rebelledAns = Console.ReadLine();
        if (rebelledAns != "y" && rebelledAns != "n")
        { Console.WriteLine("Please only answer with a y or an n \n try again"); }
    }
    return rebelledAns == "y";
}
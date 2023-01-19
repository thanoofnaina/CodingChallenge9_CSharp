var ages = new Dictionary<int, string>();
int key = 0;
string value = null;

for(int i = 0; i < 1; i++)
{
    Console.WriteLine($"Enter the date of birth of person {i+1}");
    DateTime dob = new DateTime();
    DateTime.TryParse(Console.ReadLine(), out dob);
    DateTime now = DateTime.Now;
 
    key = now.Year - dob.Year;
    if (key < 10)
    {
        value = "kid";
    }
    else if (key >= 10 && key < 30)
    {
        value = "Youth";
    }
    else if (key >= 30 && key < 60)
    {
        value = "Adult";
    }
    else if (key >= 60)
    {
        value = "Older";
    }
    ages[key] = value;
}

foreach (var i in ages)
{
    Console.WriteLine($"The person has an age {i.Key} and is categorised as {i.Value}.");
}
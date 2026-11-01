var date = DateTime.Now;
var today = DateTime.Today;
var christmas = new DateTime(today.Year + 1, 12, 25);

TimeSpan timeLeft = christmas - today;

Console.WriteLine("Hello, World!");
Console.WriteLine($"The current time is {date}");
Console.WriteLine($"There are {timeLeft.Days} days until Christmas!");
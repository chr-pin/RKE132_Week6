string[] Snacks = { "sushi", "pizza", "burger", "chicken wings", "Asian takeaway" };

Random rnd = new Random();
int randomIndex = rnd.Next(0, Snacks.Length);

Console.WriteLine($"Tonight we are going to eat {Snacks[randomIndex]}");


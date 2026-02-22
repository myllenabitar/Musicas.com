string welcomeMensage = "Welcome to the Music.com!";
Console.WriteLine(welcomeMensage);


void ShowWelcomeMensage()
{
	Console.WriteLine("Welcome to Music.com!");
}

Dictionary<string, List<int>> bandsRegistered = new Dictionary<string, List<int>>();


void ShowMenu()
{
	Console.WriteLine("Select an option:");
	Console.WriteLine("1 - View bands");
	Console.WriteLine("2 - Add a band");
	Console.WriteLine("3 - Delete band");
	Console.WriteLine("4 - Exit");

	Console.Write("Enter your choice:");
	string choice = Console.ReadLine()!;

	int choiceNumber = int.Parse(choice);
	switch (choiceNumber)
	{
		case 1:
			ViewBands();
			break;
		case 2:
			RegisterBand();
			break;
		case 3:
			RageBands();
			break;
		case 4:
			AverageBands();
			break;
	}
	void RegisterBand()
	{
		Console.Clear();
		Console.WriteLine("Enter the name of the band:");
		string bandName = Console.ReadLine()!;
		bandsRegistered.Add(bandName, new List<int>());
		Console.WriteLine($"Band {bandName} registered successfully!");
		Thread.Sleep(2000);
		Console.Clear();
		ShowMenu();
	}
	void ViewBands()
	{
		Console.Clear();
		Console.WriteLine("Registered Bands:");
		foreach (string band in bandsRegistered.Keys)
		{
			Console.WriteLine($"Banda: {band}");
		}
		Console.WriteLine("Press any key to return to the menu.");
		Console.ReadKey();
		Console.Clear();
		ShowMenu();
	}
	void RageBands()
	{
		Console.Clear();
		Console.WriteLine("Enter the name of the band to rage:");
		string bandName = Console.ReadLine()!;
		if (bandsRegistered.ContainsKey(bandName))
		{
			Console.Write($"Qual a nota que a banda: {bandName} merece?");
			int rating = int.Parse(Console.ReadLine()!);
			bandsRegistered[bandName].Add(rating);
			Console.WriteLine($"Band {bandName} raged successfully!");
			Thread.Sleep(4000);
			Console.Clear();
			ShowMenu();
		}
		else
		{
			Console.WriteLine($"Band {bandName} is not registered !");
			Console.WriteLine("Press any key to return to the menu.");
			Console.ReadKey(true);
			ShowMenu();
		}
	}
	void AverageBands()
	{
		Console.Clear();
		Console.WriteLine("Enter the name of the band to view the average rating:");
		string bandName = Console.ReadLine()!;
		if (bandsRegistered.ContainsKey(bandName))
		{
			List<int> ratings = bandsRegistered[bandName];
			if (ratings.Count > 0)
			{
				double average = ratings.Average();
				Console.WriteLine($"The average rating for {bandName} is: {average}");
			}
			else
			{
				Console.WriteLine($"Band {bandName} has no ratings yet.");
			}
		}
		else
		{
			Console.WriteLine($"Band {bandName} is not registered !");
		}
	}

}

ShowWelcomeMensage();
ShowMenu();
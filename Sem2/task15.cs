Console.WriteLine("Введите цифру, обозначающую день недели");
		int number = int.Parse(Console.ReadLine());
		
		if (number < 1 || number > 7) 
		{
			Console.WriteLine("Введите правильное число");
		} 
		else if (number < 6) 
		{
			Console.WriteLine("нет");
		} 
		else 
		{
			Console.WriteLine("да");
		}

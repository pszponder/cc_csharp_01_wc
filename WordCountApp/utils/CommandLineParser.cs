namespace Utils
{
	class CommandLineParser
	{
		private readonly Dictionary<string, string> parsedArgs;

		public CommandLineParser(string[] args)
		{
			parsedArgs = new Dictionary<string, string>();
			ParseArgs(args);
		}

		private void ParseArgs(string[] args)
		{
			for (int i = 0; i < args.Length; i++)
			{
				var arg = args[i];

				// TODO: Add parsed arguments to the dictionary
				if (arg == "-c")
				{
					Console.WriteLine("Byte Count");
				}
				else if (arg == "-l")
				{
					Console.WriteLine("Line Count");
				}
				else if (arg == "-w")
				{
					Console.WriteLine("Word Count");
				}
				else if (arg == "-m")
				{
					Console.WriteLine("Character Count");
				}
				else
				{
					Console.WriteLine("Filename");
				}
			}
		}
	}
}
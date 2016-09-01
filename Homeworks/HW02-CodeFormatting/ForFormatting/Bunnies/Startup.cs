namespace BunniesCreator
{
    using Enumerations;
    using System.Collections.Generic;
    using System.IO;

    class Startup
    {
        static void Main(string[] args)
        {
            var bunnies = new List<Bunny>
            {
                new Bunny {Name = "Leonid", FurType = FurType.NotFluffy, Age= 1 },
                new Bunny {Name = "Rasputin", FurType = FurType.ALittleFluffy, Age= 2},
                new Bunny {Name = "Tiberii", FurType = FurType.ALittleFluffy, Age= 3},
                new Bunny {Name = "Neron", FurType = FurType.ALittleFluffy, Age= 1},
                new Bunny {Name = "Klavdii", FurType = FurType.Fluffy, Age= 3},
                new Bunny {Name = "Vespasian", FurType = FurType.Fluffy, Age= 3},
                new Bunny {Name = "Domician", FurType = FurType.FluffyToTheLimit, Age = 4 },
                new Bunny {Name = "Tit", FurType = FurType.FluffyToTheLimit, Age= 2 }
            };

            // Introduce all bunnies
            var consoleWriter = new ConsoleWriter();
            foreach (var bunny in bunnies)
            {
                bunny.Introduce(consoleWriter);
            }

            // Create bunnies text file
            var bunniesFilePath = @"..\..\bunnies.txt";
            var fileStream = File.Create(bunniesFilePath);
            fileStream.Close();

            // Save bunnies to a text file
            using (var streamWriter = new StreamWriter(bunniesFilePath))
            {
                foreach (var bunny in bunnies)
                {
                    streamWriter.WriteLine(bunny.ToString());
                }
            }
        }
    }
}

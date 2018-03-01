using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using CSVGeneratorTest.Interfaces;

namespace CSVGeneratorTest.Creators {
    class FileCityCreator : FileCreator, ICityCreator {
        public string CreateCity() {
            string[] cityLines = File.ReadAllLines(Path.Combine(FilesPath, "cities.txt"));
            return cityLines[random.Next(0, cityLines.Length)];
        }
    }
}

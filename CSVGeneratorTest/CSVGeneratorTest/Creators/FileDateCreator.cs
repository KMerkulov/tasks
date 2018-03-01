using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using CSVGeneratorTest.Interfaces;

namespace CSVGeneratorTest.Creators {
    class FileDateCreator : FileCreator, IDateCreator {
        public DateTime CreateDate() {
            string[] dateLines = File.ReadAllLines(Path.Combine(FilesPath, "dates.txt"));
            return DateTime.Parse(dateLines[random.Next(0, dateLines.Length)]);
        }
    }
}

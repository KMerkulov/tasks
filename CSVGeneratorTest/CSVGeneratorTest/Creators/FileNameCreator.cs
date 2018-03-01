using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using CSVGeneratorTest.Interfaces;

namespace CSVGeneratorTest.Creators {
    class FileNameCreator : FileCreator, INameCreator {
        public string CreateName() {
            string[] nameLines = File.ReadAllLines(Path.Combine(FilesPath, "names.txt"));
            return nameLines[random.Next(0, nameLines.Length)];
        }
    }
}

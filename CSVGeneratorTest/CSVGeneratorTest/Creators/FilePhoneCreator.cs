using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using CSVGeneratorTest.Interfaces;

namespace CSVGeneratorTest.Creators {
    class FilePhoneCreator : FileCreator, IPhoneCreator {
        public string CreatePnone() {
            string[] phoneLines = File.ReadAllLines(Path.Combine(FilesPath, "phones.txt"));
            return phoneLines[random.Next(0, phoneLines.Length)];
        }
    }
}

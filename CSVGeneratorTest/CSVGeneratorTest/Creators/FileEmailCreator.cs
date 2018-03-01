using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using CSVGeneratorTest.Interfaces;

namespace CSVGeneratorTest.Creators {
    class FileEmailCreator : FileCreator, IEmailCreator {
        public string CreateEmail() {
            string[] emailLines = File.ReadAllLines(Path.Combine(FilesPath, "emails.txt"));
            return emailLines[random.Next(0, emailLines.Length)];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CSVGeneratorTest.Creators {
    abstract class FileCreator {
        protected static Random random = new Random();
        protected static string FilesPath = 
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataFiles");
    }
}

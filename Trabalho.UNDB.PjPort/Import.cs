using System;
using System.IO;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Trabalho.UNDB.PjPort {
    internal class Import {
        public string fileResister;

        public Import(string CrieteImport) { 
            this.fileResister = CrieteImport;
        }

        public void Save (string Name, string Password) { 
            using(StreamWriter writer = File.AppendText(fileResister)) {
                writer.WriteLine($"Nome:{Name}; Senha:{Password}");
            }
        }

        public string[] Load(string fileDirectory) {
            if (!File.Exists(fileDirectory)){
                return new string[0];
            }
            
            return File.ReadAllLines(fileDirectory);
        }
    }
}

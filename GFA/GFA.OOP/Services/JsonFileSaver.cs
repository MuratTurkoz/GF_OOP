﻿using GFA.OOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GFA.OOP.Services
{
    public class JsonFileSaver : IFileSaver
    {
        public void Save(string filename, string content)
        {
            var json = JsonSerializer.Serialize(content);
            File.WriteAllText($"C:\\Users\\Murat\\Desktop\\{filename}.json", json);
        }
    }
}

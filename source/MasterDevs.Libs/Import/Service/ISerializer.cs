﻿using System.IO;
namespace MasterDevs.Lib.Common.Service
{
    public interface ISerializer
    {
        T Deserialize<T>(string json);
        T Deserialize<T>(Stream stream);

        string Serialize<T>(T value);
    }
}
using System.IO;
using UnityEngine;

public static class SaveSystem
{

    public static readonly string SAVE_FOLDER = Application.persistentDataPath + "/saves/";
    public static readonly string FILE_EXT = ".json";

    public static void Save(string FileName, string dataToSave)
    {
        if (!Directory.Exists(SAVE_FOLDER))
        {
            Directory.CreateDirectory(SAVE_FOLDER);
        }

        File.WriteAllText(SAVE_FOLDER + FileName + FILE_EXT, dataToSave);
    }

    public static string Load(string FileName)
    {
        string fileLoc = SAVE_FOLDER + FileName + FILE_EXT;
        if (File.Exists(fileLoc))
        {
            string loadedData = File.ReadAllText(fileLoc);

            return loadedData;
        }
        else
        {
            return null;
        }
    }

}

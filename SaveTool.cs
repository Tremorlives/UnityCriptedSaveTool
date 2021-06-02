using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Text;
namespace SaveToolKit
{
    public static class SaveTool
    {
        static Test test;
        public static void Save(string file,object tosave)
        {
            string json = JsonUtility.ToJson(tosave);
            //Debug.Log(json);
            string criptedjson=SaveTool.Encript_Decript(json, 69);
            //Debug.Log(criptedjson);
            SaveTool.WriteInFile(file, criptedjson);
        }
        public static void Load(string file,object toload)
        {
            string Encriptedjson = SaveTool.ReadFromFile(file);
            string json = SaveTool.Encript_Decript(Encriptedjson, 69);
            JsonUtility.FromJsonOverwrite(json, toload);
        }
        public static void WriteInFile(string file,string text)
        {
            string path = SaveTool.GetFilePath(file);
            FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
            using(StreamWriter writer=new StreamWriter(stream))
            {
                writer.Write(text);
            }
        }
        public static string ReadFromFile(string file)
        {
            string path = SaveTool.GetFilePath(file);
            if (File.Exists(path))
            {
                using(StreamReader reader=new StreamReader(path))
                {
                    string filecontenent = reader.ReadToEnd();
                    return filecontenent;
                }
            }
            else
            {
                Debug.LogError("File not found: " + path);
                return "";
            }
        }
        public static string Encript_Decript(string input,int key)
        {
            StringBuilder stringBuilder = new StringBuilder(input.Length);
            for(int i=0; i < input.Length; i++)
            {
                char ch = (char)(input[i] ^ key);
                stringBuilder.Append(ch);
            }
            return stringBuilder.ToString();
        }
        public static string GetFilePath(string filename)
        {
            return Application.persistentDataPath + "/" + filename;
        }
    }
}


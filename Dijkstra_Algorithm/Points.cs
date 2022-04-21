using System;
using System.IO;
using Newtonsoft.Json;

// using System.Collections.Generic;

namespace HelloWorld
{
    public class Points
    {
        #region Property
        public string json = "";
        public string Json
        {
            get { return json; }
            set { json = value; }
        }
        #endregion

        public Points() { }

        public void Setup()
        {
            Console.WriteLine("Set Up Success !");
        }

        public void ReadJsonFile()
        {
            StreamReader sr = new StreamReader("Points.json");
            string line = sr.ReadLine();

            while (line != null)
            {
                // Console.WriteLine(json);
                Json += line + "\n";
                line = sr.ReadLine();
            }
            Console.WriteLine(Json);

            sr.Close();
        }

        public void ReadJsonData()
        {
            // Console.WriteLine("JSON : " + Json);
            JsonTextReader reader = new JsonTextReader(new StringReader(Json));
            // Console.WriteLine(reader);

            while (reader.Read())
            {
                if (reader.Value != null)
                {
                    Console.WriteLine("Token: {0}, Value: {1}", reader.TokenType, reader.Value);
                }
                // else
                // {
                //     Console.WriteLine("Token Null: {0}", reader.TokenType);
                // }
            }
        }
    }

    // public class Point
    // {
    //     string _ID = "";
    //     public string ID
    //     {
    //         get { return _ID; }
    //         set { _ID = value; }
    //     }

    //     List<int> _NearPos = new List<int>();
    //     public List<int> NearPos
    //     {
    //         get { return _NearPos; }
    //         set { _NearPos = value; }
    //     }

    //     public Point() { }
    // }
}

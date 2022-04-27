using System.Text.Json;

namespace HelloWorld
{
    public class DataHandler
    {
        #region Property
        string? _jsonData;
        public string? jsonData
        {
            get { return _jsonData; }
            set { _jsonData = value; }
        }

        string? _json_filename;
        public string? json_Filename
        {
            get { return _json_filename; }
            set { _json_filename = value; }
        }

        public List<Point>? Point_L;
        #endregion

        public DataHandler()
        {

        }

        public void ReadJsonFile()
        {
            Console.WriteLine("----------------------------Read File Start!----------------------------");
            string? json_Filename = "ExamplePoints_List.json";
            Console.WriteLine("Filename : " + json_Filename);

            string? jsonData = File.ReadAllText(json_Filename);
            Console.WriteLine("Data : " + jsonData);

            Point_L = JsonSerializer.Deserialize<List<Point>>(jsonData)!;

            // Show Points List
            // foreach (Point point in Point_L)
            // {
            //     Console.WriteLine($"Point_Id: {point?.Point_Id}");
            //     Console.WriteLine($"Point_Name: {point?.Point_Name}");

            //     foreach (KeyValuePair<string, NearPoint> kvp in point?.NearPoints)
            //     {
            //         Console.WriteLine("NearPoint = {0}, Path = {1} , Weight = {2}", kvp.Key, kvp.Value.Path, kvp.Value.Weight);
            //     }
            //     Console.WriteLine();
            // }
            Console.WriteLine();
        }

        // public void SaveJsonFile()
        // {

        // }
    }

    // DataModel
    public class Point
    {
        public int Point_Id { get; set; }
        public string? Point_Name { get; set; }
        public Dictionary<string, NearPoint>? NearPoints { get; set; }
    }

    public class NearPoint
    {
        public int Path { get; set; }
        public int Weight { get; set; }
    }
}
using System.Text.Json;

namespace HelloWorld
{
    public class Dijkstra
    {
        DataHandler? dataHandler;
        List<AlgorithmModel> algorithmModel = new List<AlgorithmModel>();
        AlgorithmModel _AlgorithmModel = new AlgorithmModel();

        public Dijkstra(DataHandler? _dataHandler)
        {
            dataHandler = _dataHandler;
            // Console.WriteLine("Algorithm Point_Name : " + dataHandler?.Point_L?[0].Point_Name);
            for (int i = 0; i < dataHandler?.Point_L?.Count; i++)
            {
                algorithmModel.Add(_AlgorithmModel);
            }
            // Console.WriteLine("Count : {0} , {1}" , algorithmModel.Count , dataHandler?.Point_L?.Count);
        }

        public void Algotithm_Start(string startPos, string endPos)
        {
            Console.WriteLine("------------------Algotithm Start!------------------");
            startPos = "A";
            endPos = "F";
            Console.WriteLine("Start Position : " + startPos);
            Console.WriteLine("End Position : " + endPos);



        }
    }

    //DataModel
    public class AlgorithmModel
    {
        #region Property
        int _BeginPoint = 999999;
        public int BeginPoint
        {
            get { return _BeginPoint; }
            set { _BeginPoint = value; }
        }

        int _BeforePoint = 999999;
        public int BeforePoint
        {
            get { return _BeforePoint; }
            set { _BeforePoint = value; }
        }

        bool _Mark = false;
        public bool Mark
        {
            get { return _Mark; }
            set { _Mark = value; }
        }        
        #endregion
    }
}
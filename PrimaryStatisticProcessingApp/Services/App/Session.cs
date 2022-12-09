using System.Collections.Generic;

namespace PrimaryStatisticProcessingApp.Services.App
{
    public class Session
    {
        public List<string> FilePathList { get; set; } = new List<string>();

        public Session()
        {
        }

        public Session(List<string> filePathList)
        {
            FilePathList = filePathList;
        }
    }
}
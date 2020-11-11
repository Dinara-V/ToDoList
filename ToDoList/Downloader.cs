using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class Downloader
    {
        WebClient client = new WebClient();
        string _url;
        string _path;
        public Downloader(string url, string path)
        {
            _url = url;
            _path = path;
            //client.DownloadFileAsync(new Uri(url), folderBrowser.SelectedPath + "\\" + "1.txt");
        }

        public bool DownloadFile()
        {
            // client.OpenRead(_url);
            try
            {
                client.DownloadData(_url);
                //if (!String.IsNullOrEmpty(client.ResponseHeaders["Content-Disposition"]))
                //{
                    string fileName = client.ResponseHeaders["Content-Disposition"]
                        .Substring(client.ResponseHeaders["Content-Disposition"]
                        .IndexOf("filename=") + 9).Replace("\"", "");

                    client.DownloadFileAsync(new Uri(_url), _path + "\\" + fileName);
                    //Console.WriteLine(fileName);
                //}
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

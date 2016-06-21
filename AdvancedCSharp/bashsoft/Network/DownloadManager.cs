using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft
{
    public static class DownloadManager
    {
        public static void Download(string fileUrl)
        {
            WebClient webClient = new WebClient();

            try
            {
                OutputWriter.WriteMessageOnNewLine("Started downloading: ");

                string nameOfFile = ExtractNameOfFile(fileUrl);
                string pathToDownload = SesionData.currentPath + "/" + nameOfFile;

                webClient.DownloadFile(fileUrl, pathToDownload);

                OutputWriter.WriteMessageOnNewLine("Download complete");
            }
            catch (WebException ex)
            {
                OutputWriter.DisplayException(ex.Message);
            }
        }

        public static void DownloadAsync(string fileUrl)
        {
            Task.Run(() => Download(fileUrl));
        }

        private static string ExtractNameOfFile(string fileUrl)
        {
            int indexOfLastBackSlash = fileUrl.LastIndexOf("/");

            if (indexOfLastBackSlash != -1)
            {

            }
            else
            {
                throw new WebException(ExceptionMessages.InvalidPath);
            }
            return fileUrl.Substring(indexOfLastBackSlash + 1);
        }
    }
}

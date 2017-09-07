using System.Diagnostics;
using System.IO;

namespace DPA_Musicsheets.Managers
{
    public class FileSaver
    {
        public void ToLilypond(string fileName, string lilypondText)
        {
            using (var outputFile = new StreamWriter(fileName))
            {
                outputFile.Write(lilypondText);
                outputFile.Close();
            }
        }

        public void ToPdf(string fileName, string lilypondText)
        {
            var tmpFileName = $"{fileName}-tmp.ly";
            ToLilypond(tmpFileName, lilypondText);

            const string lilypondLocation = @"C:\Program Files (x86)\LilyPond\usr\bin\lilypond.exe";
            var sourceFolder = Path.GetDirectoryName(tmpFileName);
            var sourceFileName = Path.GetFileNameWithoutExtension(tmpFileName);
            var targetFolder = Path.GetDirectoryName(fileName);
            var targetFileName = Path.GetFileNameWithoutExtension(fileName);

            var process = new Process
            {
                StartInfo =
                {
                    WorkingDirectory = sourceFolder ?? throw new DirectoryNotFoundException(),
                    WindowStyle = ProcessWindowStyle.Hidden,
                    Arguments = $"--pdf \"{sourceFolder}\\{sourceFileName}.ly\"",
                    FileName = lilypondLocation
                }
            };

            process.Start();
            while (process.HasExited)
            {
                if (sourceFolder == targetFolder && sourceFileName == targetFileName) return;
                File.Move(sourceFolder + "\\" + sourceFileName + ".pdf", targetFolder + "\\" + targetFileName + ".pdf");
                File.Delete(tmpFileName);
                break;
            }
        }
    }
}
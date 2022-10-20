using System.Text;

namespace DirectoryFiles;

public static class FileDirOperation
{
    public static void WriteSile(FileInfo fileInfo)
    {
        using (FileStream fs = fileInfo.Open(FileMode.Create, FileAccess.Write, FileShare.None))
        {
            string text = $"{fileInfo.FullName} \n {fileInfo.CreationTime}";
            using (StreamWriter writer = new StreamWriter(fs, Encoding.Unicode))
            {
                writer.Write(text);
                Console.WriteLine("Данные записаны");
            }

        }
    }

    public static string readFile(FileInfo file)
    {
        using (FileStream fs = file.OpenRead())
        {
            using (StreamReader sr = new StreamReader(fs, Encoding.Unicode))
            {
                return sr.ReadToEnd();
            }
        }
    }
}

using DirectoryFiles;

Console.WriteLine("Введите название директории");

DirectoryInfo dir = new DirectoryInfo($"C:\\"+ Console.ReadLine());

if (!dir.Exists)
{
    dir.Create();
}

Console.WriteLine("Введите название файла");

string nameFile = Console.ReadLine();

DirectoryInfo dir1 = dir.CreateSubdirectory(nameFile.Substring(0,1));

FileInfo file = new FileInfo(dir1 + $"\\{nameFile}.txt");

FileDirOperation.WriteSile(file);



Console.WriteLine("Введите название нового файла");

string newnamefile = Console.ReadLine();

DirectoryInfo dir2 = dir.CreateSubdirectory(newnamefile.Substring(0,1));

FileInfo newFile = new FileInfo(dir2 + $"\\{newnamefile}.txt");

file.MoveTo(dir2 + $"\\{newnamefile}.txt");

Console.WriteLine("Данные перезаписаны");




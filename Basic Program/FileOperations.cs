using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class FileOperations
    {
        public void CreateFile()
        {
            FileInfo fi = new FileInfo("C:\\Users\\Administrator\\Desktop\\Files\\Sample.txt");
            using StreamWriter stw = fi.CreateText();
            Console.WriteLine("File has been created");
            stw.WriteLine("Hello there");
            stw.WriteLine("How r u?");
            Console.WriteLine("written");
        }
        public void WriteData()
        {
            FileStream fs = new FileStream("C:\\Users\\Administrator\\Desktop\\Files\\Sample1.txt", FileMode.Create, FileAccess.Write);
            StreamWriter stw = new StreamWriter(fs);
            Console.WriteLine("enter the text u want to write to file");
            string? str = Console.ReadLine();
            stw.WriteLine(str);
            stw.Flush();
            stw.Close();
            fs.Close();
        }
        public void ReadData()
        {
            FileStream fs = new FileStream("C:\\Users\\Administrator\\Desktop\\Files\\Sample.txt", FileMode.Open, FileAccess.Read);
            StreamReader stream = new StreamReader(fs);
            stream.BaseStream.Seek(0, SeekOrigin.Begin);
            string? str = stream.ReadLine();
            while(str != null)
            {
                Console.WriteLine(str);
                str = stream.ReadLine();
            }
            stream.Close();
            fs.Close();
        }
        public void CopyMoveFile()
        {
            FileInfo fi = new FileInfo("C:\\Users\\Administrator\\Desktop\\Files\\Sample.txt");
            FileInfo fii = new FileInfo("C:\\Users\\Administrator\\Desktop\\Files\\Sample1.txt");
            fi.CopyTo("C:\\Users\\Administrator\\Desktop\\Files\\temp\\Sample.txt");
            fii.MoveTo("C:\\Users\\Administrator\\Desktop\\Files\\temp1\\Sample1.txt");
        }
        public void DeleteFile()
        {
            FileInfo fi = new FileInfo("C:\\Users\\Administrator\\Desktop\\Files\\Sample.txt");
            fi.Delete();
        }
        public void FileProperties()
        {
            FileInfo fi = new FileInfo("C:\\Users\\Administrator\\Desktop\\Files\\Sample.txt");
            Console.WriteLine(fi.FullName);
            Console.WriteLine(fi.Name);
            //Console.WriteLine(fi.Length.ToString());
            Console.WriteLine(fi.LinkTarget);
            Console.WriteLine(fi.CreationTime);
            Console.WriteLine(fi.Extension);
            Console.WriteLine(fi.Directory);
            Console.WriteLine(fi.Exists);
            Console.WriteLine(fi.LastWriteTime);
        }
    }
}

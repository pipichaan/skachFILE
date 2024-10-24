using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        using (WebClient wc = new WebClient())
        {
            string file = "https://vscode.ru/filesForArticles/test.docx";
            string papka = @"C:\Users\alina\OneDrive\Рабочий стол\2 курс\системка\сохранениефайла\";
            string name = "Тестовый файл.docx";
            try
            {
                wc.DownloadFile(file, papka + name);
                Console.WriteLine("файл скачен в " + papka + name);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ошибка " + ex.Message);
            }
        }
    }
}
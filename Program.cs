

// File.WriteAllText("myfile.txt", "Hi Henny");
// Console.WriteLine("Your file has been created.");


File.WriteAllText(@"C:\Users\ZAYNAB\OneDrive\Desktop\MGQSFile.txt", "Zaynab Enitan Opaleke");
Directory.CreateDirectory(@"C:\Users\ZAYNAB\OneDrive\Desktop\MGQSFolder");
Directory.Delete(@"C:\Users\ZAYNAB\OneDrive\Desktop\MGQSFolder");

string fullName = "Zaynab Enitan Opaleke";

for (int i = 0; i < 10; i++)
{
    File.AppendAllText(@"C:\Users\ZAYNAB\OneDrive\Desktop\MGQSFile.txt", fullName + Environment.NewLine);
}

File.Copy(@"C:\Users\ZAYNAB\OneDrive\Desktop\MGQSFile.txt", @"C:\Users\ZAYNAB\OneDrive\Desktop\MGQSFile.docx");




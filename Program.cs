

// File.WriteAllText("myfile.txt", "Hi Henny");
// Console.WriteLine("Your file has been created.");

// var desktopPath = @"C:\Users\ZAYNAB\Desktop";
// var aFileFilePath = $"{desktopPath}aFile.txt";
// Console.WriteLine("Your file has been created");

// var myNewFile = $"{desktopPath}myNewFolder";
// File.Create($"{desktopPath}testing");



//Assignment
//Write a code in your program.cs that.....
//Create a file called MGQSFile.txt in desktop
//Create a folder called MGQSFIle.txt from your desktop into MGQSFolder
//Delete MGQSFolder
//Type your full name in 10 different rows inside of MGQSFile.txt in desktop and copy the content of MGQSFile.txt into a new file MGQSFile.docx in desktop


File.WriteAllText(@"C:\Users\ZAYNAB\OneDrive\Desktop\MGQSFile.txt", "Zaynab Enitan Opaleke");
Directory.CreateDirectory(@"C:\Users\ZAYNAB\OneDrive\Desktop\MGQSFolder");
Directory.Delete(@"C:\Users\ZAYNAB\OneDrive\Desktop\MGQSFolder");

string fullName = "Zaynab Enitan Opaleke";

for (int i = 0; i < 10; i++)
{
    File.AppendAllText(@"C:\Users\ZAYNAB\OneDrive\Desktop\MGQSFile.txt", fullName + Environment.NewLine);
}

File.Copy(@"C:\Users\ZAYNAB\OneDrive\Desktop\MGQSFile.txt", @"C:\Users\ZAYNAB\OneDrive\Desktop\MGQSFile.docx");
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Management.Automation;

public class SearchString
{
    public void ExecuteScript(string searchString, string serverName)
    {
        string scriptFile = "StringSearch.ps1";
        string scriptPath = Path.GetFullPath(scriptFile); // Looks for real path within script in case it moves
        string resultsPath = "./Results/" + serverName + ".csv";

        if (File.Exists(resultsPath)) // Deletes the file if it already exists to remove old values
        {
            File.Delete(resultsPath);
        }

        ProcessStartInfo processInfo = new ProcessStartInfo();

        processInfo.FileName = "powershell.exe";
        processInfo.Arguments = $"-ExecutionPolicy Bypass -File \"{scriptPath}\" -searchString " + searchString + " -serverName " + serverName + "";
        processInfo.Verb = "runas";

        Process process = new Process();
        process.StartInfo = processInfo;

        try
        {
            process.Start();
            process.WaitForExit();

            int exitCode = process.ExitCode;
            Console.WriteLine("script exited with code " + exitCode + ".");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

    public void filterFile(List<string> selectedExtensions, string serverName, bool filterChecked)
    {
        string[] extensionList = selectedExtensions.ToArray();
        string archiveFilter = "archive";
        string resultsPath = "./Results/" + serverName + ".csv";
        List<string> resultExport = new List<string>();

        // Build an array of data based off of what was pulled
        string[] results = File.ReadAllLines(resultsPath);
        foreach (string str1 in results)
        {
            if (filterChecked == true)
            {
                Console.WriteLine(str1);
                resultExport.Add(str1);
            }
            else
            {
                foreach (string str2 in extensionList)
                {
                    if (str1.ToLower().Contains(str2.ToLower()) 
                        && !str1.ToLower().Contains(archiveFilter) 
                        && !str1.ToLower().Contains(str2.ToLower() + "."))
                    {
                        Console.WriteLine(str1);
                        resultExport.Add(str1);
                    }
                }
            }          
        }
        using (StreamWriter writer = new StreamWriter(resultsPath, false))
        {
            foreach (string result in resultExport)
            {
                writer.WriteLine(result);
            }
        }
    }
}


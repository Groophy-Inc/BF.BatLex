﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace BatLex_NonFigured
{
    class Program
    {

        private static System.Collections.Generic.List<string[]> KeyWords = new System.Collections.Generic.List<string[]>(
            new string[][]
            {
                new string[]{"echo","echo","Microsoft Common tools","Displays messages or turns command echoing on or off."},
                #region KeyWords
                new string[]{"assoc","assoc","Microsoft Common tools","Displays or modifies file extension associations."},
                new string[]{"attrib","attrib","Microsoft Common tools","Displays or changes file attributes."},
                new string[]{"break","break","Microsoft Common tools","Sets or clears extended CTRL+C checking."},
                new string[]{"bcdedit","bcdedit","Microsoft Common tools","Sets properties in boot database to control boot loading."},
                new string[]{"cacls","cacls","Microsoft Common tools","Displays or modifies access control lists (ACLs) of files."},
                new string[]{"call","call","Microsoft Common tools","Calls one batch program from another."},
                new string[]{"cd","cd","Microsoft Common tools","Displays the name of or changes the current directory."},
                new string[]{"chcp","chcp","Microsoft Common tools","Displays or sets the active code page number."},
                new string[]{"chdir","chdir","Microsoft Common tools","Displays the name of or changes the current directory."},
                new string[]{"chkdsk","chkdsk","Microsoft Common tools","Checks a disk and displays a status report."},
                new string[]{"chkntfs","chkntfs","Microsoft Common tools","Displays or modifies the checking of disk at boot time."},
                new string[]{"cls","cls","Microsoft Common tools","Clears the screen."},
                new string[]{"cmd","cmd","Microsoft Common tools","Starts a new instance of the Windows command interpreter."},
                new string[]{"color","color","Microsoft Common tools","Sets the default console foreground and background colors."},
                new string[]{"comp","comp","Microsoft Common tools","Compares the contents of two files or sets of files."},
                new string[]{"compact","compact","Microsoft Common tools","Displays or alters the compression of files on NTFS partitions."},
                new string[]{"convert","convert","Microsoft Common tools","Converts FAT volumes to NTFS.  You cannot convert the current drive."},
                new string[]{"copy","copy","Microsoft Common tools","Copies one or more files to another location."},
                new string[]{"date","date","Microsoft Common tools","Displays or sets the date."},
                new string[]{"del","del","Microsoft Common tools","Deletes one or more files."},
                new string[]{"dir","dir","Microsoft Common tools","Displays a list of files and subdirectories in a directory."},
                new string[]{"diskcomp","diskcomp","Microsoft Common tools","Compares the contents of two floppy disks."},
                new string[]{"diskcopy","diskcopy","Microsoft Common tools","Copies the contents of one floppy disk to another."},
                new string[]{"diskpart","diskpart","Microsoft Common tools","Displays or configures Disk Partition properties."},
                new string[]{"doskey","doskey","Microsoft Common tools","Edits command lines recalls Windows commands and creates macros."},
                new string[]{"driverquery","driverquery","Microsoft Common tools","Displays current device driver status and properties."},
                //echo is in first 
                new string[]{"echo.","echo.","Microsoft Common tools","Displays messages or turns command echoing on or off."},
                new string[]{"endlocal","endlocal","Microsoft Common tools","Ends localization of environment changes in a batch file."},
                new string[]{"erase","erase","Microsoft Common tools","Deletes one or more files."},
                new string[]{"exit","exit","Microsoft Common tools","Quits the CMD.EXE program (command interpreter)."},
                new string[]{"fc","fc","Microsoft Common tools","Compares two files or sets of files and displays the differences between them."},
                new string[]{"find","find","Microsoft Common tools","Searches for a text string in a file or files."},
                new string[]{"findstr","findstr","Microsoft Common tools","Searches for strings in files."},
                new string[]{"for","for","Microsoft Common tools","Runs a specified command for each file in a set of files."},
                new string[]{"format","format","Microsoft Common tools","Formats a disk for use with Windows."},
                new string[]{"fsutil","fsutil","Microsoft Common tools","Displays or configures the file system properties."},
                new string[]{"ftype","ftype","Microsoft Common tools","Displays or modifies file types used in file extension associations."},
                new string[]{"goto","goto","Microsoft Common tools","Directs the Windows command interpreter to a labeled line in a batch program."},
                new string[]{"gpresult","gpresult","Microsoft Common tools","Displays Group Policy information for machine or user."},
                new string[]{"graftabl","graftabl","Microsoft Common tools","Enables Windows to display an extended character set in graphics mode."},
                new string[]{"help","help","Microsoft Common tools","Provides Help information for Windows commands."},
                new string[]{"icacls","icacls","Microsoft Common tools","Display modify backup or restore ACLs for files and directories."},
                new string[]{"if","if","Microsoft Common tools","Performs conditional processing in batch programs."},
                new string[]{"label","label","Microsoft Common tools","Creates changes or deletes the volume label of a disk."},
                new string[]{"md","md","Microsoft Common tools","Creates a directory."},
                new string[]{"mkdir","mkdir","Microsoft Common tools","Creates a directory."},
                new string[]{"mklink","mklink","Microsoft Common tools","Creates Symbolic Links and Hard Links."},
                new string[]{"mode","mode","Microsoft Common tools","Configures a system device."},
                new string[]{"more","more","Microsoft Common tools","Displays output one screen at a time."},
                new string[]{"move","move","Microsoft Common tools","Moves one or more files from one directory to another directory."},
                new string[]{"openfiles","openfiles","Microsoft Common tools","Displays files opened by remote users for a file share."},
                new string[]{"path","path","Microsoft Common tools","Displays or sets a search path for executable files."},
                new string[]{"pause","pause","Microsoft Common tools","Suspends processing of a batch file and displays a message."},
                new string[]{"popd","popd","Microsoft Common tools","Restores the previous value of the current directory saved by PUSHD."},
                new string[]{"print","print","Microsoft Common tools","Prints a text file."},
                new string[]{"promp","promp","Microsoft Common tools","Changes the Windows command prompt."},
                new string[]{"pushd","pushd","Microsoft Common tools","Saves the current directory then changes it."},
                new string[]{"rd","rd","Microsoft Common tools","Removes a directory."},
                new string[]{"recover","recover","Microsoft Common tools","Recovers readable information from a bad or defective disk."},
                new string[]{"rem","rem","Microsoft Common tools","Records comments (remarks) in batch files or CONFIG.SYS."},
                new string[]{"::","::","Microsoft Common tools","Records comments (remarks) in batch files or CONFIG.SYS."},
                new string[]{"ren","ren","Microsoft Common tools","Renames a file or files."},
                new string[]{"rename","rename","Microsoft Common tools","Renames a file or files."},
                new string[]{"replace","replace","Microsoft Common tools","Replaces files."},
                new string[]{"rmdir","rmdir","Microsoft Common tools","Removes a directory."},
                new string[]{"robocopy","robocopy","Microsoft Common tools","Advanced utility to copy files and directory trees."},
                new string[]{"set","set","Microsoft Common tools","Displays sets or removes Windows environment variables."},
                new string[]{"setlocal","setlocal","Microsoft Common tools","Begins localization of environment changes in a batch file."},
                new string[]{"sc","sc","Microsoft Common tools","Displays or configures services (background processes)."},
                new string[]{"schtasks","schtasks","Microsoft Common tools","Schedules commands and programs to run on a computer."},
                new string[]{"shift","shift","Microsoft Common tools","Shifts the position of replaceable parameters in batch files."},
                new string[]{"shutdown","shutdown","Microsoft Common tools","Allows proper local or remote shutdown of machine."},
                new string[]{"sort","sort","Microsoft Common tools","Sorts input."},
                new string[]{"start","start","Microsoft Common tools","Starts a separate window to run a specified program or command."},
                new string[]{"subst","subst","Microsoft Common tools","Associates a path with a drive letter."},
                new string[]{"systeminfo","systeminfo","Microsoft Common tools","Displays machine specific properties and configuration."},
                new string[]{"tasklist","tasklist","Microsoft Common tools","Displays all currently running tasks including services."},
                new string[]{"taskkill","taskkill","Microsoft Common tools","Kill or stop a running process or application."},
                new string[]{"time","time","Microsoft Common tools","Displays or sets the system time."},
                new string[]{"title","title","Microsoft Common tools","Sets the window title for a CMD.EXE session."},
                new string[]{"tree","tree","Microsoft Common tools","Graphically displays the directory structure of a drive or path."},
                new string[]{"type","type","Microsoft Common tools","Displays the contents of a text file."},
                new string[]{"ver","ver","Microsoft Common tools","Displays the Windows version."},
                new string[]{"verify","verify","Microsoft Common tools","Tells Windows whether to verify that your files are written correctly to a disk."},
                new string[]{"vol","vol","Microsoft Common tools","Displays a disk volume label and serial number."},
                new string[]{"xcopy","xcopy","Microsoft Common tools","Copies files and directory trees."},
                new string[]{"wmic","wmic","Microsoft Common tools","Displays WMI information inside interactive command shell."}
#endregion
            });

        private static List<label> labels = new List<label>();

        public struct errors
        {
            public int Line { get; set; }
            public twot[] Errors { get; set; }
        }

        public struct twot
        {
            public int StartIndex { get; set; }
            public int Lenght { get; set; }
        }

        public struct label
        {
            public int Line { get; set; }
            public string Name { get; set; }
        }

        private static List<errors> errorlist = new List<errors>();
        static int ErrorCount = 0;

        public enum Types
        {
            KeyWord,
            Varriable,
            Bracked,
            UpdateKey,
            Parameter
        }

        public struct LexStruct
        {
            public string Word { get; set; }
            public string Desc { get; set; }
            public Types Type { get; set; }
        }

        static void Main(string[] args)
        {
            StringBuilder Result = new StringBuilder();
            StringBuilder Logs = new StringBuilder();
            string[] lines = File.ReadAllLines(args[0]);

            Result.Append("Labels:" + Environment.NewLine);
            for (int i = 0; i < lines.Length; i++)
            { try { if (lines[i].Replace(" ", "").Substring(0, 1) == ":" && lines[i].Replace(" ", "").Substring(1, 1) != ":") { labels.Add(new label(){Line=i, Name=lines[i].Replace(" ", "").Substring(1)}); Result.Append(i.ToString() + ": " + lines[i].Replace(" ", "").Substring(1) + Environment.NewLine); } } catch { } }
            Result.Append("---Labels-End---"+Environment.NewLine+Environment.NewLine);

            for (int i = 0; i < lines.Length; i++)
            {
                Result.Append(i.ToString() + "-");
                string syntax = string.Empty;
                bool syntaxfound = false;

                lines[i] = fixline(lines[i]);

                string[] parts = lines[i].Split(' ');

                for (int i2 = 0;i2 < parts.Length;i2++)
                {
                    
                    if (i2 == 0)
                    {
                        for (int findkeyword = 0; findkeyword < KeyWords.Count; findkeyword++)
                        {
                            try
                            {
                                if (string.IsNullOrEmpty(lines[i].Replace(" ", "")) || lines[i].Replace(" ", "") == ")")
                                {
                                    syntax = "";
                                    syntaxfound = true;
                                    break;
                                }
                            }
                            catch { }
                            try
                            {
                                bool mustbreak = false;
                                for (int p = 0; p < labels.Count; p++)
                                {
                                    if (i == labels[p].Line)
                                    {
                                        syntax = "label";
                                        syntaxfound = true;
                                        mustbreak = true;
                                        break;
                                    }
                                }
                                if (mustbreak)
                                {
                                    break;
                                }
                            }
                            catch { }
                            try
                            {
                                string of = lines[i].Replace(" ", "").Substring(0, KeyWords[findkeyword][0].Length).ToLower().Replace("ı", "i");
                                if (of == KeyWords[findkeyword][0])
                                {
                                    syntaxfound = true;
                                    syntax = KeyWords[findkeyword][0];
                                    break;
                                }
                                if (of.Substring(0, 1) == "@")
                                {
                                    if (lines[i].Replace(" ", "").Substring(1, KeyWords[findkeyword][0].Length).ToLower().Replace("ı", "i") == KeyWords[findkeyword][0])
                                    {
                                        syntaxfound = true;
                                        syntax = KeyWords[findkeyword][0];
                                        break;
                                    }
                                }
                            }
                            catch { }

                        }// find syntax end

                        if (syntaxfound)
                        {
                            Print(syntax+" ", ConsoleColor.Green);

                            if (syntax == "rem" || syntax == "::")
                            {
                                for (int p = i2+1; p < parts.Length; p++)
                                {
                                    Print(parts[p] + " ", ConsoleColor.DarkGreen);
                                }
                                break;
                            }
                        }
                        else
                        {
                            Print("Syntax not found!(", ConsoleColor.Red);
                            Print(parts[i2], ConsoleColor.DarkRed);
                            Print(") ", ConsoleColor.Red);
                        }
                    }
                    else
                    {
                        if (parts[i2].StartsWith("/"))
                        {
                            Print(parts[i2] + " ", ConsoleColor.Yellow);
                        }
                        else
                        {
                            Print(parts[i2] + " ", ConsoleColor.White);
                        }
                    }
                }
                nl();
            }
            Console.ReadKey();
        }

        static string fixline(string line)
        {
            while (line.IndexOf("  ") != -1)
            {
                line = line.Replace("  ", " ");
            }
            return line;
        }

        static void Print(string text, ConsoleColor color)
        {
            ConsoleColor old = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ForegroundColor = old;
        }

        static void nl()
        {
            Console.Write("\r\n");
        }
    }
}

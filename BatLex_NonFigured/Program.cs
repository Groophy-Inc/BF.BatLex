using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace BatLex_NonFigured
{
    class Program
    {
        private static List<CoreClasses.label> labels = new List<CoreClasses.label>();

        private static List<CoreClasses.errors> errorlist = new List<CoreClasses.errors>();
        static int ErrorCount = 0;

        static StringBuilder Result = new StringBuilder();
        static StringBuilder Logs = new StringBuilder();


        static void Main(string[] args)
        {
            //line-syntax, si:l, type, extra, parameters[]

            //echo hello world
            //1-echo, 0:4, 0, 0, null, [hello, 5:5, 4, null; world, 11:5, 4, null]

            string[] lines = File.ReadAllLines(args[0]);

            CheckLabels(lines);

            for (int i = 0; i < lines.Length; i++)
            {
                Result.Append(i.ToString() + "-");
                string syntax = string.Empty;
                bool syntaxfound = false;

                lines[i] = fixline(lines[i]);

                string[] parts = lines[i].Split(' ');

                bool breakline = false;

                for (int i2 = 0;i2 < parts.Length;i2++)
                {
                    if (i2 == 0)
                    {
                        for (int findkeyword = 0; findkeyword < KeyStorage.KeyWords.Count; findkeyword++)
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
                                string of = lines[i].Replace(" ", "").Substring(0, KeyStorage.KeyWords[findkeyword][0].Length).ToLower().Replace("ı", "i");
                                if (of == KeyStorage.KeyWords[findkeyword][0])
                                {
                                    syntaxfound = true;
                                    syntax = KeyStorage.KeyWords[findkeyword][0];
                                    break;
                                }
                                if (of.Substring(0, 1) == "@")
                                {
                                    if (lines[i].Replace(" ", "").Substring(1, KeyStorage.KeyWords[findkeyword][0].Length).ToLower().Replace("ı", "i") == KeyStorage.KeyWords[findkeyword][0])
                                    {
                                        syntaxfound = true;
                                        syntax = KeyStorage.KeyWords[findkeyword][0];
                                        break;
                                    }
                                }
                            }
                            catch { }

                        }// find syntax end

                        //line-syntax, si:l, type, parameters[]
                        if (syntaxfound)
                        {
                            Print(syntax, ConsoleColor.Green);

                            if (syntax == "rem" || syntax == "::")
                            {
                                for (int p = i2+1; p < parts.Length; p++)
                                {
                                    Print(" "+parts[p], ConsoleColor.DarkGreen);
                                }
                                Result.Append(syntax+", "+"0:"+syntax.Length+", 0, comment");
                                breakline = true;
                                break;
                            }
                            else if (syntax == "label")
                            {
                                bool fo = false;
                                for (int l = 0; l < labels.Count; l++)
                                {
                                    if (i == labels[l].Line)
                                    {
                                        Print("("+labels[l].Name+")" , ConsoleColor.Cyan);
                                        fo = true;
                                        Result.Append(syntax + ", " + "0:" + syntax.Length + ", 0, EL:0'LN:"+labels[l].Name);
                                        break;
                                    }
                                }
                                if (!fo)
                                {
                                    Result.Append(syntax + ", " + "0:" + syntax.Length + ", 0, EL:1'LN:"+parts[i2].Substring(1));
                                }
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
                            Print(" "+parts[i2], ConsoleColor.Yellow);
                        }
                        else
                        {
                            Print(" "+parts[i2], ConsoleColor.White);
                        }
                    }
                    if (breakline) break;
                }
                nl();
                Result.Append("\r\n");
            }

            File.WriteAllText("res.txt", Result.ToString());

            StringBuilder bat = new StringBuilder();
            string[] ln = Result.ToString().Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            bat.Append("@echo off\r\n");
            bat.Append("title " + Path.GetFileName(args[0])+"\r\n");
            for (int i = 0; i < ln.Length;i++ )
            {
                if (!string.IsNullOrEmpty(ln[i]))
                {
                    bat.Append("Echo " + ln[i] + "\r\n");
                }
            }
            bat.Append("Pause");
            File.WriteAllText("res.bat", bat.ToString());
            Process.Start("res.bat");

            Console.ReadKey();
        }

        static void CheckLabels(string[] lines)
        {
            Result.Append("Labels:" + Environment.NewLine);
            for (int i = 0; i < lines.Length; i++)
            { try { if (lines[i].Replace(" ", "").Substring(0, 1) == ":" && lines[i].Replace(" ", "").Substring(1, 1) != ":") { labels.Add(new CoreClasses.label() { Line = i, Name = lines[i].Replace(" ", "").Substring(1) }); Result.Append(i.ToString() + ": " + lines[i].Replace(" ", "").Substring(1) + Environment.NewLine); } } catch { } }
            Result.Append("---Labels-End---" + Environment.NewLine + Environment.NewLine);
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

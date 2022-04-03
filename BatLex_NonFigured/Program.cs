using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

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
            string[] lines = File.ReadAllLines(args[0]);

            CheckLabels(lines);

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

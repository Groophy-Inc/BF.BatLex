using System;
namespace BatLex_NonFigured
{
    class CoreClasses
    {
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
    }
}

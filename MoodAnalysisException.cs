﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Analyser_ExceptionHandling
{
    public class MoodAnalysisException : Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE,
            EMPTY_MESSAGE,
            NO_SUCH_FIELD,
            NO_SUCH_METHOD,
            NO_SUCH_CLASS,
            OBJECT_CREATION_ISSUE
        }

        private readonly ExceptionType type;

        public MoodAnalysisException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}

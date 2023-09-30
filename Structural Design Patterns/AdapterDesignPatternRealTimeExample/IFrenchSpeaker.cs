﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPatternRealTimeExample
{
    public interface IFrenchSpeaker
    {
        string AskQuestion(string Words);
        string AnswerFortheQuestion(string Words);
    }
}

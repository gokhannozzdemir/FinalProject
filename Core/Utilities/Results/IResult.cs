using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IResult // Initiate for basic void
    {
        bool Success { get; }
        string Message { get; }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T>:DataResult<T>
    {
        //tüm parametreleri kullan
        public ErrorDataResult(T data, string message) : base(data, true, message)
        {

        }

        //yalnızca data verince 
        public ErrorDataResult(T data) : base(data, false)
        {

        }

        //yalnızca message verilince
        public ErrorDataResult(string message) : base(default, true, message)
        {

        }

        //hiçbir şey verilmmezse 
        //default data ya karşılık gelir
        public ErrorDataResult() : base(default, false)
        {

        }
    }
}

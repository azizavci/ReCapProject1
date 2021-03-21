using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        //tüm parametreleri kullan
        public SuccessDataResult(T data, string message) : base(data, true, message)
        {

        }

        //yalnızca data verince 
        public SuccessDataResult(T data) : base(data, true)
        {

        }

        //yalnızca message verilince
        public SuccessDataResult(string message) : base(default, true, message)
        {

        }

        //hiçbir şey verilmmezse 
        //default data ya karşılık gelir
        public SuccessDataResult() : base(default, true)
        {

        }
    }
}

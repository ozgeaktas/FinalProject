using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Temel voidler için başlangıç
    public interface IResult
    {
        bool Success { get; }//yapmaya çalıştığn işlem başarılı true...
        string Message { get; }//işlem başarılıdır yazar mesela...(yönlendirme) 
    }
}

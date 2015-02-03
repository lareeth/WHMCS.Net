using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHMCS.Net.Interfaces
{
    interface IResponse<T> where T : class
    {
        string Result { get; set; }
        int TotalResults { get; set; }
        T Content { get; set; }
    }
}

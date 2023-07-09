using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAndSendingApi.Api
{
    public interface IReadApiUrlFromConfigFile
    {
        string ReadApiUrl (string filePath);
    }
}

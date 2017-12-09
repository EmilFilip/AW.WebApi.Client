using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW.UI.Services
{
    public interface IAcccessWebApi
    {
        Task<IEnumerable<T>> GetAsync<T>(string link);

        Task PostAsync<T>(string link, T model);
    }
}

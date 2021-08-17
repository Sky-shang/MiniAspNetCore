using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MiniAspNetCore
{
    public interface IServer
    {
        Task StartAsync(RequestDelegate handler);
    }
}

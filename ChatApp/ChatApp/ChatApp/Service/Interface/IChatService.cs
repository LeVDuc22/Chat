using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.Service.Interface
{
    public interface IChatService
    {
        Task Connect();
        Task Disconnect();
        Task SendMessage(string userId, string message);
        void ReceiveMessage(Action<string, string> GetMessageAndUser);
    }
}

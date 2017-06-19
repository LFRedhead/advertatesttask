using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvertTestTask1.Services
{
    public interface IMailService
    {
        void SendMail(string to, string from, string subject, string body, int price, bool time);
    }
}

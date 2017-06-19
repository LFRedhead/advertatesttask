using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AdvertTestTask1.Services
{
    public class DebugMailService: IMailService
    {
       public void SendMail(string to, string from, string subject, string body, int price, bool time)
        {
            Debug.WriteLine($"Sending Mail: To { to} From: { from} Subject {subject} with Price {price} and time {time}");
        }
    }
}

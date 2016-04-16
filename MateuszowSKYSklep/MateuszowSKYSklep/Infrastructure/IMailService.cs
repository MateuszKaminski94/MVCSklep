using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MateuszowSKYSklep.Models;

namespace MateuszowSKYSklep.Infrastructure
{
    public interface IMailService
    {
        void SendOrderConfirmationEmail(Order order);
        void SendOrderShippedEmail(Order order);
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_practice.step_7
{
    interface INotificationService
    {
        void Send(string message);
    }

    class EmailService : INotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine("Email sent: " + message);
        }
    }

    class SMSService : INotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine("SMS sent: " + message);
        }
    }

    class WhatsAppService : INotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine("WhatsApp message sent: " + message);
        }
    }

    class Notification
    {
        private INotificationService notificationService;

        public Notification(INotificationService notificationService)
        {
            this.notificationService = notificationService;
        }

        public void SendNotification(string message)
        {
            notificationService.Send(message);
        }
    }

    class SolidD
    {
        public static void Main()
        {
            INotificationService email = new EmailService();
            Notification emailNotification = new Notification(email);
            emailNotification.SendNotification("Welcome through Email");

            INotificationService sms = new SMSService();
            Notification smsNotification = new Notification(sms);
            smsNotification.SendNotification("Welcome through SMS");

            INotificationService whatsapp = new WhatsAppService();
            Notification whatsappNotification = new Notification(whatsapp);
            whatsappNotification.SendNotification("Welcome through WhatsApp");
        }
    }
}

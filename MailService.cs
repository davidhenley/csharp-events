using System;

namespace EventsDelegatesNew
{
    public static class MessageService
    {
        public static void SendEmail(object sender, VideoEventArgs e)
        {
            Console.WriteLine("EmailService: Sending Email for {0}", e.Video.Title);
        }

        public static void SendSMS(object sender, VideoEventArgs e)
        {
            Console.WriteLine("SMS Service: Sending SMS for {0}", e.Video.Title);
        }
    }
}

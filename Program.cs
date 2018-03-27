namespace EventsDelegatesNew
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var videoEncoder = new VideoEncoder();

            videoEncoder.VideoEncoded += MessageService.SendEmail;
            videoEncoder.VideoEncoded += MessageService.SendSMS;

            videoEncoder.Encode(new Video() { Title = "My Video" });

            System.Console.WriteLine("Done.");
        }
    }
}

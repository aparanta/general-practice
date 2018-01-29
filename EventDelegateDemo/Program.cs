using System;

namespace EventDelegateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var video = new Video{Title ="Video 1"};
            VideoEncoder videoEncoder = new VideoEncoder();//publisher
            MailService mailService = new MailService(); //subscriber
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.Encode(video);
        }
    }

    public class MailService
    {
        public void OnVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("Mail Sent");
        }
    }
}

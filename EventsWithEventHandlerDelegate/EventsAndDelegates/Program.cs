using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder();
            videoEncoder.VideoEncoded += MailService.SendMail;
            videoEncoder.VideoEncoded += TextMessageService.SendTextMessage;
            videoEncoder.Encode(video);
            Console.ReadKey();
        }
    }

    class MailService
    {
        public static void SendMail(object source, VideoEventArgs args)
        {
            Console.WriteLine("Mail Sent... "+ args.Video.Title);
        }
    }

    class TextMessageService
    {
        public static void SendTextMessage(object source, VideoEventArgs e)
        {
            Console.WriteLine("Text message sent " + e.Video.Title);
        }
    }
}

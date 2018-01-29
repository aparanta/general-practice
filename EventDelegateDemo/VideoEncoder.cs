using System;
using System.Threading;

namespace EventDelegateDemo
{
    class VideoEncoder
    {
        //1.Define a delegate
        public delegate void VideoEncoderHandler (object source,EventArgs args);
       //2. Define event based on delegate
       public event VideoEncoderHandler VideoEncoded;
          public void Encode(Video video)
        {
            Console.WriteLine("Start Encode..");
            Thread.Sleep(3000);

            OnVideoEncoded();
        }
//the publisher method 
        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoded != null)
            VideoEncoded(this,new EventArgs());
        }
    }
}
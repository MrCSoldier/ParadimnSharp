using System.Globalization;
using System;
using System.Threading.Tasks;

namespace JavaScript
{
    public static class Window
    {
        public static void sleep(int msec) {
            Task.Delay(msec).Wait();
        }
    
        private static bool isWorking;
        public static void setTimeout(Action function, int msec)
        {
            /// Wait for msecs millis and then perform a
            Window.sleep(msec);
            function();
        }
        public static int setInterval(Action function, int msec)
        {
            int id = 0;
            if (!isWorking)
            {
                isWorking = true;
                Task.Run(() =>
                {
                    while (isWorking)
                    {
                        function();
                        Window.sleep(msec);
                    }
                });
            }
            return id;
        }
        public static void clearInterval(int id)
        {
            isWorking = false;
        }
    }
}

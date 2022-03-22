using JavaScript;
using static JavaScript.console;
using static JavaScript.Window;

namespace Program
{
    public class Animation
    {
        
        //make a function 'animate' that in one line will create an animation using the string array 'loadingFrames'
        public static void animate()
        {
            int intervalID;
            string[] loadingFrames = { "|", "/", "-", "\\" };
            intervalID = setInterval(() =>
            {   
                for (int i = 0; i < loadingFrames.Length; i++) {
                    console.log(loadingFrames[i]);
                }
            }, 100);
            setTimeout(() =>
            {
                clearInterval(intervalID);
            }, 2000);
        }
    } 
}
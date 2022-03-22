using Newtonsoft.Json;

namespace JavaScript
{
    public static class console
    {
        public static void log(string text)
        {
            System.Console.WriteLine($"{text}");
        }
        public static void warn(string text)
        {
            System.Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine($"{text}");
            System.Console.ForegroundColor = ConsoleColor.White;
        }
        public static void error(string text)
        {
            System.Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine($"{text}");
            System.Console.ForegroundColor = ConsoleColor.White;
        }
        public static string read() 
        {
            return System.Console.ReadLine();
        }
        public static void input()
        {
            System.Console.ReadKey();
        }
    }
    public static class json
    {
        public static T read<T>(string fileName)
        {
            string json = System.IO.File.ReadAllText(fileName);
            if(json == "")
            {
                console.error("[json.read] File is empty");
                return default(T);
            }
            else {
                return JsonConvert.DeserializeObject<T>(json);
            }
        }
        public static void write<T>(T obj, string fileName)
        {
            string json = JsonConvert.SerializeObject(obj);
            if(json == "")
            {
                console.error("[json.read] File is empty");
                return;
            }
            else {
                System.IO.File.WriteAllText(fileName, json);
            }
        }
    }
}

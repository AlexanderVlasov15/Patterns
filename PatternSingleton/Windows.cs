using System;

namespace PatternSingleton
{
    public class Windows
    {
        private delegate void WindowsHandler(string message);
        private static event WindowsHandler Notify;
        private static Key _key = null;
        private Windows() { }
        static Windows() 
        {
            Notify = DisplayMessage;
        }

        public static Key NewKey(string value)
        {
            if (_key == null)
                _key = new Key(value);
            else
                Notify?.Invoke("You already have a key");

            return _key;
        }
        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}

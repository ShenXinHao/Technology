using System;

namespace Common
{
    public class Singleton<T> where T : Singleton<T>
    {
        public static T Instance => Activator.CreateInstance<T>();
    }
}
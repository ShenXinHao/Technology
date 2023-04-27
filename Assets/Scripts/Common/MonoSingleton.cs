#region Date

// Create by Shenxinhao
// 2022年09月01日 星期四 20:46

#endregion

using UnityEngine;

namespace Common
{
    public class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
    {
        private static T _instance;

        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    var singletonObject = new GameObject();
                    _instance = singletonObject.AddComponent<T>();
#if UNITY_EDITOR
                    singletonObject.name = typeof(T).Name + " (Singleton)";
                    Debug.Log(typeof(T).Name + " (Singleton) is Already!");
#endif
                    DontDestroyOnLoad(singletonObject);
                }


                return _instance;
            }
        }

        public virtual void Init()
        {
        }
    }
}
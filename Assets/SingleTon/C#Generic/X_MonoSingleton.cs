using System;

public class X_MonoSingleton<T> where T : class
{
    private static T instance = null;
    public static T Instance
    {
        get
        {
            if(instance == null)
            {
                instance = Activator.CreateInstance(typeof(T)) as T;
            }
            return instance;
        }
    }

    //다른 스크립트에서 사용하는것
   // ItemManager.instance.Use();
}



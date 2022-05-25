using UnityEngine;

public class MonoSingletonGeneric<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance = null;
    public static T Instance
    {
        get
        {
            instance = FindObjectOfType(typeof(T)) as T;

            if (instance == null)
            {
                instance = new GameObject(typeof(T).ToString(), typeof(T)).AddComponent<T>();
            }
            return instance;
        }
    }

    // ����Ҷ��� �̷���
    // SkillManager.Insatnce.Use();
}

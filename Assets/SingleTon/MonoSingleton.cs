using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 해당 오브젝트가 하이어라키에 있어야 함. 
/// </summary>
public class MonoSingleton : MonoBehaviour
{
    private MonoSingleton() { }
    private static MonoSingleton instance = null;
    public static MonoSingleton GetInstance()
    {
        if (instance == null)
        {
            Debug.Log("해당 오브젝트가 없다.");
        }

        return instance;
    }
    public void Awake()
    {
        instance = this;
    }

    public void Use()
    {
        Debug.Log("모노를 사용한 싱글턴");
    }


}

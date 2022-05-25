using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommonSingleton : MonoBehaviour
{
    private CommonSingleton() { }
    private static CommonSingleton instance = null;
    public static CommonSingleton GetInstance()
    {
        if (instance == null)
        {
            instance = new CommonSingleton();
        }

        return instance;
    }

    public void Use()
    {
        Debug.Log("¿œπ›¿˚ ΩÃ±€≈Ê");
    }


}

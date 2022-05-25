using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 함수사용하지 않아서 일반적 싱글톤보다 참조가 편하다.
/// </summary>
public class PropertySingleton : MonoBehaviour
{
    private PropertySingleton() { }
    private static PropertySingleton instance = null;
    public static PropertySingleton Instance
    {
        get
        {
            if(instance == null)
                instance = new PropertySingleton();
            return instance;
        }
        private set
        {
            instance = value;
        }
    }
    public void Use()
    {
        Debug.Log("프로퍼티를 사용한 싱글톤");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �ش� ������Ʈ�� ���̾��Ű�� �־�� ��. 
/// </summary>
public class MonoSingleton : MonoBehaviour
{
    private MonoSingleton() { }
    private static MonoSingleton instance = null;
    public static MonoSingleton GetInstance()
    {
        if (instance == null)
        {
            Debug.Log("�ش� ������Ʈ�� ����.");
        }

        return instance;
    }
    public void Awake()
    {
        instance = this;
    }

    public void Use()
    {
        Debug.Log("��븦 ����� �̱���");
    }


}

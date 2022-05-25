using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �Լ�������� �ʾƼ� �Ϲ��� �̱��溸�� ������ ���ϴ�.
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
        Debug.Log("������Ƽ�� ����� �̱���");
    }
}

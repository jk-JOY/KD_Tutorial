using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int input = 11; 
    int num = 10;
    bool result;

    private void Start()
    {
        if(input == num)
        {
            Debug.Log("����.");
        }
        else if (input == num)
        {
            Debug.Log("input ũ��.");
        }
        else if (input == num)
        {
            Debug.Log("num ũ��.");
        }
        else
        {
            print("�� ���� ���");
        }
    }

}

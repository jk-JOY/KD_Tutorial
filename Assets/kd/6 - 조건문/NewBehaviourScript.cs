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
            Debug.Log("같다.");
        }
        else if (input == num)
        {
            Debug.Log("input 크다.");
        }
        else if (input == num)
        {
            Debug.Log("num 크다.");
        }
        else
        {
            print("그 밖의 경우");
        }
    }

}

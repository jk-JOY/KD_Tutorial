using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ������ ����ü = Array
/// 0��° ���� �ε����� �ο��ȴ�.
/// array �迭�� ���� �߰� �Ұ�.
/// 
/// </summary>
public class array : MonoBehaviour
{
    // 1���� �迭
    //int[] expp = { 100, 200, 300, 400, 500, 600 };

    //int[] array1 = new int[10]; //�迭�� ũ�⸸ �������ִ� ���.

    //int[] array2; //�迭�� ũ�⸦ ���߿� ������ �� �� �ִ�.

    //private void Start()
    //{
    //    array2 = new int[expp.Length]; // array2�� expp��ŭ�� ũ�⸸ŭ �������־���.

    //    expp[5] = 1000;
    //    expp[6] = 1;

    //    for (int i = 0; i < expp.Length; i++)
    //    {
    //        print(expp[i]);
    //    }      
    //}

    //2�����迭
    int[,] array2 = { { 1, 2, 3, 4, 5 }, { 10, 20, 30, 40, 50 } };


    //3�����迭

    //int[,,] array3 = { {{ 1, 2, 3, 4, 5 }}, { { 10, 20, 30, 40, 50 } }, { { 1, 2, 3, 4, 5 }, { 10, 20, 30, 40, 50 } } };
    
    private void Start()
    {
        print(array2[1, 2]);   //2��°�� 30.

        print(array2[0, 1]);

        //pruin

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 변수의 집합체 = Array
/// 0번째 부터 인덱스가 부여된다.
/// array 배열의 갯수 추가 불가.
/// 
/// </summary>
public class array : MonoBehaviour
{
    // 1차원 배열
    //int[] expp = { 100, 200, 300, 400, 500, 600 };

    //int[] array1 = new int[10]; //배열의 크기만 지정해주는 방법.

    //int[] array2; //배열의 크기를 나중에 정해줄 수 도 있다.

    //private void Start()
    //{
    //    array2 = new int[expp.Length]; // array2도 expp만큼의 크기만큼 한정해주었다.

    //    expp[5] = 1000;
    //    expp[6] = 1;

    //    for (int i = 0; i < expp.Length; i++)
    //    {
    //        print(expp[i]);
    //    }      
    //}

    //2차원배열
    int[,] array2 = { { 1, 2, 3, 4, 5 }, { 10, 20, 30, 40, 50 } };


    //3차원배열

    //int[,,] array3 = { {{ 1, 2, 3, 4, 5 }}, { { 10, 20, 30, 40, 50 } }, { { 1, 2, 3, 4, 5 }, { 10, 20, 30, 40, 50 } } };
    
    private void Start()
    {
        print(array2[1, 2]);   //2번째의 30.

        print(array2[0, 1]);

        //pruin

    }

}

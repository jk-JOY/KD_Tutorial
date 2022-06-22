using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Record
{
    public int[] temp = new int[5];


// this는 해당 클래스 Indexer클래스를 가리키는 예약어다. 
    public int this[int index]
    {
        get {  
            if(index >= temp.Length)
            {
                Debug.Log("인덱스가 더 큽니다");
                return 0;
            }
            else
            {
                return temp[index];
            }
        }
        //인덱스가 5로 들어오면 배열의 크기도 5이기떄문, 그래서 디버그가 뜬다.
        //만약 인덱스를 record[3]으로 바꿨다면 else에 만족하기 때문에 값이 제대로 들어갈것이다.
        set { if (index >= temp.Length) Debug.Log("index의 값이 더 큽니다."); else temp[index] = value; }  //프로퍼티의 예약어 value. 
    }
}
public class Indexer : MonoBehaviour
{
     Record record = new Record();

    private void Start()
    {
        record[3] = 5;
        record[5] = 5;


        print(record[3]);
        print(record[5]);
    }


}

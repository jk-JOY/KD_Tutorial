using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Record
{
    public int[] temp = new int[5];


// this�� �ش� Ŭ���� IndexerŬ������ ����Ű�� ������. 
    public int this[int index]
    {
        get {  
            if(index >= temp.Length)
            {
                Debug.Log("�ε����� �� Ů�ϴ�");
                return 0;
            }
            else
            {
                return temp[index];
            }
        }
        //�ε����� 5�� ������ �迭�� ũ�⵵ 5�̱⋚��, �׷��� ����װ� ���.
        //���� �ε����� record[3]���� �ٲ�ٸ� else�� �����ϱ� ������ ���� ����� �����̴�.
        set { if (index >= temp.Length) Debug.Log("index�� ���� �� Ů�ϴ�."); else temp[index] = value; }  //������Ƽ�� ����� value. 
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

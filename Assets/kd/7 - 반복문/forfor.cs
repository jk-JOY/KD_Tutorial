using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forfor : MonoBehaviour
{
    string text = "�����ٶ󸶹ٻ�";

    private void Start()
    {
        //for  �ݺ�Ƚ���� ��Ȯ�Ҷ� ���
        //while  �ݺ�Ƚ���� ��Ȯ���� ������
     

        //��Ʈ��Ÿ���� text�� ������ �ɰ��� a��� ������ ���� ����. �װ��� ���´� char �ϱ� �ϳ��� �ɰ��� �Ű���?
        foreach (char a in text)  // �ؽ�Ʈ �ȿ� �ִ°� �ϳ��� �ɰ�����.
        {
            print(a);
        }





        //do
        //{
        //    num++;
        //    print(num);
        //}
        //while (num > 10);
    

        
        ////while (num < 10)
        //{
        //    num++;
        //    print(num);
        //}


        //for(; ; )
        //{
        //    num++;
        //    if (num % 2 == 0)
        //    {
        //        continue;//�ش� ȸ���� ������.  
        //    }
        //}


        //for (; ;)
        //{ 
        //    if(num >= 10)
        //    {
        //        break;  // /b ù��° �ݺ��� Ż��, b/    ����ġ�� Ż��. 
        //    }
        //print(num);
        //num += 2;
        //}
    }
}

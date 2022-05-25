using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forfor : MonoBehaviour
{
    string text = "가나다라마바사";

    private void Start()
    {
        //for  반복횟수가 명확할때 사용
        //while  반복횟수가 명확하지 않을때
     

        //스트링타입의 text에 변수를 쪼개서 a라는 변수에 담을 꺼야. 그것의 형태는 char 니까 하나씩 쪼개는 거겠찌?
        foreach (char a in text)  // 텍스트 안에 있는걸 하나씩 쪼갤꺼야.
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
        //        continue;//해당 회차를 끝낸다.  
        //    }
        //}


        //for (; ;)
        //{ 
        //    if(num >= 10)
        //    {
        //        break;  // /b 첫번째 반복문 탈출, b/    스위치문 탈출. 
        //    }
        //print(num);
        //num += 2;
        //}
    }
}

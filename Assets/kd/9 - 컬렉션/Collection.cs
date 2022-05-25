using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 마음대로 숫자를 늘릴 수 있는  고무줄이다!
/// 리스트, 큐 , 스택 , 해시테이블 , 딕셔너리 , 어레이리스트
/// 
/// arrayList는 class이기떄문에 Collection사용
/// </summary>
public class Collection : MonoBehaviour
{//arrayList는 어떤type도 넣을 수 있으므로 박스를 많이 준비해야한다. 연산량 多
    ArrayList arrayList = new ArrayList();

    //특정한 자료형 대로만 데이터를 넣어야 한다 ex int 형만
    List<int> list = new List<int>();

    //특정 값을 얻기 위해서는 열쇠가 필요하다
    Hashtable hashtable = new Hashtable();

    //해쉬테이블과 똑같은데, 자료형을 명시해주는것! (arraylist와 list의 유사함과 비슷)
    Dictionary<string, int> dictionary = new Dictionary<string, int>();


    //ArrayList , Hashtable은 박스가 크다. type이 정해진 상태가 아니다.연산에서 불리하다.
    //List와 Dictionary는 타입을 명시한대로 사용해야하기때문에 결과적으로 연산에서 유리하다.

    //큐 , 선입선출 FIFO
    //first in first out
    //큐는 언큐 - 넣는다
    //큐 디큐 - 뺀다.
    //0개가 아니라면, 즉 하나라도 있으면 출력하도록
    //조건문에 걸렸기떄문에 쓸대 주의해서 
    //갯수가 있는지 없는지 확인하고 디큐를 해줘야한다.

    Queue<int> queue = new Queue<int>();

    //stack 후입선출 LIFO   Last in Last out.  넣는다 push 뺀다 pop! 
    //인생은 쿠키상자와 같다.

    Stack<int> stack = new Stack<int>(); 


    //큐와 스택은 자료형을 명시해줄 수도 있고 안해줘도 된다. 
    //그러나 명시해주는 방향으로 가는게 맞는것 같다, 서로에게 대화가 잘 통해야하니까!
    
    private void Start()
    {
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        print(stack.Pop());
        print(stack.Pop());
        if(stack.Count != 0) //하나라도 있을 경우에만 출력!
        print(stack.Pop());
    }


    //큐 - 포션제작 대기줄
    //가장먼저 클릭한 포션(가장먼저 제작),    가장 마지막에 클릭된 포션(가장 마지막 제작), 은행대기줄

    //스택 요리게임, 설거지 게임
    // 기존에 쌓여져 있던 그릇들을 치우는데 가장 위에부터 치우는것을 스택
}

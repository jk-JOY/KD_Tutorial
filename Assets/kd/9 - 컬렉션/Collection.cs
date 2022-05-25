using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ������� ���ڸ� �ø� �� �ִ�  �����̴�!
/// ����Ʈ, ť , ���� , �ؽ����̺� , ��ųʸ� , ��̸���Ʈ
/// 
/// arrayList�� class�̱⋚���� Collection���
/// </summary>
public class Collection : MonoBehaviour
{//arrayList�� �type�� ���� �� �����Ƿ� �ڽ��� ���� �غ��ؾ��Ѵ�. ���귮 ��
    ArrayList arrayList = new ArrayList();

    //Ư���� �ڷ��� ��θ� �����͸� �־�� �Ѵ� ex int ����
    List<int> list = new List<int>();

    //Ư�� ���� ��� ���ؼ��� ���谡 �ʿ��ϴ�
    Hashtable hashtable = new Hashtable();

    //�ؽ����̺�� �Ȱ�����, �ڷ����� ������ִ°�! (arraylist�� list�� �����԰� ���)
    Dictionary<string, int> dictionary = new Dictionary<string, int>();


    //ArrayList , Hashtable�� �ڽ��� ũ��. type�� ������ ���°� �ƴϴ�.���꿡�� �Ҹ��ϴ�.
    //List�� Dictionary�� Ÿ���� ����Ѵ�� ����ؾ��ϱ⶧���� ��������� ���꿡�� �����ϴ�.

    //ť , ���Լ��� FIFO
    //first in first out
    //ť�� ��ť - �ִ´�
    //ť ��ť - ����.
    //0���� �ƴ϶��, �� �ϳ��� ������ ����ϵ���
    //���ǹ��� �ɷȱ⋚���� ���� �����ؼ� 
    //������ �ִ��� ������ Ȯ���ϰ� ��ť�� ������Ѵ�.

    Queue<int> queue = new Queue<int>();

    //stack ���Լ��� LIFO   Last in Last out.  �ִ´� push ���� pop! 
    //�λ��� ��Ű���ڿ� ����.

    Stack<int> stack = new Stack<int>(); 


    //ť�� ������ �ڷ����� ������� ���� �ְ� �����൵ �ȴ�. 
    //�׷��� ������ִ� �������� ���°� �´°� ����, ���ο��� ��ȭ�� �� ���ؾ��ϴϱ�!
    
    private void Start()
    {
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        print(stack.Pop());
        print(stack.Pop());
        if(stack.Count != 0) //�ϳ��� ���� ��쿡�� ���!
        print(stack.Pop());
    }


    //ť - �������� �����
    //������� Ŭ���� ����(������� ����),    ���� �������� Ŭ���� ����(���� ������ ����), ��������

    //���� �丮����, ������ ����
    // ������ �׿��� �ִ� �׸����� ġ��µ� ���� �������� ġ��°��� ����
}

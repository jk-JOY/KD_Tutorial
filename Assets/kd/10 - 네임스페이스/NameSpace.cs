using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using jk.Studio; // �̸� ����� �°��� ������ ���ڴ�.;
using jk;
//� Ŭ������ ����ϴ��Ŀ� ���� �ش� nameSpace�� �����ָ� �ȴ�.

//������ ���ӽ����̽� 
namespace jk
{ 
    public class Youtube
    {
        public int subscribe;
    }
 
    namespace Studio
    {
        public class Youtube
        {
            int like;
            public void SetLike(int value)
            {
                like = value;
            }

            //1�̶� ������ ture�� ��ȯ�Ǵ� �����. 
            public bool IsLike()
            {
                return like != 0;
            }
        }
    }
}
public class NameSpace : MonoBehaviour
{
    jk.Youtube jinki = new jk.Youtube();

    //�� �����Ұ��� �ƹ��͵� ������?
    //���������� �ʾұ⶧����
    private void Start()
    {
        jinki.subscribe = 10;
        print(jinki.subscribe);
    }
}

//������ ���ӽ����̽��� ��������� ,�� �ȿ��ִ� Ŭ������ ����, �޼ҵ带 ����� ���� �����ϵ���. 
//��ȣ�� ���� - �Ϻη� Ŭ������ Youtube��� �����µ� �װ��� NameSpace�� ����ϴ� �ñ����� �����̴�.���ϱ�??
//nameSpace�� ����Ѵٴ°��� ����, ����������Ʈ, �ܺ� ���̺귯��. 
//�̸��� �ߺ��ɶ�_ ������ �����ϱ� ���� ���� NameSpace�� ����� ���� �����ؼ� �������ִ� ����̴�.

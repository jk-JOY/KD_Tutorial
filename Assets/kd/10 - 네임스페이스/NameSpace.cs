using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using jk.Studio; // 미리 만들어 온것을 가져다 쓰겠다.;
using jk;
//어떤 클래스를 사용하느냐에 따라서 해당 nameSpace를 지워주면 된다.

//간단한 네임스페이스 
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

            //1이라도 있으면 ture가 반환되는 관계식. 
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

    //왜 참조할것이 아무것도 없을까?
    //선언해주지 않았기때문에
    private void Start()
    {
        jinki.subscribe = 10;
        print(jinki.subscribe);
    }
}

//간단한 네임스페이스를 직접만들고 ,그 안에있는 클래스와 변수, 메소드를 사용해 제어 가능하도록. 
//모호한 참조 - 일부러 클래스를 Youtube라고 지었는데 그것이 NameSpace를 사용하는 궁극적인 목적이다.왜일까??
//nameSpace를 사용한다는것은 협업, 대형프로젝트, 외부 라이브러리. 
//이름이 중복될때_ 문제를 방지하기 위해 각각 NameSpace를 만들고 직접 선언해서 관리해주는 방법이다.

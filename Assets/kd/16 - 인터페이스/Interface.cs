using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class A : MonoBehaviour
{
    //미완성인 상태  그렇다면 클래스에도 abstract 적어줘야한다.
    abstract public void ABC();
}
interface ITest2 : ITest
{

}
interface ITest
{
    void Bbc();
    //함수,프로퍼티, 인덱서, 이벤트 

    int SalartP { get; set; }
}

public class Interface : A, ITest
{
    public int SalartP
    {
        get
        { 
          throw new System.NotImplementedException();
        }
        set
        {
            throw new System.NotImplementedException();
        }
    }

    public override void ABC()
    {
        throw new System.NotImplementedException();
    }

    public void Bbc()
    {
        print
    }
}

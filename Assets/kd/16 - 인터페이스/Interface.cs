using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class A : MonoBehaviour
{
    //�̿ϼ��� ����  �׷��ٸ� Ŭ�������� abstract ��������Ѵ�.
    abstract public void ABC();
}
interface ITest2 : ITest
{

}
interface ITest
{
    void Bbc();
    //�Լ�,������Ƽ, �ε���, �̺�Ʈ 

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

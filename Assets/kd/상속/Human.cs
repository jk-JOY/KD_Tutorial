using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Human : MonoBehaviour
{
   protected string humanName;
   protected int humanAge;
   
    protected virtual void Info()
    {
        print("���� �ΰ��Դϴ�.");
    }

    abstract protected void Name();
}

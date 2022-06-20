using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Human : MonoBehaviour
{
   protected string humanName;
   protected int humanAge;
   
    protected virtual void Info()
    {
        print("나는 인간입니다.");
    }

    abstract protected void Name();
}

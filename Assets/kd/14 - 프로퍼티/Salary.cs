using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salary : MonoBehaviour
{
    private int salary;

    private int bonus = 10; 

    public int SalayP
    {
        get
        {
            return salary ;
        }
        set
        { //value�� ���� 0���� ������
            if(value<0) 
            {
                salary = 10;
            }
            else
            {
                salary = value;
            }
        }
    }

    public int Bones { get; set; }

    private void Start()
    {
        salary = -9;
        print(SalayP);
    }
}

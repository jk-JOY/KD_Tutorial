using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Student : Human
{
    string schoolName;

    private void Start()
    {
        schoolName = "���� ����б�";
        humanName = "����";
        humanAge = 10;

        Info();
    }

    protected override void Info()
    {
        base.Info();
        print("���� �л��Դϴ�.");
    }

    protected override void Name()
    {
        print(humanName);
    }
}

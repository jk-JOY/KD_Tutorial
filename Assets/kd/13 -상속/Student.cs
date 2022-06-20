using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Student : Human
{
    string schoolName;

    private void Start()
    {
        schoolName = "진기 고등학교";
        humanName = "진기";
        humanAge = 10;

        Info();
    }

    protected override void Info()
    {
        base.Info();
        print("나는 학생입니다.");
    }

    protected override void Name()
    {
        print(humanName);
    }
}

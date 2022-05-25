using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillManager : MonoSingletonGeneric<SkillManager>
{
        public void Use()
    {
        Debug.Log("모노 제너릭을 사용한 싱글톤");
    }


}

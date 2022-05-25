using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 어떤 것을 열거한다 == enum
/// 
/// 넣고 싶은 값을 우리가 골라서 사용할 수 있다.
/// </summary>
public enum Item
{
    Weapon,
    Shield,
    Potion,
}

public class StructedTest : MonoBehaviour
{
    Item item;
    private void Start()
    {
        item = Item.Weapon;
        item = Item.Shield;

        print(item);
    }

}

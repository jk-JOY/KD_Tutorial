using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// � ���� �����Ѵ� == enum
/// 
/// �ְ� ���� ���� �츮�� ��� ����� �� �ִ�.
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

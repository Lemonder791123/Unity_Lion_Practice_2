using UnityEngine;
using UnityEngine.UI;
using System;

public class Slime : MonoBehaviour
{
    public int hp; //= 250;
    public int atk = 10;
    public int heal = 50;
    public Text system;
    public Bat bat;

    public void Atk()
    {
        bat.Hurt();
        //return; //bat.hp;
    }

    public int Hurt()
    {
        int HP = hp - bat.atk;
        hp = HP;
        system.text = "史萊姆 - 受到傷害：" + bat.atk + "\n" + "史萊姆 - 血量剩下：" + hp;
        return hp;
    }

    public void Heal()
    {
        int HP = (hp + heal);
        hp = HP;
        system.text = "史萊姆 - 受到治癒：" + heal + "\n" + "史萊姆 - 血量剩下：" + hp;
        return;
    }
}
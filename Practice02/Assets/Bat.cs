using UnityEngine;
using UnityEngine.UI;
using System;

public class Bat : MonoBehaviour
{
    public int hp; //= 250;
    public int atk = 50;
    public int heal = 10;
    public Text system;
    public Slime slime;

    public void Atk()
    {
        slime.Hurt();
        //return; //slime.hp;
    }

    public int Hurt()
    {
        int HP = hp - slime.atk;
        hp = HP;
        system.text = "蝙蝠 - 受到傷害：" + slime.atk + "\n" + "蝙蝠 - 血量剩下：" + hp;
        return hp;
    }

    public void Heal()
    {
        int HP = (hp + heal);
        hp = HP;
        system.text = "蝙蝠 - 受到治癒：" + heal + "\n" + "蝙蝠 - 血量剩下：" + hp;
        return;
    }
}
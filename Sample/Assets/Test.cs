using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player
{
    private int hp = 100;
    private int power = 20;

    public void Attack()
    {
        Debug.Log(this.power + "데미지를 입혔다!!!");
    }

    public void Damage(int damage)
    {
        this.hp -= damage;
        Debug.Log(damage + "데미지를 입었다!!!");
    }
}

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 캐릭터의 첫 위치라고 생각
        Player myPlayer = new Player();
        myPlayer.Attack();
        myPlayer.Damage(30);
    }

    // Update is called once per frame
    void Update()
    {
        // 캐릭터가 start이후에 계속 움직이는 것을 표시
    }
}

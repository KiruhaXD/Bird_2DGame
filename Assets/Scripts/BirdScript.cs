using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody; // создаем переменную чтобы у нашей птички была физика
    public float flapStrength; // тут мы создаем переменную для того чтобы определить в Unity как высоко мы будем прыгать(при выборе нужной цифры),  
    public LogicScript logic;
    public bool birdIsAlive = true;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
            myRigidbody.velocity = Vector3.up * flapStrength; // тут мы делаем, чтобы наша птичка при
                                                              // нажатии на пробел, прыгала вверх
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}

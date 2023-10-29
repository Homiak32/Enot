using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPS : MonoBehaviour
{
    public int  health = 10;
    public int level = 2;
    public float speed = 1.2f;
    // Start is called before the first frame update
    void Start()
    {
        health += level;
        //Команда прибовляет уровень кубика к его здоровью.
        print("Уровень здоровья кубика:" + health);
        //Команда выводит в консоль здоровье кубика.
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}

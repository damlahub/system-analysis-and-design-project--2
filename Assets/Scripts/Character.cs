using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Character : MonoBehaviour
{
    float horizontal, vertical;
    Rigidbody2D rg;
    public int characterspeed=5;

    int numbers=0;
    public Text NumbersText;

    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        CharacterMove();
        NumbersText.text = "Sayýlar : "+numbers;

    }

    void CharacterMove()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        rg.AddForce(new Vector2(horizontal * characterspeed, vertical * characterspeed));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Number")
        {
            numbers++;
            Destroy(collision.gameObject);
        }
        if(collision.gameObject.tag=="Finish")
        {
            if(numbers==5)
            SceneManager.LoadScene(4);
        }
    }
}

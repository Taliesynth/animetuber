using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    public Sprite idle;
    public Sprite input1;
    public Sprite input2;
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = input1;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = input2;
        }
        else
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = idle;
        }
    }
}

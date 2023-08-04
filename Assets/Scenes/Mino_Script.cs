using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mino_Script : MonoBehaviour
{
    private Rigidbody rigid;
    public int JumpPower;

    
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(Vector3.forward*1.0f*Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(Vector3.back * 1.0f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(Vector3.left * 1.0f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(Vector3.right * 1.0f * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigid.AddForce(Vector3.up*JumpPower, ForceMode.Impulse);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class studyScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            //0.0~0.5 ���� ���� ����
            float rnd = Random.Range(0.0f, 0.5f);//(�ּڰ�, �ִ�)
            //ĸ�� ��ġ ����
            this.transform.position = new Vector3(0.0f, 0.0f, rnd);//���� ���� �� z���� ����
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            float rnd = Random.Range(0.0f, 360.0f);
            //x�� �������� ȸ������ ���Ƿ� ����
            this.transform.rotation = Quaternion.Euler(rnd, 0.0f, 0.0f);//BŰ�� ������ X�� �������� ������ ������ŭ ȸ��
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            float rnd = Random.Range(0.5f, 2.0f);
            //ũ�⸦ ���Ƿ� ����
            this.transform.localScale = new Vector3(rnd, rnd, rnd);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(new Vector3(0.0f, 0.0f, 3.0f*Time.deltaTime));//Translate�� �ڽ��� ���� �������� �̵�. �� ���� ��ҿ��� �̵��� �Ÿ��� ����
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(Vector3.back * 2.0f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(Vector3.left * 2.0f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(Vector3.right * 2.0f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            this.transform.Translate(Vector3.up * 2.0f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            this.transform.Translate(Vector3.down * 2.0f * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.R))
        {
            this.transform.Rotate(90.0f*Time.deltaTime, 0.0f, 0.0f);
        }

        if (Input.GetKey(KeyCode.L))
        {
            this.transform.Rotate(-90.0f * Time.deltaTime, 0.0f, 0.0f);
        }

        if (Input.GetKey(KeyCode.P))
        {
            GameObject go = GameObject.Find("Cube") as GameObject;
            go.transform.parent = this.transform;//ť���� �θ� ĸ���� ����
        }

        if (Input.GetKey(KeyCode.N))
        {
            GameObject go = GameObject.Find("Cube") as GameObject;
            go.transform.parent = null;//�θ���� ����
        }

    }
}

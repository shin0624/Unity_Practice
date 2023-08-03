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
            //0.0~0.5 사이 난수 생성
            float rnd = Random.Range(0.0f, 0.5f);//(최솟값, 최댓값)
            //캡슐 위치 변경
            this.transform.position = new Vector3(0.0f, 0.0f, rnd);//난수 생성 후 z값에 대입
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            float rnd = Random.Range(0.0f, 360.0f);
            //x축 기준으로 회전값을 임의로 변경
            this.transform.rotation = Quaternion.Euler(rnd, 0.0f, 0.0f);//B키를 누르면 X축 기준으로 임의의 각도만큼 회전
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            float rnd = Random.Range(0.5f, 2.0f);
            //크기를 임의로 변경
            this.transform.localScale = new Vector3(rnd, rnd, rnd);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(new Vector3(0.0f, 0.0f, 3.0f*Time.deltaTime));//Translate는 자신이 향한 방향으로 이동. 즉 현재 장소에서 이동할 거리를 지정
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
            go.transform.parent = this.transform;//큐브의 부모를 캡슐로 설정
        }

        if (Input.GetKey(KeyCode.N))
        {
            GameObject go = GameObject.Find("Cube") as GameObject;
            go.transform.parent = null;//부모관계 해제
        }

    }
}

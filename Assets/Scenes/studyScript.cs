using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class studyScript : MonoBehaviour
{

    private Rigidbody rigid;
    public int JumpPower;
    private bool IsJumping;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        IsJumping = false;
    }


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
            this.transform.Translate(new Vector3(0.0f, 0.0f, 3.0f * Time.deltaTime));//Translate는 자신이 향한 방향으로 이동. 즉 현재 장소에서 이동할 거리를 지정
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
            if (!IsJumping)
            {

                IsJumping = true;
                rigid.AddForce(Vector3.up * JumpPower, ForceMode.Impulse);
            }
            //공중에 떠있는 상태이면 점프하지 못하도록 리턴
            else
            {
                return;
            }
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            this.transform.Translate(Vector3.down * 2.0f * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.R))
        {
            this.transform.Rotate(90.0f * Time.deltaTime, 0.0f, 0.0f);
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

        if (Input.GetKey(KeyCode.G))
        {
            GameObject go = GameObject.Find("Cube") as GameObject;
            go.GetComponent<cubeScript>().bigsize();//G키를 누르면 큐브스크립트의 빅사이즈 메서드 시작
        }

    }

}
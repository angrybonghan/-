using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Build;
using UnityEngine;

public class Base : MonoBehaviour
{
    public int gold = 0;            //정수형
    public float Hp = 100.0f;           //실수형(소수점,끝에 F 필수)
    public string playerName = "홍길동";       // 문자형(문자의 집합)
    public bool isAlive = true;         //논리형 (참/거짓)
    // Start is called before the first frame update
    void Start()
    {
        // ==두 값이 같을떄 true
        // != 두 값이 다르면 true
        // > 왼쪽 값이 더 크면 true
        // < 오른쪽 값이 더 크면 true
        // <=,>= 크거나 같으면 true

        Debug.Log("게임시작");

        if (gold < 50)
        //괄호 안의 조건이 참 이면
        {
            Debug.Log("아이템 을 구매할수 있습니다.");
        }
        else if (gold == 40) //if 안에 조건이 참이 아닐 때 이 조건이 참이라면
        {

            Debug.Log("골드가 40원 보유 중 입니다. 10 골드만 더 모으면 살 수 있어요!");

        }
       // else //if 안의 조건이 참이 아닐때
       // {

          //  Debug.Log("골드가 부족합니다");
       // }
    }
    private void Update()
    {
        
        Debug.Log("게임중");
        if(Input.GetKeyDown(KeyCode.Space))   //스페이스를 눌렀을 때 true
        {
            gold = gold = 10;                       //gold에 10을 추가한다
            Debug.Log("현재 골드 :" + gold);        //유니티 콘솔에 현재 gold값을 띄워준다
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Build;
using UnityEngine;

public class Base : MonoBehaviour
{
    public int gold = 0;            //������
    public float Hp = 100.0f;           //�Ǽ���(�Ҽ���,���� F �ʼ�)
    public string playerName = "ȫ�浿";       // ������(������ ����)
    public bool isAlive = true;         //���� (��/����)
    // Start is called before the first frame update
    void Start()
    {
        // ==�� ���� ������ true
        // != �� ���� �ٸ��� true
        // > ���� ���� �� ũ�� true
        // < ������ ���� �� ũ�� true
        // <=,>= ũ�ų� ������ true

        Debug.Log("���ӽ���");

        if (gold < 50)
        //��ȣ ���� ������ �� �̸�
        {
            Debug.Log("������ �� �����Ҽ� �ֽ��ϴ�.");
        }
        else if (gold == 40) //if �ȿ� ������ ���� �ƴ� �� �� ������ ���̶��
        {

            Debug.Log("��尡 40�� ���� �� �Դϴ�. 10 ��常 �� ������ �� �� �־��!");

        }
       // else //if ���� ������ ���� �ƴҶ�
       // {

          //  Debug.Log("��尡 �����մϴ�");
       // }
    }
    private void Update()
    {
        
        Debug.Log("������");
        if(Input.GetKeyDown(KeyCode.Space))   //�����̽��� ������ �� true
        {
            gold = gold = 10;                       //gold�� 10�� �߰��Ѵ�
            Debug.Log("���� ��� :" + gold);        //����Ƽ �ֿܼ� ���� gold���� ����ش�
        }
    }
}

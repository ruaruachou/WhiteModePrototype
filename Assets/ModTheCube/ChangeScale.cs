using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScale : MonoBehaviour
{
    public Cube cube;

    public float maxChargeTime = 5;//������ʱ��
    public float chargeTime;//��ǰ����ʱ��

    public float currentScale;//��ǰ�ߴ�
    public float maxScale = 5;//���ߴ�
    public float minScale = 1;//��С�ߴ�

    public float rotateSpeed = 10;//��ʼ��ת�ٶ�
    private bool isMouse0Down;//��¼���״̬

    void Start()
    {   //��ȡ���
        cube = GetComponent<Cube>();

    }

    void Update()
    {
        cube.transform.localScale = Vector3.one * currentScale;//���óߴ�
        cube.transform.Rotate(rotateSpeed * Time.deltaTime, 0, 0);//��ת


        if (Input.GetMouseButton(0))
        {
            isMouse0Down = true;//�������Ϊ����״̬
        }
        if (Input.GetMouseButtonUp(0))
        {
            isMouse0Down = false;//���ص�������boolֵ
        }
        if (isMouse0Down)//������ʱ
        {
            chargeTime += Time.deltaTime;//��¼���γ���ʱ��
            currentScale = Mathf.Lerp(maxScale, minScale, chargeTime / maxChargeTime);//�����ߴ�
            rotateSpeed = Mathf.Lerp(rotateSpeed, 0, 0.01f);//��ֹͣ��ת
        }
        if (isMouse0Down == false)//��̧��ʱ
        {

            chargeTime = 0;//����ʱ������
            currentScale = Mathf.Lerp(currentScale, maxScale, 0.2f);//�ߴ緵�����
            rotateSpeed = Mathf.Lerp(rotateSpeed, 200, 0.05f);//�ָ���ʼת��
        }
    }
}

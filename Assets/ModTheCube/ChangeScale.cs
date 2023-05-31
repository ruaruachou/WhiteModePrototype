using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScale : MonoBehaviour
{
    public Cube cube;

    public float maxChargeTime = 5;//最大充能时间
    public float chargeTime;//当前充能时间

    public float currentScale;//当前尺寸
    public float maxScale = 5;//最大尺寸
    public float minScale = 1;//最小尺寸

    public float rotateSpeed = 10;//初始旋转速度
    private bool isMouse0Down;//记录鼠标状态

    void Start()
    {   //获取组件
        cube = GetComponent<Cube>();

    }

    void Update()
    {
        cube.transform.localScale = Vector3.one * currentScale;//设置尺寸
        cube.transform.Rotate(rotateSpeed * Time.deltaTime, 0, 0);//旋转


        if (Input.GetMouseButton(0))
        {
            isMouse0Down = true;//持续检测为按下状态
        }
        if (Input.GetMouseButtonUp(0))
        {
            isMouse0Down = false;//返回弹起鼠标的bool值
        }
        if (isMouse0Down)//当按下时
        {
            chargeTime += Time.deltaTime;//记录本次充能时间
            currentScale = Mathf.Lerp(maxScale, minScale, chargeTime / maxChargeTime);//收缩尺寸
            rotateSpeed = Mathf.Lerp(rotateSpeed, 0, 0.01f);//逐渐停止旋转
        }
        if (isMouse0Down == false)//当抬起时
        {

            chargeTime = 0;//充能时间清零
            currentScale = Mathf.Lerp(currentScale, maxScale, 0.2f);//尺寸返回最大
            rotateSpeed = Mathf.Lerp(rotateSpeed, 200, 0.05f);//恢复初始转速
        }
    }
}

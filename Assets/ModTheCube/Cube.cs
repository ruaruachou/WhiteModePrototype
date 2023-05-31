using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    //大小：按住鼠标缩小到某个极限，松开则立即变回原来的大小，用lerp函数
    //颜色：逐渐变化
    //旋转：初始速度较慢，按住鼠标不转，松开后从快》慢，用lerp函数
    //增殖：以自身为原点向四周发射方块，抬起鼠标后发射，按住的时间越久，发射的持续时间越长

    //获取颜色属性
    public float colorR;
    public float colorG;
    public float colorB;
    public float colorA;
    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 5f;

        colorR = Random.Range(0, 255);
        colorG = Random.Range(0, 255);
        colorB = Random.Range(0, 255);
        colorA = Random.Range(100, 200);
    }
    
    void Update()
    {


        Material material = Renderer.material;

        //改变颜色
        material.color = new Color(colorR/255, colorG/255, colorB/255, colorA/255);

    }

}

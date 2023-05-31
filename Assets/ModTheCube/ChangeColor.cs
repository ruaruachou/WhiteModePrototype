using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Cube cube;
    //RGBA四个值的变化速度
    public float changeColorSpeedR = 1;
    public float changeColorSpeedG = 1;
    public float changeColorSpeedB = 1;
    public float changeColorSpeedA = 1;
    // Start is called before the first frame update
    void Start()
    {
        cube = GetComponent<Cube>();//获取Cube引用

    }

    // Update is called once per frame
    void Update()
    {
        //随机调整变化速度
        changeColorSpeedR = Random.Range(10, 50);
        changeColorSpeedG = Random.Range(10, 50);
        changeColorSpeedB = Random.Range(10, 50);
        changeColorSpeedA = Random.Range(10, 80);

        //调用改变RGBA值的4个方法，这里可否只用1个方法来实现？
        cube.colorR = ChangeNumR(cube.colorR);
        cube.colorG = ChangeNumG(cube.colorG);
        cube.colorB = ChangeNumB(cube.colorB);
        cube.colorA = ChangeNumA(cube.colorA);
    }
    public float ChangeNumR(float num)
    {
        float result;
        num += changeColorSpeedR * Time.deltaTime;
        result = num%255;
        return result;
    }
    public float ChangeNumG(float num)
    {
        float result;
        num += changeColorSpeedG * Time.deltaTime;
        result = num%255;
        return result;
    }
    public float ChangeNumB(float num)
    {
        float result;
        num += changeColorSpeedB * Time.deltaTime;
        result = num%255;
        return result;
    }
    public float ChangeNumA(float num)
    {
        float result;
        num += changeColorSpeedA * Time.deltaTime;
        result = num%255;
        return result;
    }
}

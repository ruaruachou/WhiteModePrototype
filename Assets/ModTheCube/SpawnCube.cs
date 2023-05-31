using System.Collections;
using UnityEngine;

public class SpawnCube : MonoBehaviour
{
    public GameObject projectileCube;
    public ChangeScale changeScale;
    public Cube originalCube;

    float spawnDurTime = 5;

    private bool isMouse1Down; // 记录鼠标状态

    private void Start()
    {
        changeScale = GetComponent<ChangeScale>(); // 获取引用
        originalCube = GetComponent<Cube>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))//检测右键按下
        {
            Debug.Log("Press Mouse 1");
            isMouse1Down = true; //注意：必须要用一个bool状态进行判断，否则不会调用Spawn
            StartCoroutine(SpawnCubeCoroutine());
        }

        if (Input.GetMouseButtonUp(1))
        {
            Debug.Log("Release Mouse 1");
            isMouse1Down = false;
        }
    }

    private IEnumerator SpawnCubeCoroutine()
    {
        while (isMouse1Down)
        {
            SpawnCubeMethod();
            yield return new WaitForSeconds(0.1f);//每隔0.1秒调用一次
        }
    }

    private void SpawnCubeMethod()//生成Cube
    {
        Instantiate(projectileCube, originalCube.transform.position, originalCube.transform.rotation);
    }
}

using System.Collections;
using UnityEngine;

public class SpawnCube : MonoBehaviour
{
    public GameObject projectileCube;
    public ChangeScale changeScale;
    public Cube originalCube;

    float spawnDurTime = 5;

    private bool isMouse1Down; // ��¼���״̬

    private void Start()
    {
        changeScale = GetComponent<ChangeScale>(); // ��ȡ����
        originalCube = GetComponent<Cube>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))//����Ҽ�����
        {
            Debug.Log("Press Mouse 1");
            isMouse1Down = true; //ע�⣺����Ҫ��һ��bool״̬�����жϣ����򲻻����Spawn
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
            yield return new WaitForSeconds(0.1f);//ÿ��0.1�����һ��
        }
    }

    private void SpawnCubeMethod()//����Cube
    {
        Instantiate(projectileCube, originalCube.transform.position, originalCube.transform.rotation);
    }
}

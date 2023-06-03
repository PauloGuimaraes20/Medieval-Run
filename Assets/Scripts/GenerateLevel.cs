using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] maps;
    private int zPos = 24; //posição do pontoz final em cada mapa (por preencher)
    private bool creatingMap = false;
    private int mapNum;

    void Update()
    {
        if (creatingMap == false)
        {
            creatingMap = true;
            StartCoroutine(CreateMap());
        }
    }

    IEnumerator CreateMap()
    {
        mapNum = Random.Range(0, 2); //2 ou maps.lenght??
        Instantiate(maps[mapNum], new Vector3(0,0,zPos), Quaternion.identity);
        zPos += 24; // ???verificar valor
        yield return new WaitForSeconds(3);
        creatingMap = false;
    }
}

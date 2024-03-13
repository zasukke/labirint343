using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Klin : MonoBehaviour
{
    public GameObject Unit;
    public int Xpos;
    public int Xpos2;
    public int Zpos;
    public int Zpos2;
    void Start()
    {
        GenerateKlin(Unit);
    }

    void GenerateKlin(GameObject cube)
    {
        int i = 0;
        while (i < 10) {
            Instantiate(cube, new Vector3(Xpos, 1, Zpos), Quaternion.identity);
            Instantiate(cube, new Vector3(Xpos2, 1, Zpos2), Quaternion.identity);
            Xpos += 2;
            Zpos += 2;
            Xpos2 -= 2;
            Zpos2 += 2;
            i += 1;
        }
    }
}

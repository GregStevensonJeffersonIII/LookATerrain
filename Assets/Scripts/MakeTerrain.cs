using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeTerrain : MonoBehaviour
{

    void Start()
    {

        Mesh mesh = GetComponent<MeshFilter>().mesh;
        Vector3[] vertices = mesh.vertices;

        for (int v = 0; v < vertices.Length; v++)
        {
            vertices[v].y = Random.Range(0f, 10f); // generates new value for the height of each vertice

        }

        mesh.vertices = vertices;
        mesh.RecalculateBounds(); // we call this to ensure bounding volume is correct (as recommended by APIs)
        mesh.RecalculateNormals(); // again, recommended by APIs

        gameObject.AddComponent<MeshCollider>();
    }
}

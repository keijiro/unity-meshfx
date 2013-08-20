using UnityEngine;
using System.Collections;

public class Skeletonizer : MonoBehaviour
{
    void Awake ()
    {
        var meshFilter = GetComponent<MeshFilter> ();
        var sourceMesh = meshFilter.mesh;
        var newMesh = new Mesh ();

        newMesh.vertices = sourceMesh.vertices;
        newMesh.normals = sourceMesh.normals;

        var sourceTriangles = sourceMesh.triangles;
        var newTriangles = new int[sourceTriangles.Length * 2];

        for (var i = 0; i < sourceTriangles.Length; i += 3) {
            newTriangles [2 * i + 0] = sourceTriangles [i + 0];
            newTriangles [2 * i + 1] = sourceTriangles [i + 1];
            newTriangles [2 * i + 2] = sourceTriangles [i + 1];
            newTriangles [2 * i + 3] = sourceTriangles [i + 2];
            newTriangles [2 * i + 4] = sourceTriangles [i + 2];
            newTriangles [2 * i + 5] = sourceTriangles [i + 0];
        }

        newMesh.SetIndices (newTriangles, MeshTopology.Lines, 0);

        meshFilter.mesh = newMesh;
    }
}

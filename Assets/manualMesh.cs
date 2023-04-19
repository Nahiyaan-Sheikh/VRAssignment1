using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class manualMesh : MonoBehaviour
{
    MeshFilter cubeMesh;
    Mesh mesh;
    // Start is called before the first frame update
    void Start()
    {
        CreateCube();
    }
    
    private void CreateCube()
    {
        Vector3[] vertices = {
            new Vector3 (0, 0, 0),
            new Vector3 (1, 0, 0),
            new Vector3 (1, 1, 0),
            new Vector3 (0, 1, 0),
            new Vector3 (0, 1, 1),
            new Vector3 (1, 1, 1),
            new Vector3 (1, 0, 1),
            new Vector3 (0, 0, 1),
        };

        int[] triangles = {
            0, 2, 1, //face front
			0, 3, 2,
            2, 3, 4, //face top
			2, 4, 5,
            1, 2, 5, //face right
			1, 5, 6,
            0, 7, 4, //face left
			0, 4, 3,
            5, 4, 7, //face back
			5, 7, 6,
            0, 6, 7, //face bottom
			0, 1, 6
        };
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.Optimize();
        mesh.RecalculateNormals();
        Vector2[] uvs = mesh.uv;
        //front
        uvs[0] = new Vector2(0, 0);
        uvs[1] = new Vector2(0.333f, 0);
        uvs[2] = new Vector2(0, 0.333f);
        uvs[3] = new Vector2(0.333f, 0.333f);
        //top
        uvs[4] = new Vector2(0.334f, 0.333f);
        uvs[5] = new Vector2(0.666f, 0.333f);
        uvs[8] = new Vector2(0.334f, 0);
        uvs[9] = new Vector2(0.666f, 0);
        //back
        uvs[6] = new Vector2(1, 0);
        uvs[7] = new Vector2(0.667f, 0);
        uvs[10] = new Vector2(1, 0.333f);
        uvs[11] = new Vector2(0.667f, 0.333f);
        //bottom
        uvs[12] = new Vector2(0, 0.334f);
        uvs[13] = new Vector2(0, 0.666f);
        uvs[14] = new Vector2(0.333f, 0.666f);
        uvs[15] = new Vector2(0.333f, 0.334f);
        //bottom
        uvs[16] = new Vector2(0.334f, 0.334f);
        uvs[17] = new Vector2(0.334f, 0.666f);
        uvs[18] = new Vector2(0.666f, 0.666f);
        uvs[19] = new Vector2(0.666f, 0.334f);
        //left
        uvs[20] = new Vector2(0.667f, 0.334f);
        uvs[21] = new Vector2(0.667f, 0.666f);
        uvs[22] = new Vector2(1, 0.666f);
        uvs[23] = new Vector2(1, 0.334f);
        mesh.uv = uvs;
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}

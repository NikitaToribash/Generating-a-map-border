using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    public Mesh mesh;
    public float width;
    public float height;
    public float subwidth;

    public void Start()
    {
        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
        
        CreateObj(width, height, subwidth);
    }
    public void CreateObj(float w, float h, float sub)
    {

        Vector3[] verts = new Vector3[32];
        Vector2[] uv = new Vector2[32];
        int[] tris = new int[48];

        float topZ = 0 + (h / 2);
        float bottomZ = 0 - (h / 2);
        float rightX = 0 + (w / 2);
        float leftX = 0 - (w / 2);



        verts[0] = new Vector3(leftX, 0, bottomZ); // 1 sqare 
        verts[1] = new Vector3(leftX, 0, bottomZ + sub); 
        verts[2] = new Vector3(leftX + sub, 0, bottomZ);
        verts[3] = new Vector3(leftX + sub, 0, 0 + bottomZ + sub);

        verts[4] = new Vector3(leftX, 0, bottomZ + sub);   // 2 sqare
        verts[5] = new Vector3(leftX, 0, topZ);
        verts[6] = new Vector3(leftX + sub, 0, bottomZ + sub);
        verts[7] = new Vector3(leftX + sub, 0, topZ);

        verts[8] = new Vector3(leftX, 0, topZ); // 3 sqare
        verts[9] = new Vector3(leftX, 0, topZ + sub);
        verts[10] = new Vector3(leftX + sub, 0, topZ);
        verts[11] = new Vector3(leftX + sub, 0, topZ + sub );

        verts[12] = new Vector3(leftX + sub, 0, topZ); // 4 sqare
        verts[13] = new Vector3(leftX + sub, 0, topZ + sub);
        verts[14] = new Vector3(rightX, 0, topZ);
        verts[15] = new Vector3(rightX , 0, topZ + sub);

        verts[16] = new Vector3(rightX, 0, topZ);      // 5sqare
        verts[17] = new Vector3(rightX, 0, topZ + sub);
        verts[18] = new Vector3(rightX + sub, 0, topZ);
        verts[19] = new Vector3(rightX + sub, 0, topZ + sub);

        verts[20] = new Vector3(rightX, 0, bottomZ + sub); // 6 sqare
        verts[21] = new Vector3(rightX, 0, topZ);
        verts[22] = new Vector3(rightX + sub, 0, bottomZ + sub);
        verts[23] = new Vector3(rightX + sub, 0, topZ);

        verts[24] = new Vector3(rightX, 0, bottomZ);         // 7 sqare
        verts[25] = new Vector3(rightX, 0, bottomZ + sub);
        verts[26] = new Vector3(rightX + sub, 0, bottomZ);
        verts[27] = new Vector3(rightX+ sub, 0, bottomZ + sub);

        verts[28] = new Vector3(leftX + sub, 0, bottomZ); // 8 sqare
        verts[29] = new Vector3(leftX + sub, 0, bottomZ + sub);
        verts[30] = new Vector3(rightX, 0, bottomZ);
        verts[31] = new Vector3(rightX, 0, bottomZ + sub); 

      /*  for (int i = 0; i < verts.Length; i++)
        {
            GameObject go = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            go.transform.position = verts[i];
            go.name = i.ToString();
        }*/





        tris[0] = 0; // 1 sqare
        tris[1] = 1;
        tris[2] = 2;
        tris[3] = 1;
        tris[4] = 3;
        tris[5] = 2;

        tris[6] = 4; // 2 sqare
        tris[7] = 5;
        tris[8] = 6;
        tris[9] = 5;
        tris[10] = 7;
        tris[11] = 6;

        tris[12] = 8; // 3 sqare
        tris[13] = 9;
        tris[14] = 10;
        tris[15] = 9;
        tris[16] = 11;  
        tris[17] = 10;

        tris[18] = 12; // 4 sqare
        tris[19] = 13;
        tris[20] = 14;
        tris[21] = 13;
        tris[22] = 15;
        tris[23] = 14;

        tris[24] = 16; // 5 sqare
        tris[25] = 17;
        tris[26] = 18;
        tris[27] = 17;
        tris[28] = 19;
        tris[29] = 18;

        tris[30] = 20; // 6 sqare
        tris[31] = 21;
        tris[32] = 22;
        tris[33] = 21;
        tris[34] = 23;
        tris[35] = 22;

        tris[36] = 24; // 7 sqare
        tris[37] = 25;
        tris[38] = 26;
        tris[39] = 25;
        tris[40] = 27;
        tris[41] = 26;

        tris[42] = 28; // 8 sqare
        tris[43] = 29;
        tris[44] = 30;
        tris[45] = 29;
        tris[46] = 31;
        tris[47] = 30; 

        /* uv[0] = new Vector2(0, 0);
         uv[1] = new Vector2(0, 1);
         uv[2] = new Vector2(1, 0);
         uv[3] = new Vector2(1, 1);*/

        for (int i = 0; i < uv.Length; i++)
        {
            uv[i] = new Vector2(verts[i].x, verts[i].z) * 0.2f;
        }


        mesh.vertices = verts;
        mesh.uv = uv;
        mesh.triangles = tris;


        mesh.RecalculateNormals();
    }
}

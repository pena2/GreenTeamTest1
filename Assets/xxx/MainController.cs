using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{

    public string _World;
    public GameObject _SpawnerPrefab;

    // Map<int,Map<int,GameObject>> _WorldCells;
    Dictionary<int, Dictionary<int, GameObject>> _WorldCells;


    // Start is called before the first frame update
    void Start()
    {
        //_SpawnerPrefab.transform.
        _World = @"
        1,2,1,1,2,2,1,2,1,1
        0,1,0,3,1,1,0,1,0,0,0,1,0,0,1,1,0,1,0,0
        1,2,1,1,2,2,1,2,1,1,1,2,1,1,2,2,1,2,1,1
        0,1,0,3,1,1,3,1,0,0
        1,2,1,1,2,2,1,2,1,1,1,2,1,1,2,2,1,2,1,1
        0,3,0,0,1,3,0,1,0,0,0,1,0,0,1,1,0,1,0,0
        1,2,1,1,2,2,1,2,1,1
        0,1,0,0,1,1,0,1,3,0,1,2,1,1,2,2,1,2,1,1
        1,2,1,1,3,2,1,2,1,1,0,1,0,0,1,1,0,1,0,0
        0,1,0,3,1,1,0,1,0,0
        1,2,1,1,2,2,1,2,1,1,0,1,0,0,1,1,0,1,0,0
        0,1,0,0,1,1,0,3,0,0,0,1,0,0,1,1,0,1,0,0
        1,2,1,1,2,2,1,2,1,1
        0,1,0,0,1,1,0,1,0,0,0,1,0,0,1,1,0,1,0,0,0,1,0,0,1,1,0,1,0,0
        1,2,1,1,2,2,1,2,1,1,1,2,1,1,2,2,1,2,1,1,1,2,1,1,2,2,1,2,1,1
        0,1,0,0,1,1,0,1,0,0
        ";
        _SpawnAll();
    }

    void _SpawnAll()
    {

        var trows = _World.Trim().Split('\n');
        var jj = 0;
        // var ttrow= new Dictionary<int,GameObject>();
        foreach (var trow in trows)
        {
            jj++;
            var ii = 0;
            var tcolumns = trow.Trim().Split(',');
            foreach (var tcolumn in tcolumns)
            {
                var ttcol = new Dictionary<int, GameObject>();
                ii++;
                Debug.Log("" + jj + "," + ii + ": " + tcolumn);
                // _WorldCells.Add

                GameObject tt = Instantiate(_SpawnerPrefab);
                float tx = 0 + (ii * (5f + 0.11f));
                float ty = 0f;
                float tz = 0 + (jj * (5f + 0.11f));
                tt.transform.position = new Vector3(tx, ty, tz);
                tt.GetComponent<Spawner>().SetMyObject(int.Parse(tcolumn));
            }
        }
    }
}

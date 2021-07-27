using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameController : MonoBehaviour
{

    private GameObject _Ball;
    private GameObject _Panel;

    private int x,y,z,_panelCount;

    private void Awake() {
        _Ball = GameObject.FindWithTag("PlayerBall");
        _Panel = GameObject.FindWithTag("EnemyPanel");

        x = 0;
        y = -5;
        z = 0;
        _panelCount = 30;
    }

    // Start is called before the first frame update
    void Start()
    {

        Debug.Log(_Ball);
        Debug.Log(_Panel);
        
        Vector3 vec3 = new Vector3(x, y, z);

        for(int i = 0; i < _panelCount; i++)
        {
            Debug.Log(i);
            Instantiate(_Panel, vec3, Quaternion.identity); 
            vec3.y = vec3.y + -1;
        }
        // Instantiate(_Panel, vec3,Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

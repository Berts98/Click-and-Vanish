using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Timer time;
    public Score value;
    public int scoreadd = 100;
    public List<GameObject> Cubes = new List<GameObject>();
    public int TotalCubesNumber = 0;

    // Use this for initialization
    void Start()
    {
        TotalCubesNumber = Cubes.Count;

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0)) // Se è stato premuto il pulsante sinistro del mouse
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // Fai partire un raggio dalla posizione del mouse
            RaycastHit hit;
            if (Physics.Raycast(ray.origin, ray.direction, out hit)) // Se entra in collisione con un oggetto
            {
                Destroy(hit.collider.gameObject);
                value.scoreValue += scoreadd;
            }
        }
        WinningConditions();
        LosingConditions();
    }



    public void LosingConditions()
    {
        if (value.scoreValue <= 700 && time.currentTime == 0)
        {
            SceneManager.LoadScene(2);
        }
    }


    public void WinningConditions()
    {
        if (value.scoreValue == 700 && time.currentTime > 0)
        {
            SceneManager.LoadScene(3);
        }
    }
}

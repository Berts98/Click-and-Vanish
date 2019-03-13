using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    Timer time;
    Score value;
    public int scoreadd = 100;
    public List<GameObject> Cubes = new List<GameObject>();

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            value.scoreValue += scoreadd;
            Destroy(this.gameObject);
        }
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            value.scoreValue += scoreadd;
            Destroy(this.gameObject);
        }
    }

    public void LosingConditions()
    {
        if (value.scoreValue <=700 && time.currentTime == 0 )
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

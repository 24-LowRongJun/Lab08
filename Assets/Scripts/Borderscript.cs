using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Borderscript : MonoBehaviour
{
    public GameObject scoretxt;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (score == 10)
        {
            SceneManager.LoadScene(2);
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            score++;
            scoretxt.GetComponent<Text>().text = "Score : " + score;

        }
    }
}

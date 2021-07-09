using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    int speed = 1;
    int health = 10;
    int score = 0;
    [SerializeField] Text txtScore, txtHealth;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal"), 0, 0 * speed * Time.deltaTime);
    }

    public void OnCollisionEnter(Collision collision){
        if(collision.collider.gameObject.tag == "Enemy")
            health--;
        if(collision.collider.gameObject.tag == "Cube")
            score++;
        
        txtHealth.text = "Health: " + health;
        txtScore.text = "Score: " + score;
        
        if(health == 0)
            SceneManager.LoadScene("SceneTryAgain");
        if(score >= 10)
            SceneManager.LoadScene("SceneSuccess");
    }
}

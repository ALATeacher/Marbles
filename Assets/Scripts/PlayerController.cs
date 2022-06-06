using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Rigidbody body;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 f = new Vector3();
        f.x = h;
        f.y = 0;
        f.z = v;
        f.Normalize();
        f = f*speed;
        body.AddForce(f);

        if (transform.position.y<-10) {
            gameOver();
        }
    }

    void gameOver() {
        SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
    }
}

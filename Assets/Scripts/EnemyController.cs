using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
    public GameObject target;
    public float speed;
    public Rigidbody body;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 f = new Vector3(
            target.transform.position.x - transform.position.x,
            target.transform.position.y - transform.position.y,
            target.transform.position.z - transform.position.z
        );
        f = Vector3.Normalize(f);
        body.AddForce(f*speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Marble") {
            gameOver();
        }
    }

    void gameOver() {
        SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
    }
}

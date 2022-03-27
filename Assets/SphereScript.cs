using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SphereScript : MonoBehaviour
{
    public static int count;
    public Text score;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        respawn();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -10)
        {
            if (count != 100)
            {
                count++;
                score.text = "" + count;
                respawn();
            }
            else
                Destroy(gameObject);
        }
    }
    void respawn()
    {
        float x = Random.Range(-12, 12);
        float y = Random.Range(5, 15);
        float velocityY = Random.Range(0, 30);
        transform.position = new Vector3(x, y);
        rb.velocity = new Vector3(0, velocityY, 0);
    }
}

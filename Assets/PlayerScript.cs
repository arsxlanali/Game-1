using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    Vector3 pos;
    public int speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        pos.x+= x * Time.deltaTime * speed;
        pos.x = Mathf.Clamp(pos.x, -14, 14);
        transform.position = pos;
    }
    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene(0);
    }
}

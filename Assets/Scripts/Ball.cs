using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public Rigidbody rb;
    public float jumpForce;
    public GameObject splashPrefab;
    private GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>();
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) // Çarpıştığı Anda Tetik
    {
        rb.AddForce(Vector3.up * jumpForce);
        GameObject splash = Instantiate(splashPrefab, transform.position + new Vector3(0, -0.2f, 0), transform.rotation);
        splash.transform.SetParent(other.gameObject.transform);

        string materialName = other.gameObject.GetComponent<MeshRenderer>().material.name; 
        if(materialName == "Safe Color (Instance)")
        {
            // point++
        }

        else if(materialName == "Unsafe Color (Instance)")
        {
            gameManager.RestartGame();
        }

        else if(materialName == "Last Ring (Instance)")
        {
            // level up
        }

    }
}

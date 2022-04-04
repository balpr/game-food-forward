using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
	public float maxSpeed = 40.0f;
	public float turnSpeed = 45.0f;

	public float speed;
	public float forwardInput;

	public GameObject text;

	private float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
    	speed = 0;
    }

    // Update is called once per frame
    void Update()
    {
    	horizontalInput = Input.GetAxis("Horizontal");
    	forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        acceleration();

        if(transform.position.y > -20f && transform.position.y < -10)
        {
        	SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if(transform.position.z > 170f)
        {
        	gameObject.transform.position = new Vector3(0,0, 0);
        }

        if(forwardInput > 0)
        {
        	text.SetActive(false);
        }
    }

    void acceleration()
    {
    	if(forwardInput == 1)
        {
        	if(speed <= maxSpeed)
        	{
        		speed += 0.1f;
        	}

        }
        else if(forwardInput == 0)
        {
        	if(speed > 0)
        	{
        		speed -= 0.1f;
        	}
        	if(speed < 0)
        	{
        		speed += 0.1f;
        	}
        	if(speed == 0)
        	{
        		speed = 0f;
        	}
        }
        else if(forwardInput == -1)
        {
        	if(speed >= -maxSpeed)
        	{
        		speed -= 0.1f;
        	}
        }
    }
}

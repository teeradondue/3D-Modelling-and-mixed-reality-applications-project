using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.SceneManagement;

public class Player_Controller : MonoBehaviour
{

    public float movementSpeed;
    public float jumpForce;
    
    public TextMeshProUGUI countText;
    public int count;
    public TextMeshProUGUI winText;

    private bool isGrounded;


    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        winText.enabled = false;
        SetCountText();
    }

    // Update is called once per frame
    void Update()
    {
        //Movement
        float xMovement = Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed;
        float zMovement = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed;
        transform.Translate(xMovement, 0, 0);
        transform.Translate(0, 0, zMovement);
        //Debug.Log(isGrounded);


        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0, jumpForce, 0));
            //Debug.Log("Jump");
            /*if (isGrounded)
            {
                GetComponent<Rigidbody>().AddForce(new Vector3(0, jumpForce, 0));
            }
            */

        }

    }

    void SetCountText()
    {
        countText.text = "   <sprite=0>x " + count.ToString();
        if (count == 4)
        {
            winText.enabled = true;
        }
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }

        if (other.gameObject.CompareTag("Teleport1"))
        {
            if (count == 1)
            {
                SceneManager.LoadScene(1);
            }
        }

        if (other.gameObject.CompareTag("Teleport2"))
        { 
            if(count == 2)
            {
                SceneManager.LoadScene(2);
            }
        }

        if (other.gameObject.CompareTag("Finish")){
            winText.enabled = true;
        }

        /*if(other.tag == "Ground")
        {
            isGrounded = true;
        }
        */

    }

    private void OnTriggerExit(Collider other)
    {
        /*
        if(other.tag == "Ground"  )
        {
            isGrounded = false;
        }
        */
    }

}

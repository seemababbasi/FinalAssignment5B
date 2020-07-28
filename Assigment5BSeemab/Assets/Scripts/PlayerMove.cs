using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;
using UnityEngine.UI;


public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    public AudioSource alert;
    public AudioSource end;
    int counter;
    public Text gameEndText;
    float speed = 10;
    public GameObject myPrefab;
    string[] randomStringList;
    public TextMesh t1;
    public TextMesh t2;
    public TextMesh t3;
    public TextMesh t4;
    public TextMesh t5;
    public TextMesh t6;
    public TextMesh t7;
    public TextMesh t8;
    public TextMesh t9;
    public TextMesh t10;
    void Start()
    {
       
        counter = 0;
        rb = GetComponent<Rigidbody>();
        randomStringList = stringlist();
        OnCollision();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        float horizental = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 vector3 = new Vector3(horizental, 0.0f, vertical);
        rb.AddForce(vector3 * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (counter < 3)
        {


            if (other.gameObject.CompareTag("Pick Up"))
            {
                
                

                if (Vector3.Distance(other.gameObject.transform.position, t1.transform.position) == 0)
                {
                    if (MatchString(t1.text))
                    {
                        t1.text = "";
                        counter = counter + 1;
                        other.gameObject.SetActive(false);
                        gameEndText.text = "Palindrome Capture" + counter;
                    }
                    else
                    {
                        AlertOn();
                    }

                }
                else if (Vector3.Distance(other.gameObject.transform.position, t2.transform.position) == 0)
                {
                    if (MatchString(t2.text))
                    {
                        t2.text = "";
                        other.gameObject.SetActive(false);
                        counter = counter + 1;
                        gameEndText.text = "Palindrome Capture" + counter;
                    }
                    else
                    {
                        AlertOn();
                    }
                }
                else if (Vector3.Distance(other.gameObject.transform.position, t3.transform.position) == 0)
                {
                    if (MatchString(t3.text))
                    {
                        t3.text = "";
                        other.gameObject.SetActive(false);
                        counter = counter + 1;
                        gameEndText.text = "Palindrome Capture" + counter;
                    }
                    else
                    {
                        AlertOn();
                    }
                }
                else if (Vector3.Distance(other.gameObject.transform.position, t4.transform.position) == 0)
                {
                    if (MatchString(t4.text))
                    {
                        t4.text = "";
                        other.gameObject.SetActive(false);
                        counter = counter + 1;
                        gameEndText.text = "Palindrome Capture" + counter;
                    }
                    else
                    {
                        AlertOn();
                    }
                }
                else if (Vector3.Distance(other.gameObject.transform.position, t5.transform.position) == 0)
                {
                    if (MatchString(t5.text))
                    {
                        t5.text = "";
                        other.gameObject.SetActive(false);
                        counter = counter + 1;
                        gameEndText.text = "Palindrome Capture" + counter;
                    }
                    else
                    {
                        AlertOn();
                    }
                }
                else if (Vector3.Distance(other.gameObject.transform.position, t6.transform.position) == 0)
                {
                    if (MatchString(t6.text))
                    {
                        t6.text = "";
                        other.gameObject.SetActive(false);
                        counter = counter + 1;
                        gameEndText.text = "Palindrome Capture" + counter;
                    }
                    else
                    {
                        AlertOn();
                    }
                }
                else if (Vector3.Distance(other.gameObject.transform.position, t7.transform.position) == 0)
                {
                    if (MatchString(t7.text))
                    {
                        t7.text = "";
                        other.gameObject.SetActive(false);
                        counter = counter + 1;
                        gameEndText.text = "Palindrome Capture" + counter;
                    }
                    else
                    {
                        AlertOn();
                    }
                }
                else if (Vector3.Distance(other.gameObject.transform.position, t8.transform.position) == 0)
                {
                    if (MatchString(t8.text))
                    {
                        t8.text = "";
                        other.gameObject.SetActive(false);
                        counter = counter + 1;
                        gameEndText.text = "Palindrome Capture" + counter;
                    }
                    else
                    {
                        AlertOn();
                    }
                }
                else if (Vector3.Distance(other.gameObject.transform.position, t9.transform.position) == 0)
                {
                    if (MatchString(t9.text))
                    {
                        t9.text = "";
                        other.gameObject.SetActive(false);
                        counter = counter + 1;
                        gameEndText.text = "Palindrome Capture" + counter;
                    }
                    else
                    {
                        AlertOn();
                    }
                }
                else if (Vector3.Distance(other.gameObject.transform.position, t10.transform.position) == 0)
                {
                    if (MatchString(t10.text))
                    {
                        t10.text = "";
                        other.gameObject.SetActive(false);
                        counter = counter + 1;
                        gameEndText.text = "Palindrome Capture" + counter;
                    }
                    else
                    {
                        AlertOn();
                    }
                }
                else
                {

                }

            }
        }
        else
        {
            EndSound();
            gameEndText.text = "You have collected all the Palindrome String Game Over";
        }
        
    }

// This function is used to generate collectable and give string to 3d t
    void OnCollision()
    {  
        Instantiate(myPrefab, new Vector3(7, 0.5f, 3), Quaternion.identity);
        Instantiate(myPrefab, new Vector3(7, 0.5f, 0), Quaternion.identity);
        Instantiate(myPrefab, new Vector3(7, 0.5f, -3), Quaternion.identity);
        Instantiate(myPrefab, new Vector3(3, 0.5f, -3), Quaternion.identity);
        Instantiate(myPrefab, new Vector3(-2, 0.5f, -3), Quaternion.identity);
        Instantiate(myPrefab, new Vector3(-5, 0.5f, -2), Quaternion.identity);
        Instantiate(myPrefab, new Vector3(-8, 0.5f, -3), Quaternion.identity);
        Instantiate(myPrefab, new Vector3(-8, 0.5f, 0), Quaternion.identity);
        Instantiate(myPrefab, new Vector3(-8, 0.5f, 3), Quaternion.identity);
        Instantiate(myPrefab, new Vector3(1, 0.5f, 3), Quaternion.identity);
        t1.text = randomStringList[0];
        t2.text = randomStringList[1];
        t3.text = randomStringList[2];
        t4.text = randomStringList[3];
        t5.text = randomStringList[4];
        t6.text = randomStringList[5];
        t7.text = randomStringList[6];
        t8.text = randomStringList[7];
        t9.text = randomStringList[8];
        t10.text = randomStringList[9];

    }

    // function to Generate a coupon
    public static string GenerateRandomString(int length, System.Random random)
    {
        string characters = "0SX";
        StringBuilder result = new StringBuilder(length);
        for (int i = 0; i < length; i++)
        {
            result.Append(characters[random.Next(characters.Length)]);
        }
        return result.ToString();
    }

    static string[] stringlist()
    {
        System.Random rnd = new System.Random();
        string[] coupon = new string[10];
        for (int i = 0; i < coupon.Length; i++)
        {
            string a = GenerateRandomString(6, rnd);
            if (i < 3)
            {
                int j = a.Length - 1;
                while (j >= 0)
                {
                    a = String.Concat(a, a[j]);
                    j--;
                }
                coupon[i] = a;
            }
            else
            {
                a = String.Concat(a, a);
                coupon[i] = a;
            }
            //coupon[i] = a;
        }
        return coupon;
    }
    // This function is used to check the given string is palindrome or not
    private bool MatchString(string string1)
    {
        int length = string1.Length;
        for (int i = 0; i < length; i++)
        {
            if (string1[i] != string1[length - i - 1])
            {
                return false;
            }
        }
        return true;
    }
    void AlertOn()
    {
        alert.Play();
    }
    void  EndSound()
    {
        end.Play();
    }
}

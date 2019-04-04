using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "User")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Win");
        }
    }
}

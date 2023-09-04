using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTracker : MonoBehaviour
{

    GameManager _gm;

    // Start is called before the first frame update
    void Start()
    {
        _gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        if (_gm != null)
        {
            Debug.Log("GM found");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ball") && _gm != null)
        {
            float _yVelocity = other.GetComponent<Rigidbody>().velocity.y;
            if (_yVelocity < -0.1)
            {
                Debug.Log("Ball Y velocity: " + _yVelocity);
                _gm.Count++;
                _gm.ChangeVisibleCounter();
            }
        }

    }
}

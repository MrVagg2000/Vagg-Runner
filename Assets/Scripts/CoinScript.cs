using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScript : MonoBehaviour
{
    public float amplitude = 0.5f; // Adjust this to control the height of the movement
    public float speed = 1f; // Adjust this to control the speed of the movement
    private Vector3 startPosition;
    private int coinCount = 0;
    public GameObject score;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 1);
        float newY = startPosition.y + Mathf.Sin(Time.time * speed) * amplitude;

        // Update the position of the coin
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        coinCount += 1;
        this.gameObject.SetActive(false);
        score.GetComponent<Text>().text = "Coins: " + coinCount.ToString("0");
    }
}
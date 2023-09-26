using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject CoinPrefeb;

    public float DurationLeft = 60f;

    public float SpawnInterval = 1f;

    public float MinX = -1f;
    public float MaxX = 1f;

    public float CoinsCollected;
    public TMP_Text Text;

    private float randomX;

    private float spawnTimer;



    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = SpawnInterval;
    }



    // Update is called once per frame
    void Update()
    {
        if (spawnTimer > 0)
        {
            spawnTimer -= Time.deltaTime;
        }
        else
        {
            float rand = Random.Range(MinX, MaxX);



            Vector3 randomPos = new Vector3(x: rand, y: 0f, z: 0f);



            if (CoinPrefeb != null)
            {
                GameObject.Instantiate(CoinPrefeb, transform.position + randomPos, transform.rotation);
            }
            Debug.Log("Times up, should spawn coin");
            spawnTimer = SpawnInterval;
        }
    }

    public void AddCoins(float amount)
    {
        CoinsCollected += amount;
        Debug.Log("Coin Collected" + CoinsCollected);

        if(Text != null)
        {
            Text.text = CoinsCollected.ToString();
        }

    }
}

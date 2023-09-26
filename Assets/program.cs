using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class program : MonoBehaviour
{
    public int CoinsAmount = 10;
    //public AudioSource _AudioSource;
    public GameObject CoinCollectedAudio;
    public GameObject CoinCollectedEffect;
    public GameObject Effects;



    public float tempCoinsFloat;
    public Collider2D _Collider2D;

    private spawner _spawner;



    // Start is called before the first frame update
    void Start()
    {
        _Collider2D = GetComponent<Collider2D>();

        _spawner = FindObjectOfType<spawner>();
        //_AudioSource = GetComponent<AudioSource>();
    }



    private void OnMouseOver()
    {
        //Debug.Log("Coins collected" + CoinsAmount);
        //if(_AudioSource != null)
        //   _AudioSource.Play();



        if (CoinCollectedAudio != null)
        {
            GameObject.Instantiate(CoinCollectedAudio, transform.position, Quaternion.identity);
        }

        if (CoinCollectedEffect != null)
        {
            GameObject.Instantiate(CoinCollectedEffect, transform.position, Quaternion.identity);
        }

        if (_spawner != null)
        {
            //spawner will add points to CoinCollected;
            _spawner.AddCoins(CoinsAmount);
        }
        Destroy(this.gameObject);



    }

   

    // Update is called once per frame
    void Update()
    {
        
    }
}

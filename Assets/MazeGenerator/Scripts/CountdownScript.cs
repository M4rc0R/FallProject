using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class CountdownScript : MonoBehaviour
{
    public TextMeshProUGUI displayContagem;
    public float contagem = 30.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(contagem > 0.0f){
            contagem -= Time.deltaTime;
            displayContagem.text = contagem.ToString("F2");
        }else{
            SceneManager.LoadScene("GameOver"); 
        }
    }

    void OnTriggerEnter(Collider collision) {
		if (collision.gameObject.tag.Equals ("Coin")) {
			contagem = contagem + 10.0f;
			}
			Destroy(collision.gameObject);
		}
	
}


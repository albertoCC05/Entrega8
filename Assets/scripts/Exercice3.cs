using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Exercice3 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI sentenceShow;
    private string sentence = "Hello World";
    private string sentenceTotal = "";

    private IEnumerator showSentence()
    {
        foreach (char sent in sentence )
        {

            sentenceTotal = sentenceTotal + sent;
            sentenceShow.text = sentenceTotal;
            
            yield return new WaitForSeconds(0.2f);
        }
                
        
        

        

    }
    private void Start()
    {
        StartCoroutine(showSentence());
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Exercice2 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI songText;

    private IEnumerator song()
    {
       for (int i = 10; i > 0; i--)
        {
            songText.text = $"{i} green bottles\r\nHanging on the wall\r\n{i} green bottles\r\nHanging on the wall\r\nAnd if one green bottle\r\nShould accidentally fall\r\nThere’ll be {i-1} green bottles\r\nHanging on the wall ";
            yield return new WaitForSeconds(2);

        }
        
        

       
    }
    private void Start()
    {
        StartCoroutine(song());
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinVolume : MonoBehaviour
{
    private UIController _uIController;
    [SerializeField] private string _winText = null;
    [SerializeField] private AudioSource _winSound = null;
    private void Awake()
    {
        _uIController =  FindObjectOfType<UIController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.gameObject.SetActive(false);

            if(_uIController != null)
            {
                _uIController.ShowWinText(_winText);
            }

            if (_winSound != null) 
            {
                SoundPlayer.Instance.PlaySFX(_winSound, transform.position);
            }
            
        }
    }
}

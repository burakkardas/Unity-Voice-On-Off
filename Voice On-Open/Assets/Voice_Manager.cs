using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Voice_Manager : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private Button _voiceOnButton, _voiceOffButton;
    [SerializeField] private bool _isMuted;

    void Start()
    {
        _isMuted = PlayerPrefs.GetInt("muted") == 1;
        AudioListener.pause = _isMuted;

        if(_isMuted == false) {
            _voiceOnButton.gameObject.SetActive(true);
            _voiceOffButton.gameObject.SetActive(false);
        }
        else {
            _voiceOnButton.gameObject.SetActive(false);
            _voiceOffButton.gameObject.SetActive(true);
        }
    }

    public void MutePressed() {
        _isMuted = !_isMuted;
        AudioListener.pause = _isMuted;
        PlayerPrefs.SetInt("muted", _isMuted ? 1 : 0);
        
        if(_isMuted == false) {
            _voiceOnButton.gameObject.SetActive(true);
            _voiceOffButton.gameObject.SetActive(false);
        }
        else {
            _voiceOnButton.gameObject.SetActive(false);
            _voiceOffButton.gameObject.SetActive(true);
        }
    }
}

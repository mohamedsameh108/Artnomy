using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;
using Button = UnityEngine.UI.Button;
using UnityEngine.EventSystems;

public class start : MonoBehaviour {
    public Button Button1;
    public AudioSource m_audioSource;
    public VideoPlayer m_videoPlayer;
    public void Awake () {
        Button1.onClick.AddListener (() => buttonCallBack (Button1));
        m_audioSource = GetComponent<AudioSource> ();
        m_videoPlayer = GetComponent<VideoPlayer> ();
    }
    public void buttonCallBack (Button buttonPressed) {
        if (buttonPressed == Button1) {
            m_audioSource.PlayOneShot (m_audioSource.clip);
            m_audioSource.Play ();
            m_videoPlayer.source = VideoSource.VideoClip;
            m_videoPlayer.Play ();
            Invoke ("Video", m_audioSource.clip.length);
        }
    }
    public void Video () {
        SceneManager.LoadScene (1);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class game : MonoBehaviour {
    // Start is called before the first frame update
    public AudioSource m_audioSource;
    public AudioClip[] List;
    public GameObject sprt;
    public GameObject sea_pic;
    public GameObject Infography_pic;
    public GameObject PIA07219_hires_pic;
    public GameObject Dr_Y_Tony_Song_pic;
    public GameObject PIA02723_hires_pic;
    public GameObject chile_gis_2015259_lrg_pic;
    public GameObject monthly_map_image_pic;
    public GameObject Initiation_pic;
    public GameObject Split_pic;
    public GameObject Amplification_pic;
    public Animation anim;
    public Sprite[] images;
    public Image imagePerfab;
    public VideoPlayer m_videoPlayer;
    public GameObject joystick;
    public GameObject joystick1;
    void Start () {
        StartCoroutine (conter ());
        anim = GetComponent<Animation> ();
        m_audioSource = GetComponent<AudioSource> ();
        sea_pic.SetActive (false);
        Infography_pic.SetActive (false);
        PIA07219_hires_pic.SetActive (false);
        Dr_Y_Tony_Song_pic.SetActive (false);
        PIA02723_hires_pic.SetActive (false);
        chile_gis_2015259_lrg_pic.SetActive (false);
        monthly_map_image_pic.SetActive (false);
        Initiation_pic.SetActive (false);
        Split_pic.SetActive (false);
        Amplification_pic.SetActive (false);
        sprt.SetActive (false);
        m_videoPlayer = GetComponent<VideoPlayer> ();
    }

    // Update is called once per frame
    IEnumerator conter () {
        anim.Play ("Ins Idle");
        yield return new WaitForSeconds (2);
        sprt.SetActive (true);
        StartCoroutine (anime ());
        for (int i = 0; i <= 27; i++) {
            if (i == 0) {
                sea_pic.SetActive (true);
                Infography_pic.SetActive (false);
                PIA07219_hires_pic.SetActive (false);
                Dr_Y_Tony_Song_pic.SetActive (false);
                PIA02723_hires_pic.SetActive (false);
                chile_gis_2015259_lrg_pic.SetActive (false);
                monthly_map_image_pic.SetActive (false);
                Initiation_pic.SetActive (false);
                Split_pic.SetActive (false);
                Amplification_pic.SetActive (false);
            } else if (i == 3) {
                sea_pic.SetActive (false);
                Infography_pic.SetActive (true);
                PIA07219_hires_pic.SetActive (false);
                Dr_Y_Tony_Song_pic.SetActive (false);
                PIA02723_hires_pic.SetActive (false);
                chile_gis_2015259_lrg_pic.SetActive (false);
                monthly_map_image_pic.SetActive (false);
                Initiation_pic.SetActive (false);
                Split_pic.SetActive (false);
                Amplification_pic.SetActive (false);
            } else if (i == 5) {
                sea_pic.SetActive (false);
                Infography_pic.SetActive (false);
                PIA07219_hires_pic.SetActive (true);
                Dr_Y_Tony_Song_pic.SetActive (false);
                PIA02723_hires_pic.SetActive (false);
                chile_gis_2015259_lrg_pic.SetActive (false);
                monthly_map_image_pic.SetActive (false);
                Initiation_pic.SetActive (false);
                Split_pic.SetActive (false);
                Amplification_pic.SetActive (false);
            } else if (i == 7) {
                sea_pic.SetActive (false);
                Infography_pic.SetActive (false);
                PIA07219_hires_pic.SetActive (false);
                Dr_Y_Tony_Song_pic.SetActive (true);
                PIA02723_hires_pic.SetActive (false);
                chile_gis_2015259_lrg_pic.SetActive (false);
                monthly_map_image_pic.SetActive (false);
                Initiation_pic.SetActive (false);
                Split_pic.SetActive (false);
                Amplification_pic.SetActive (false);
            } else if (i == 9) {
                sea_pic.SetActive (false);
                Infography_pic.SetActive (false);
                PIA07219_hires_pic.SetActive (false);
                Dr_Y_Tony_Song_pic.SetActive (false);
                PIA02723_hires_pic.SetActive (true);
                chile_gis_2015259_lrg_pic.SetActive (true);
                monthly_map_image_pic.SetActive (false);
                Initiation_pic.SetActive (false);
                Split_pic.SetActive (false);
                Amplification_pic.SetActive (false);
            } else if (i == 11) {
                sea_pic.SetActive (false);
                Infography_pic.SetActive (false);
                PIA07219_hires_pic.SetActive (false);
                Dr_Y_Tony_Song_pic.SetActive (false);
                PIA02723_hires_pic.SetActive (false);
                chile_gis_2015259_lrg_pic.SetActive (false);
                monthly_map_image_pic.SetActive (true);
                Initiation_pic.SetActive (false);
                Split_pic.SetActive (false);
                Amplification_pic.SetActive (false);
            } else if (i == 14) {
                sea_pic.SetActive (false);
                Infography_pic.SetActive (false);
                PIA07219_hires_pic.SetActive (false);
                Dr_Y_Tony_Song_pic.SetActive (false);
                PIA02723_hires_pic.SetActive (false);
                chile_gis_2015259_lrg_pic.SetActive (false);
                monthly_map_image_pic.SetActive (false);
                Initiation_pic.SetActive (true);
                Split_pic.SetActive (true);
                Amplification_pic.SetActive (true);
            } else if (i >= 17) {
                sea_pic.SetActive (false);
                Infography_pic.SetActive (false);
                PIA07219_hires_pic.SetActive (false);
                Dr_Y_Tony_Song_pic.SetActive (false);
                PIA02723_hires_pic.SetActive (false);
                chile_gis_2015259_lrg_pic.SetActive (false);
                monthly_map_image_pic.SetActive (false);
                Initiation_pic.SetActive (false);
                Split_pic.SetActive (false);
                Amplification_pic.SetActive (false);
            } else if (i > 25) {
                sprt.SetActive (false);
            }
            m_audioSource.clip = List[i];
            m_audioSource.PlayOneShot (m_audioSource.clip);
            m_audioSource.Play ();
            imagePerfab.sprite = images[i];
            yield return new WaitForSeconds (m_audioSource.clip.length);
            yield return new WaitForSeconds (1);
            if (i == 27) {
                sprt.SetActive (false);
                m_videoPlayer.source = VideoSource.VideoClip;
                joystick1.SetActive (false);
                joystick.SetActive (false);
                m_videoPlayer.Play ();
                yield return new WaitForSeconds (324);
                Video ();
            }
        }
    }
    IEnumerator anime () {
        for (int i = 0; i < 20; i++) {
            anim.Play ("talk");
            yield return new WaitForSeconds (4);
            anim.Play ("walk");
            yield return new WaitForSeconds (17);
        }
        anim.Play ("Ins Idle");
    }
    public void Video () {
        SceneManager.LoadScene (0);
    }
}
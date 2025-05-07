using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    private const string m_VolumeKey = "MasterVolume";
    private const string b_VolumeKey = "BGMVolume";
    private const string s_VolumeKey = "SFXVolume";

    public static AudioManager Instance { get; private set; }

    [SerializeField] private AudioClip[] bgClips;
    [SerializeField] private AudioMixer mixer;
    private AudioSource audioSource;

    public float m_value {  get; private set; }
    public float b_value { get; private set; }
    public float s_value { get; private set; }

    private void Awake()
    {
        if(Instance == null)
            Instance = this;

        audioSource = GetComponent<AudioSource>();
        audioSource.clip = bgClips[(int)SceneName.Lobby];
        audioSource.outputAudioMixerGroup = mixer.FindMatchingGroups("BGM")[0];
        audioSource.Play();
    }

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        LoadVolume();
        ChangeMasterVolume(m_value);
        ChangeBGMVolume(b_value);
        ChangeSFXVolume(s_value);
    }

    public void ChangeBGM(SceneName sceneName)
    {
        audioSource.Stop();
        audioSource.clip = bgClips[(int)sceneName];
        audioSource.Play();
    }

    public void SaveVolume()
    {
        PlayerPrefs.SetFloat(m_VolumeKey, m_value);
        PlayerPrefs.SetFloat(b_VolumeKey, b_value);
        PlayerPrefs.SetFloat(s_VolumeKey, s_value);
    }

    public void LoadVolume()
    {
        m_value = PlayerPrefs.GetFloat(m_VolumeKey, 1);
        b_value = PlayerPrefs.GetFloat(b_VolumeKey, 1);
        s_value = PlayerPrefs.GetFloat(s_VolumeKey, 1);
    }

    public void ChangeMasterVolume(float value)
    {
        mixer.SetFloat("MasterVolume", Mathf.Log10(value) * 20);
        m_value = value;
    }

    public void ChangeBGMVolume(float value)
    {
        mixer.SetFloat("BGMVolume", Mathf.Log10(value) * 20);
        b_value = value;
    }

    public void ChangeSFXVolume(float value)
    {
        mixer.SetFloat("SFXVolume", Mathf.Log10(value) * 20);
        s_value = value;
    }
}

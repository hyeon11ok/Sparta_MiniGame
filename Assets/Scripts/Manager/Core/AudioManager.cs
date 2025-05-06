using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; private set; }

    [SerializeField] private AudioClip[] bgClips;
    [SerializeField] private AudioMixer mixer;
    private AudioSource audioSource;

    private void Awake()
    {
        if(Instance == null)
            Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Init()
    {
        // TODO : ����� ����� ���� �ҷ�����
    }

    public void ChangeBGM(SceneName sceneName)
    {
        // ���� ���� �´� ����������� ��ü
    }

    public void ChangeMasterVolume(float value)
    {
        // TODO : ������ ���� ����
    }

    public void ChangeBGMVolume(float value)
    {
        // TODO : ��� ���� ����
    }

    public void ChangeSFXVolume(float value)
    {
        // TODO : ȿ�� ���� ����
    }

    public float GetMasterVolume()
    {
        // TODO : ������ ���� ��ȯ
        return 0;
    }

    public float GetBGMVolume()
    {
        // TODO : ��� ���� ��ȯ
        return 0;
    }

    public float GetSFXVolume()
    {
        // TODO : ȿ�� ���� ��ȯ
        return 0;
    }
}

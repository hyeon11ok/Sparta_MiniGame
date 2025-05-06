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
        // TODO : 저장된 오디오 정보 불러오기
    }

    public void ChangeBGM(SceneName sceneName)
    {
        // 현재 씬에 맞는 배경음악으로 교체
    }

    public void ChangeMasterVolume(float value)
    {
        // TODO : 마스터 음량 변경
    }

    public void ChangeBGMVolume(float value)
    {
        // TODO : 배경 음량 변경
    }

    public void ChangeSFXVolume(float value)
    {
        // TODO : 효과 음량 변경
    }

    public float GetMasterVolume()
    {
        // TODO : 마스터 음량 반환
        return 0;
    }

    public float GetBGMVolume()
    {
        // TODO : 배경 음량 반환
        return 0;
    }

    public float GetSFXVolume()
    {
        // TODO : 효과 음량 반환
        return 0;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class KanaPronunciation : MonoBehaviour
{
    public Camera Cam;
    public AudioSource AudioSource;
    public string LayerName;
    public string kana;

    [Header("a")]
    public AudioClip A;
    public AudioClip I;
    public AudioClip U;
    public AudioClip E;
    public AudioClip O;

    [Header("Ka")]
    public AudioClip Ka;
    public AudioClip Ki;
    public AudioClip Ku;
    public AudioClip Ke;
    public AudioClip Ko;

    [Header("Sa")]
    public AudioClip Sa;
    public AudioClip Shi;
    public AudioClip Su;
    public AudioClip Se;
    public AudioClip So;

    [Header("Ta")]
    public AudioClip Ta;
    public AudioClip Chi;
    public AudioClip Tsu;
    public AudioClip Te;
    public AudioClip To;

    [Header("Na")]
    public AudioClip Na;
    public AudioClip Ni;
    public AudioClip Nu;
    public AudioClip Ne;
    public AudioClip No;

    [Header("Ha")]
    public AudioClip Ha;
    public AudioClip Hi;
    public AudioClip Fu;
    public AudioClip He;
    public AudioClip Ho;

    [Header("Ma")]
    public AudioClip Ma;
    public AudioClip Mi;
    public AudioClip Mu;
    public AudioClip Me;
    public AudioClip Mo;

    [Header("Ya")]
    public AudioClip Ya;
    public AudioClip Yu;
    public AudioClip Yo;

    [Header("Ra")]
    public AudioClip Ra;
    public AudioClip Ri;
    public AudioClip Ru;
    public AudioClip Re;
    public AudioClip Ro;

    [Header("Wa")]
    public AudioClip Wa;
    public AudioClip Wo;

    [Header("N")]
    public AudioClip N;

    // Start is called before the first frame update
    void Start()
    {
        //_camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        //#if !UNITY_EDITOR
        ///鼠标按下时发出检测射线
        if (Input.GetMouseButton(0))
        {
            var mouseWorldPos = Cam.ScreenToWorldPoint(Input.mousePosition);
            var layerMask = LayerMask.NameToLayer(LayerName);
            var hit2d = Physics2D.Raycast(mouseWorldPos, Vector2.zero, 0, layerMask);
            if (hit2d.collider == null)
            {
                return;
            }

            var hitObjectName = hit2d.collider.name;
            switch (hitObjectName)
            {
                default:
                    break;
                ///占位的，防止漏填
                case "":
                    break;
                ///a
                case "a":
                    Play(A);
                    break;
                case "i":
                    Play(I);
                    break;
                case "u":
                    Play(U);
                    break;
                case "e":
                    Play(E);
                    break;
                case "o":
                    Play(O);
                    break;
                ///ka
                case "ka":
                    Play(Ka);
                    break;
                case "ki":
                    Play(Ki);
                    break;
                case "ku":
                    Play(Ku);
                    break;
                case "Ke":
                    Play(Ke);
                    break;
                case "ko":
                    Play(Ko);
                    break;
                ///sa
                case "sa":
                    Play(Sa);
                    break;
                case "shi":
                case "si":
                    Play(Shi);
                    break;
                case "su":
                    Play(Su);
                    break;
                case "se":
                    Play(Se);
                    break;
                case "so":
                    Play(So);
                    break;
                ///ta
                case "ta":
                    Play(Ta);
                    break;
                case "chi/ti":
                case "ti/chi":
                case "chi":
                case "ti":
                    Play(Chi);
                    break;
                case "tsu/tu":
                case "tu/tsu":
                case "tsu":
                case "tu":
                    Play(Tsu);
                    break;
                case "te":
                    Play(Te);
                    break;
                case "to":
                    Play(To);
                    break;
                ///na
                case "na":
                    Play(Na);
                    break;
                case "ni":
                    Play(Ni);
                    break;
                case "nu":
                    Play(Nu);
                    break;
                case "ne":
                    Play(Ne);
                    break;
                case "no":
                    Play(No);
                    break;
                ///ha
                case "ha":
                    Play(Ha);
                    break;
                case "hi":
                    Play(Hi);
                    break;
                case "fu/hu":
                case "hu/fu":
                case "fu":
                case "hu":
                    Play(Fu);
                    break;
                case "he":
                    Play(He);
                    break;
                case "ho":
                    Play(Ho);
                    break;
                ///ma
                case "ma":
                    Play(Ma);
                    break;
                case "mi":
                    Play(Mi);
                    break;
                case "mu":
                    Play(Mu);
                    break;
                case "me":
                    Play(Me);
                    break;
                case "mo":
                    Play(Mo);
                    break;
                ///ya
                case "ya":
                    Play(Ya);
                    break;
                case "yu":
                    Play(Yu);
                    break;
                case "yo":
                    Play(Yo);
                    break;
                ///ra
                case "ra":
                    Play(Ra);
                    break;
                case "ri":
                    Play(Ri);
                    break;
                case "ru":
                    Play(Ru);
                    break;
                case "re":
                    Play(Re);
                    break;
                case "ro":
                    Play(Ro);
                    break;
                ///wa
                case "wa":
                    Play(Wa);
                    break;
                case "wo":
                case "(w)o":
                    Play(Wo);
                    break;
                ///n
                case "n":
                    Play(N);
                    break;
            }
        }
    }

    void Play(AudioClip audioClip)
    {
        /*
        ///如果声音仍在播放中，则不播放声音
        if (AudioSource.isPlaying)
        {
            Debug.Log($"播放中：{AudioSource.clip.name}");
            return;
        }
        */
        ///如果未处于播放状态，则播放声音
        AudioSource.clip = audioClip;
        Debug.Log($"播放：{AudioSource.clip.name}");
        AudioSource.Play();
    }

    public void Play(string kana)
    {
        this.kana = kana;
        switch (kana)
        {
            case "":
            default:
                break;
            ///a
            case "a":
                Play(A);
                break;
            case "i":
                Play(I);
                break;
            case "u":
                Play(U);
                break;
            case "e":
                Play(E);
                break;
            case "o":
                Play(O);
                break;
            ///ka
            case "ka":
                Play(Ka);
                break;
            case "ki":
                Play(Ki);
                break;
            case "ku":
                Play(Ku);
                break;
            case "ke":
                Play(Ke);
                break;
            case "ko":
                Play(Ko);
                break;
            ///sa
            case "sa":
                Play(Sa);
                break;
            case "shi":
            case "si":
                Play(Shi);
                break;
            case "su":
                Play(Su);
                break;
            case "se":
                Play(Se);
                break;
            case "so":
                Play(So);
                break;
            ///ta
            case "ta":
                Play(Ta);
                break;
            case "chi":
            case "ti":
                Play(Chi);
                break;
            case "tsu":
            case "tu":
                Play(Tsu);
                break;
            case "te":
                Play(Te);
                break;
            case "to":
                Play(To);
                break;
            ///na
            case "na":
                Play(Na);
                break;
            case "ni":
                Play(Ni);
                break;
            case "nu":
                Play(Nu);
                break;
            case "ne":
                Play(Ne);
                break;
            case "no":
                Play(No);
                break;
            ///ha
            case "ha":
                Play(Ha);
                break;
            case "hi":
                Play(Hi);
                break;
            case "fu":
            case "hu":
                Play(Fu);
                break;
            case "he":
                Play(He);
                break;
            case "ho":
                Play(Ho);
                break;
            ///ma
            case "ma":
                Play(Ma);
                break;
            case "mi":
                Play(Mi);
                break;
            case "mu":
                Play(Mu);
                break;
            case "me":
                Play(Me);
                break;
            case "mo":
                Play(Mo);
                break;
            ///ya
            case "ya":
                Play(Ya);
                break;
            case "yu":
                Play(Yu);
                break;
            case "yo":
                Play(Yo);
                break;
            ///ra
            case "ra":
                Play(Ra);
                break;
            case "ri":
                Play(Ri);
                break;
            case "ru":
                Play(Ru);
                break;
            case "re":
                Play(Re);
                break;
            case "ro":
                Play(Ro);
                break;
            ///wa
            case "wa":
                Play(Wa);
                break;
            case "wo":
                Play(Wo);
                break;
            ///n
            case "n":
                Play(N);
                break;
        }
    }

    public void Play(Text textComp)
    {
        Debug.Log($"try play {textComp.text}");
        Play(textComp.text);
    }

    public void Play()
    {
        Play(kana);
    }
}



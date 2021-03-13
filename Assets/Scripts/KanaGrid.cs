using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KanaGrid : MonoBehaviour
{
    /// <summary>
    /// 主摄像机
    /// </summary>
    public Camera _camera;
    public AudioSource _audioSource;
    public CinemachineBrain _brain;

    public enum EKanaType
    {
        Hiragana,
        Katakana,
    }
    [Header("假名显示类型")]
    public EKanaType KanaType;

    [Tooltip("当前假名")]
    public string CurrentKana;

    [Header("段标题")]
    public GameObject ADanHeader;
    public GameObject IDanHeader;
    public GameObject UDanHeader;
    public GameObject EDanHeader;
    public GameObject ODanHeader;

    [Header("行标题")]
    public GameObject AGyouHeader;
    public GameObject KaGyouHeader;
    public GameObject SaGyouHeader;
    public GameObject TaGyouHeader;
    public GameObject NaGyouHeader;
    public GameObject HaGyouHeader;
    public GameObject MaGyouHeader;
    public GameObject YaGyouHeader;
    public GameObject RaGyouHeader;
    public GameObject WaGyouHeader;
    public GameObject NGyouHeader;

    [Header("a行")]
    public GameObject A;
    public GameObject I;
    public GameObject U;
    public GameObject E;
    public GameObject O;

    [Header("ka行")]
    public GameObject Ka;
    public GameObject Ki;
    public GameObject Ku;
    public GameObject Ke;
    public GameObject Ko;

    [Header("sa行")]
    public GameObject Sa;
    public GameObject Shi;
    public GameObject Su;
    public GameObject Se;
    public GameObject So;

    [Header("ta行")]
    public GameObject Ta;
    public GameObject Chi;
    public GameObject Tsu;
    public GameObject Te;
    public GameObject To;

    [Header("na行")]
    public GameObject Na;
    public GameObject Ni;
    public GameObject Nu;
    public GameObject Ne;
    public GameObject No;

    [Header("ha行")]
    public GameObject Ha;
    public GameObject Hi;
    public GameObject Fu;
    public GameObject He;
    public GameObject Ho;

    [Header("ma行")]
    public GameObject Ma;
    public GameObject Mi;
    public GameObject Mu;
    public GameObject Me;
    public GameObject Mo;

    [Header("ya行")]
    public GameObject Ya;
    public GameObject Yu;
    public GameObject Yo;

    [Header("ra行")]
    public GameObject Ra;
    public GameObject Ri;
    public GameObject Ru;
    public GameObject Re;
    public GameObject Ro;

    [Header("wa行")]
    public GameObject Wa;
    public GameObject Wo;

    [Header("拨音")]
    public GameObject N;

    // Start is called before the first frame update
    void Start()
    {
        _camera = Camera.main;
        _audioSource = _camera.GetComponent<AudioSource>();
        _brain = _camera.GetComponent<CinemachineBrain>();
        NGyouHeader.name = "撥音";
    }

    // Update is called once per frame
    void Update()
    {
        switch (KanaType)
        {
            ///平假名
            case EKanaType.Hiragana:
                ///段标题
                ADanHeader.name = "あ段";
                IDanHeader.name = "い段";
                UDanHeader.name = "う段";
                EDanHeader.name = "え段";
                ODanHeader.name = "お段";
                ///行标题
                AGyouHeader.name = "あ行";
                KaGyouHeader.name = "か行";
                SaGyouHeader.name = "さ行";
                TaGyouHeader.name = "た行";
                NaGyouHeader.name = "な行";
                HaGyouHeader.name = "は行";
                MaGyouHeader.name = "ま行";
                YaGyouHeader.name = "や行";
                RaGyouHeader.name = "ら行";
                WaGyouHeader.name = "わ行";
                ///平假名
                ///a
                A.name = "あ";
                I.name = "い";
                U.name = "う";
                E.name = "え";
                O.name = "お";
                ///ka
                Ka.name = "か";
                Ki.name = "き";
                Ku.name = "く";
                Ke.name = "け";
                Ko.name = "こ";
                ///sa
                Sa.name = "さ";
                Shi.name = "し";
                Su.name = "す";
                Se.name = "せ";
                So.name = "そ";
                ///ta
                Ta.name = "た";
                Chi.name = "ち";
                Tsu.name = "つ";
                Te.name = "て";
                To.name = "と";
                ///na
                Na.name = "な";
                Ni.name = "に";
                Nu.name = "ぬ";
                Ne.name = "ね";
                No.name = "の";
                ///ha
                Ha.name = "は";
                Hi.name = "ひ";
                Fu.name = "ふ";
                He.name = "へ";
                Ho.name = "ほ";
                ///ma
                Ma.name = "ま";
                Mi.name = "み";
                Mu.name = "む";
                Me.name = "め";
                Mo.name = "も";
                ///ya
                Ya.name = "や";
                Yu.name = "ゆ";
                Yo.name = "よ";
                ///ra
                Ra.name = "ら";
                Ri.name = "り";
                Ru.name = "る";
                Re.name = "れ";
                Ro.name = "ろ";
                ///wa
                Wa.name = "わ";
                Wo.name = "を";
                ///n
                N.name = "ん";
                break;
            ///片假名
            case EKanaType.Katakana:
                ///段标题
                ADanHeader.name = "ア段";
                IDanHeader.name = "イ段";
                UDanHeader.name = "ウ段";
                EDanHeader.name = "エ段";
                ODanHeader.name = "オ段";
                ///行标题
                AGyouHeader.name = "ア行";
                KaGyouHeader.name = "カ行";
                SaGyouHeader.name = "サ行";
                TaGyouHeader.name = "タ行";
                NaGyouHeader.name = "ナ行";
                HaGyouHeader.name = "ハ行";
                MaGyouHeader.name = "マ行";
                YaGyouHeader.name = "ヤ行";
                RaGyouHeader.name = "ラ行";
                WaGyouHeader.name = "ワ行";
                ///片假名
                ///a
                A.name = "ア";
                I.name = "イ";
                U.name = "ウ";
                E.name = "エ";
                O.name = "オ";
                ///ka
                Ka.name = "カ";
                Ki.name = "キ";
                Ku.name = "ク";
                Ke.name = "ケ";
                Ko.name = "コ";
                ///sa
                Sa.name = "サ";
                Shi.name = "シ";
                Su.name = "ス";
                Se.name = "セ";
                So.name = "ソ";
                ///ta
                Ta.name = "タ";
                Chi.name = "チ";
                Tsu.name = "ツ";
                Te.name = "テ";
                To.name = "ト";
                ///na
                Na.name = "ナ";
                Ni.name = "ニ";
                Nu.name = "ヌ";
                Ne.name = "ネ";
                No.name = "ノ";
                ///ha
                Ha.name = "ハ";
                Hi.name = "ヒ";
                Fu.name = "フ";
                He.name = "ヘ";
                Ho.name = "ホ";
                ///ma
                Ma.name = "マ";
                Mi.name = "ミ";
                Mu.name = "ム";
                Me.name = "メ";
                Mo.name = "モ";
                ///ya
                Ya.name = "ヤ";
                Yu.name = "ユ";
                Yo.name = "ヨ";
                ///ra
                Ra.name = "ラ";
                Ri.name = "リ";
                Ru.name = "ル";
                Re.name = "レ";
                Ro.name = "ロ";
                ///wa
                Wa.name = "ワ";
                Wo.name = "ヲ";
                ///n
                N.name = "ン";
                break;
            default:
                break;
        }
    }

    public void 切换到平假名()
    {
        KanaType = EKanaType.Hiragana;
    }

    public void 切换到片假名()
    {
        KanaType = EKanaType.Katakana;
    }

    public void ChangeKanaType(string kanaType)
    {
        switch (kanaType)
        {
            case "":
            default:
                break;
            ///平假名
            case "hira":///简写
            case "hiragana":///完整
            case "hirakana":///误写
                KanaType = EKanaType.Hiragana;
                break;
            ///片假名
            case "kata":
            case "katakana":
                KanaType = EKanaType.Katakana;
                break;
        }
    }

    public void ToggleKanaType()
    {
        switch (KanaType)
        {
            default:
                break;
            case EKanaType.Hiragana:
                KanaType = EKanaType.Katakana;
                break;
            case EKanaType.Katakana:
                KanaType = EKanaType.Hiragana;
                break;
        }
    }
}

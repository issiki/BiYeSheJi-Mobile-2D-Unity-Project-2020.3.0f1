using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KanaGrid : MonoBehaviour
{
    /// <summary>
    /// �������
    /// </summary>
    public Camera _camera;
    public AudioSource _audioSource;
    public CinemachineBrain _brain;

    public enum EKanaType
    {
        Hiragana,
        Katakana,
    }
    [Header("������ʾ����")]
    public EKanaType kanaType;

    [Tooltip("��ǰ����")]
    public string CurrentKana;

    [Header("�α���")]
    public GameObject ADanHeader;
    public GameObject IDanHeader;
    public GameObject UDanHeader;
    public GameObject EDanHeader;
    public GameObject ODanHeader;

    [Header("�б���")]
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

    [Header("a��")]
    public GameObject A;
    public GameObject I;
    public GameObject U;
    public GameObject E;
    public GameObject O;

    [Header("ka��")]
    public GameObject Ka;
    public GameObject Ki;
    public GameObject Ku;
    public GameObject Ke;
    public GameObject Ko;

    [Header("sa��")]
    public GameObject Sa;
    public GameObject Shi;
    public GameObject Su;
    public GameObject Se;
    public GameObject So;

    [Header("ta��")]
    public GameObject Ta;
    public GameObject Chi;
    public GameObject Tsu;
    public GameObject Te;
    public GameObject To;

    [Header("na��")]
    public GameObject Na;
    public GameObject Ni;
    public GameObject Nu;
    public GameObject Ne;
    public GameObject No;

    [Header("ha��")]
    public GameObject Ha;
    public GameObject Hi;
    public GameObject Fu;
    public GameObject He;
    public GameObject Ho;

    [Header("ma��")]
    public GameObject Ma;
    public GameObject Mi;
    public GameObject Mu;
    public GameObject Me;
    public GameObject Mo;

    [Header("ya��")]
    public GameObject Ya;
    public GameObject Yu;
    public GameObject Yo;

    [Header("ra��")]
    public GameObject Ra;
    public GameObject Ri;
    public GameObject Ru;
    public GameObject Re;
    public GameObject Ro;

    [Header("wa��")]
    public GameObject Wa;
    public GameObject Wo;

    [Header("����")]
    public GameObject N;

    // Start is called before the first frame update
    void Start()
    {
        _camera = Camera.main;
        _audioSource = _camera.GetComponent<AudioSource>();
        _brain = _camera.GetComponent<CinemachineBrain>();
        NGyouHeader.name = "����";
    }

    // Update is called once per frame
    void Update()
    {
        switch (kanaType)
        {
            ///ƽ����
            case EKanaType.Hiragana:
                ///�α���
                ADanHeader.name = "����";
                IDanHeader.name = "����";
                UDanHeader.name = "����";
                EDanHeader.name = "����";
                ODanHeader.name = "����";
                ///�б���
                AGyouHeader.name = "����";
                KaGyouHeader.name = "����";
                SaGyouHeader.name = "����";
                TaGyouHeader.name = "����";
                NaGyouHeader.name = "����";
                HaGyouHeader.name = "����";
                MaGyouHeader.name = "����";
                YaGyouHeader.name = "����";
                RaGyouHeader.name = "����";
                WaGyouHeader.name = "����";
                ///ƽ����
                ///a
                A.name = "��";
                I.name = "��";
                U.name = "��";
                E.name = "��";
                O.name = "��";
                ///ka
                Ka.name = "��";
                Ki.name = "��";
                Ku.name = "��";
                Ke.name = "��";
                Ko.name = "��";
                ///sa
                Sa.name = "��";
                Shi.name = "��";
                Su.name = "��";
                Se.name = "��";
                So.name = "��";
                ///ta
                Ta.name = "��";
                Chi.name = "��";
                Tsu.name = "��";
                Te.name = "��";
                To.name = "��";
                ///na
                Na.name = "��";
                Ni.name = "��";
                Nu.name = "��";
                Ne.name = "��";
                No.name = "��";
                ///ha
                Ha.name = "��";
                Hi.name = "��";
                Fu.name = "��";
                He.name = "��";
                Ho.name = "��";
                ///ma
                Ma.name = "��";
                Mi.name = "��";
                Mu.name = "��";
                Me.name = "��";
                Mo.name = "��";
                ///ya
                Ya.name = "��";
                Yu.name = "��";
                Yo.name = "��";
                ///ra
                Ra.name = "��";
                Ri.name = "��";
                Ru.name = "��";
                Re.name = "��";
                Ro.name = "��";
                ///wa
                Wa.name = "��";
                Wo.name = "��";
                ///n
                N.name = "��";
                break;
            ///Ƭ����
            case EKanaType.Katakana:
                ///�α���
                ADanHeader.name = "����";
                IDanHeader.name = "����";
                UDanHeader.name = "����";
                EDanHeader.name = "����";
                ODanHeader.name = "����";
                ///�б���
                AGyouHeader.name = "����";
                KaGyouHeader.name = "����";
                SaGyouHeader.name = "����";
                TaGyouHeader.name = "����";
                NaGyouHeader.name = "����";
                HaGyouHeader.name = "����";
                MaGyouHeader.name = "����";
                YaGyouHeader.name = "����";
                RaGyouHeader.name = "����";
                WaGyouHeader.name = "����";
                ///Ƭ����
                ///a
                A.name = "��";
                I.name = "��";
                U.name = "��";
                E.name = "��";
                O.name = "��";
                ///ka
                Ka.name = "��";
                Ki.name = "��";
                Ku.name = "��";
                Ke.name = "��";
                Ko.name = "��";
                ///sa
                Sa.name = "��";
                Shi.name = "��";
                Su.name = "��";
                Se.name = "��";
                So.name = "��";
                ///ta
                Ta.name = "��";
                Chi.name = "��";
                Tsu.name = "��";
                Te.name = "��";
                To.name = "��";
                ///na
                Na.name = "��";
                Ni.name = "��";
                Nu.name = "��";
                Ne.name = "��";
                No.name = "��";
                ///ha
                Ha.name = "��";
                Hi.name = "��";
                Fu.name = "��";
                He.name = "��";
                Ho.name = "��";
                ///ma
                Ma.name = "��";
                Mi.name = "��";
                Mu.name = "��";
                Me.name = "��";
                Mo.name = "��";
                ///ya
                Ya.name = "��";
                Yu.name = "��";
                Yo.name = "��";
                ///ra
                Ra.name = "��";
                Ri.name = "��";
                Ru.name = "��";
                Re.name = "��";
                Ro.name = "��";
                ///wa
                Wa.name = "��";
                Wo.name = "��";
                ///n
                N.name = "��";
                break;
            default:
                break;
        }
    }

    public void �л���ƽ����()
    {
        kanaType = EKanaType.Hiragana;
    }

    public void �л���Ƭ����()
    {
        kanaType = EKanaType.Katakana;
    }

    public void ChangeKanaType(string kanaType)
    {
        switch (kanaType)
        {
            case "":
            default:
                break;
            ///ƽ����
            case "hira":///��д
            case "hiragana":///����
            case "hirakana":///��д
                this.kanaType = EKanaType.Hiragana;
                break;
            ///Ƭ����
            case "kata":
            case "katakana":
                this.kanaType = EKanaType.Katakana;
                break;
        }
    }

    public void ToggleKanaType()
    {
        switch (kanaType)
        {
            default:
                break;
            case EKanaType.Hiragana:
                kanaType = EKanaType.Katakana;
                break;
            case EKanaType.Katakana:
                kanaType = EKanaType.Hiragana;
                break;
        }
    }
}

using Cinemachine;
using UnityEngine;

[ExecuteInEditMode]
public class KanaVCam : MonoBehaviour
{
    public enum EKanaType
    {
        Hiragana,
        Katakana,
    }
    public CinemachineBrain Brain;
    public KanaGrid KanaGrid;
    static int PriorityLow = 10;
    static int PriorityHigh = 20;

    [Header("a")]
    public CinemachineVirtualCamera A;
    public CinemachineVirtualCamera I;
    public CinemachineVirtualCamera U;
    public CinemachineVirtualCamera E;
    public CinemachineVirtualCamera O;

    [Header("ka")]
    public CinemachineVirtualCamera Ka;
    public CinemachineVirtualCamera Ki;
    public CinemachineVirtualCamera Ku;
    public CinemachineVirtualCamera Ke;
    public CinemachineVirtualCamera Ko;

    [Header("sa")]
    public CinemachineVirtualCamera Sa;
    public CinemachineVirtualCamera Shi;
    public CinemachineVirtualCamera Su;
    public CinemachineVirtualCamera Se;
    public CinemachineVirtualCamera So;

    [Header("ta")]
    public CinemachineVirtualCamera Ta;
    public CinemachineVirtualCamera Chi;
    public CinemachineVirtualCamera Tsu;
    public CinemachineVirtualCamera Te;
    public CinemachineVirtualCamera To;

    [Header("na")]
    public CinemachineVirtualCamera Na;
    public CinemachineVirtualCamera Ni;
    public CinemachineVirtualCamera Nu;
    public CinemachineVirtualCamera Ne;
    public CinemachineVirtualCamera No;

    [Header("ha")]
    public CinemachineVirtualCamera Ha;
    public CinemachineVirtualCamera Hi;
    public CinemachineVirtualCamera Fu;
    public CinemachineVirtualCamera He;
    public CinemachineVirtualCamera Ho;
    [Header("ma")]
    public CinemachineVirtualCamera Ma;
    public CinemachineVirtualCamera Mi;
    public CinemachineVirtualCamera Mu;
    public CinemachineVirtualCamera Me;
    public CinemachineVirtualCamera Mo;
    [Header("ya")]
    public CinemachineVirtualCamera Ya;
    public CinemachineVirtualCamera Yu;
    public CinemachineVirtualCamera Yo;
    [Header("ra")]
    public CinemachineVirtualCamera Ra;
    public CinemachineVirtualCamera Ri;
    public CinemachineVirtualCamera Ru;
    public CinemachineVirtualCamera Re;
    public CinemachineVirtualCamera Ro;
    [Header("wa")]
    public CinemachineVirtualCamera Wa;
    public CinemachineVirtualCamera Wo;
    [Header("n")]
    public CinemachineVirtualCamera N;

    /// <summary>
    /// Æ¬¼ÙÃû
    /// </summary>
    [Header("a")]
    public CinemachineVirtualCamera AKata;
    public CinemachineVirtualCamera IKata;
    public CinemachineVirtualCamera UKata;
    public CinemachineVirtualCamera EKata;
    public CinemachineVirtualCamera OKata;

    [Header("ka")]
    public CinemachineVirtualCamera KaKata;
    public CinemachineVirtualCamera KiKata;
    public CinemachineVirtualCamera KuKata;
    public CinemachineVirtualCamera KeKata;
    public CinemachineVirtualCamera KoKata;

    [Header("sa")]
    public CinemachineVirtualCamera SaKata;
    public CinemachineVirtualCamera ShiKata;
    public CinemachineVirtualCamera SuKata;
    public CinemachineVirtualCamera SeKata;
    public CinemachineVirtualCamera SoKata;

    [Header("ta")]
    public CinemachineVirtualCamera TaKata;
    public CinemachineVirtualCamera ChiKata;
    public CinemachineVirtualCamera TsuKata;
    public CinemachineVirtualCamera TeKata;
    public CinemachineVirtualCamera ToKata;

    [Header("na")]
    public CinemachineVirtualCamera NaKata;
    public CinemachineVirtualCamera NiKata;
    public CinemachineVirtualCamera NuKata;
    public CinemachineVirtualCamera NeKata;
    public CinemachineVirtualCamera NoKata;

    [Header("ha")]
    public CinemachineVirtualCamera HaKata;
    public CinemachineVirtualCamera HiKata;
    public CinemachineVirtualCamera FuKata;
    public CinemachineVirtualCamera HeKata;
    public CinemachineVirtualCamera HoKata;
    [Header("ma")]
    public CinemachineVirtualCamera MaKata;
    public CinemachineVirtualCamera MiKata;
    public CinemachineVirtualCamera MuKata;
    public CinemachineVirtualCamera MeKata;
    public CinemachineVirtualCamera MoKata;
    [Header("ya")]
    public CinemachineVirtualCamera YaKata;
    public CinemachineVirtualCamera YuKata;
    public CinemachineVirtualCamera YoKata;
    [Header("ra")]
    public CinemachineVirtualCamera RaKata;
    public CinemachineVirtualCamera RiKata;
    public CinemachineVirtualCamera RuKata;
    public CinemachineVirtualCamera ReKata;
    public CinemachineVirtualCamera RoKata;
    [Header("wa")]
    public CinemachineVirtualCamera WaKata;
    public CinemachineVirtualCamera WoKata;
    [Header("n")]
    public CinemachineVirtualCamera NKata;

    void Start()
    {

    }

    void GotoHira(string kana)
    {
        switch (kana)
        {
            case "":
            default:
                break;
            ///a
            case "a":
                GotoVCam(A);
                break;
            case "i":
                GotoVCam(I);
                break;
            case "u":
                GotoVCam(U);
                break;
            case "e":
                GotoVCam(E);
                break;
            case "o":
                GotoVCam(O);
                break;
            ///ka
            case "ka":
                GotoVCam(Ka);
                break;
            case "ki":
                GotoVCam(Ki);
                break;
            case "ku":
                GotoVCam(Ku);
                break;
            case "ke":
                GotoVCam(Ke);
                break;
            case "ko":
                GotoVCam(Ko);
                break;
            ///sa
            case "sa":
                GotoVCam(Sa);
                break;
            case "shi":
                GotoVCam(Shi);
                break;
            case "su":
                GotoVCam(Su);
                break;
            case "se":
                GotoVCam(Se);
                break;
            case "so":
                GotoVCam(So);
                break;
            ///ta
            case "ta":
                GotoVCam(Ta);
                break;
            case "chi":
            case "ti":
                GotoVCam(Chi);
                break;
            case "tsu":
            case "tu":
                GotoVCam(Tsu);
                break;
            case "te":
                GotoVCam(Te);
                break;
            case "to":
                GotoVCam(To);
                break;
            ///na
            case "na":
                GotoVCam(Na);
                break;
            case "ni":
                GotoVCam(Ni);
                break;
            case "nu":
                GotoVCam(Nu);
                break;
            case "ne":
                GotoVCam(Ne);
                break;
            case "no":
                GotoVCam(No);
                break;
            ///ha
            case "ha":
                GotoVCam(Ha);
                break;
            case "hi":
                GotoVCam(Hi);
                break;
            case "fu":
            case "hu":
                GotoVCam(Fu);
                break;
            case "he":
                GotoVCam(He);
                break;
            case "ho":
                GotoVCam(Ho);
                break;
            ///ma
            case "ma":
                GotoVCam(Ma);
                break;
            case "mi":
                GotoVCam(Mi);
                break;
            case "mu":
                GotoVCam(Mu);
                break;
            case "me":
                GotoVCam(Me);
                break;
            case "mo":
                GotoVCam(Mo);
                break;
            ///ya
            case "ya":
                GotoVCam(Ya);
                break;
            case "yu":
                GotoVCam(Yu);
                break;
            case "yo":
                GotoVCam(Yo);
                break;
            ///ra
            case "ra":
                GotoVCam(Ra);
                break;
            case "ri":
                GotoVCam(Ri);
                break;
            case "ru":
                GotoVCam(Ru);
                break;
            case "re":
                GotoVCam(Re);
                break;
            case "ro":
                GotoVCam(Ro);
                break;
            ///wa
            case "wa":
                GotoVCam(Wa);
                break;
            case "wo":
                GotoVCam(Wo);
                break;
            ///n
            case "n":
                GotoVCam(N);
                break;
        }
    }

    void GotoKata(string kana)
    {
        switch (kana)
        {
            case "":
            default:
                break;
            ///a
            case "a":
                GotoVCam(AKata);
                break;
            case "i":
                GotoVCam(IKata);
                break;
            case "u":
                GotoVCam(UKata);
                break;
            case "e":
                GotoVCam(EKata);
                break;
            case "o":
                GotoVCam(OKata);
                break;
            ///ka
            case "ka":
                GotoVCam(KaKata);
                break;
            case "ki":
                GotoVCam(KiKata);
                break;
            case "ku":
                GotoVCam(KuKata);
                break;
            case "ke":
                GotoVCam(KeKata);
                break;
            case "ko":
                GotoVCam(KoKata);
                break;
            ///sa
            case "sa":
                GotoVCam(SaKata);
                break;
            case "shi":
                GotoVCam(ShiKata);
                break;
            case "su":
                GotoVCam(SuKata);
                break;
            case "se":
                GotoVCam(SeKata);
                break;
            case "so":
                GotoVCam(SoKata);
                break;
            ///ta
            case "ta":
                GotoVCam(TaKata);
                break;
            case "chi":
            case "ti":
                GotoVCam(ChiKata);
                break;
            case "tsu":
            case "tu":
                GotoVCam(TsuKata);
                break;
            case "te":
                GotoVCam(TeKata);
                break;
            case "to":
                GotoVCam(ToKata);
                break;
            ///na
            case "na":
                GotoVCam(NaKata);
                break;
            case "ni":
                GotoVCam(NiKata);
                break;
            case "nu":
                GotoVCam(NuKata);
                break;
            case "ne":
                GotoVCam(NeKata);
                break;
            case "no":
                GotoVCam(NoKata);
                break;
            ///ha
            case "ha":
                GotoVCam(HaKata);
                break;
            case "hi":
                GotoVCam(HiKata);
                break;
            case "fu":
            case "hu":
                GotoVCam(FuKata);
                break;
            case "he":
                GotoVCam(HeKata);
                break;
            case "ho":
                GotoVCam(HoKata);
                break;
            ///ma
            case "ma":
                GotoVCam(MaKata);
                break;
            case "mi":
                GotoVCam(MiKata);
                break;
            case "mu":
                GotoVCam(MuKata);
                break;
            case "me":
                GotoVCam(MeKata);
                break;
            case "mo":
                GotoVCam(MoKata);
                break;
            ///ya
            case "ya":
                GotoVCam(YaKata);
                break;
            case "yu":
                GotoVCam(YuKata);
                break;
            case "yo":
                GotoVCam(YoKata);
                break;
            ///ra
            case "ra":
                GotoVCam(RaKata);
                break;
            case "ri":
                GotoVCam(RiKata);
                break;
            case "ru":
                GotoVCam(RuKata);
                break;
            case "re":
                GotoVCam(ReKata);
                break;
            case "ro":
                GotoVCam(RoKata);
                break;
            ///wa
            case "wa":
                GotoVCam(WaKata);
                break;
            case "wo":
                GotoVCam(WoKata);
                break;
            ///n
            case "n":
                GotoVCam(NKata);
                break;
        }
    }

    public void GotoKana(string kana)
    {
        switch (KanaGrid.kanaType)
        {
            default:
                break;
            case KanaGrid.EKanaType.Hiragana:
                GotoHira(kana);
                break;
            case KanaGrid.EKanaType.Katakana:
                GotoKata(kana);
                break;
        }
    }

    void GotoVCam(CinemachineVirtualCamera nextVCam)
    {
        Brain.ActiveVirtualCamera.Priority = PriorityLow;
        nextVCam.Priority = PriorityHigh;
        Debug.Log($"ÇÐ»»µ½VCam£º{nextVCam.name}");
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[ExecuteInEditMode]
public class 笔画练字模块 : MonoBehaviour
{
    Camera _mainCamera;
    public string LayerName;
    int _layerMask;

    [Header("动画")]

    ///===平假名===
    /// <summary>
    /// a行
    /// </summary>
    [Header("a")]
    public GameObject[] AaHiraPoints;
    public bool[] _aaHiraFlags;

    [Header("i")]
    public GameObject[] IiHiraPoints;
    public bool[] _iiHiraFlags;

    [Header("u")]
    public GameObject[] UuHiraPoints;
    bool[] _uuHiraFlags;

    [Header("e")]
    public GameObject[] EeHiraPoints;
    bool[] _eeHiraFlags;

    [Header("o")]
    public GameObject[] OoHiraPoints;
    bool[] _ooHiraFlags;

    /// <summary>
    /// ka行
    /// </summary>
    [Header("ka")]
    public GameObject[] KaHiraPoints;
    bool[] _kaHiraFlags;

    [Header("ki")]
    public GameObject[] KiHiraPoints;
    bool[] _kiHiraFlags;

    [Header("ku")]
    public GameObject[] KuHiraPoints;
    bool[] _kuHiraFlags;

    [Header("ke")]
    public GameObject[] KeHiraPoints;
    bool[] _keHiraFlags;

    [Header("ko")]
    public GameObject[] KoHiraPoints;
    bool[] _koHiraFlags;

    /// <summary>
    /// sa行
    /// </summary>
    [Header("sa")]
    public GameObject[] SaHiraPoints;
    bool[] _saHiraFlags;

    [Header("si")]
    public GameObject[] ShiHiraPoints;
    bool[] _shiHiraFlags;

    [Header("su")]
    public GameObject[] SuHiraPoints;
    bool[] _suHiraFlags;

    [Header("se")]
    public GameObject[] SeHiraPoints;
    bool[] _seHiraFlags;

    [Header("so")]
    public GameObject[] SoHiraPoints;
    bool[] _soHiraFlags;

    /// <summary>
    /// ta行
    /// </summary>
    [Header("ta")]
    public GameObject[] TaHiraPoints;
    bool[] _taHiraFlags;

    [Header("chi")]
    public GameObject[] ChiHiraPoints;
    bool[] _chiHiraFlags;

    [Header("tsu")]
    public GameObject[] TsuHiraPoints;
    bool[] _tsuHiraFlags;

    [Header("te")]
    public GameObject[] TeHiraPoints;
    bool[] _teHiraFlags;

    [Header("to")]
    public GameObject[] ToHiraPoints;
    bool[] _toHiraFlags;

    /// <summary>
    /// na行
    /// </summary>
    [Header("na")]
    public GameObject[] NaHiraPoints;
    bool[] _naHiraFlags;

    [Header("ni")]
    public GameObject[] NiHiraPoints;
    bool[] _niHiraFlags;

    [Header("nu")]
    public GameObject[] NuHiraPoints;
    bool[] _nuHiraFlags;

    [Header("ne")]
    public GameObject[] NeHiraPoints;
    bool[] _neHiraFlags;

    [Header("no")]
    public GameObject[] NoHiraPoints;
    bool[] _noHiraFlags;

    /// <summary>
    /// ha行
    /// </summary>
    [Header("Ha")]
    public GameObject[] HaHiraPoints;
    bool[] _haHiraFlags;

    [Header("hi")]
    public GameObject[] HiHiraPoints;
    bool[] _hiHiraFlags;

    [Header("fu")]
    public GameObject[] FuHiraPoints;
    bool[] _fuHiraFlags;

    [Header("he")]
    public GameObject[] HeHiraPoints;
    bool[] _heHiraFlags;

    [Header("ho")]
    public GameObject[] HoHiraPoints;
    bool[] _hoHiraFlags;

    /// <summary>
    /// ma行
    /// </summary>
    [Header("Ma")]
    public GameObject[] MaHiraPoints;
    bool[] _maHiraFlags;

    [Header("mi")]
    public GameObject[] MiHiraPoints;
    bool[] _miHiraFlags;

    [Header("mu")]
    public GameObject[] MuHiraPoints;
    bool[] _muHiraFlags;

    [Header("me")]
    public GameObject[] MeHiraPoints;
    bool[] _meHiraFlags;

    [Header("mo")]
    public GameObject[] MoHiraPoints;
    bool[] _moHiraFlags;

    /// <summary>
    /// ya行
    /// </summary>
    [Header("ya")]
    public GameObject[] YaHiraPoints;
    bool[] _yaHiraFlags;

    [Header("yu")]
    public GameObject[] YuHiraPoints;
    bool[] _yuHiraFlags;

    [Header("yo")]
    public GameObject[] YoHiraPoints;
    bool[] _yoHiraFlags;

    /// <summary>
    /// ra行
    /// </summary>
    [Header("ra")]
    public GameObject[] RaHiraPoints;
    bool[] _raHiraFlags;

    [Header("ri")]
    public GameObject[] RiHiraPoints;
    bool[] _riHiraFlags;

    [Header("ru")]
    public GameObject[] RuHiraPoints;
    bool[] _ruHiraFlags;

    [Header("re")]
    public GameObject[] ReHiraPoints;
    bool[] _reHiraFlags;

    [Header("ro")]
    public GameObject[] RoHiraPoints;
    bool[] _roHiraFlags;

    /// <summary>
    /// wa行
    /// </summary>
    /// [Header("a")]
    public GameObject[] WaHiraPoints;
    bool[] _waHiraFlags;

    [Header("wo")]
    public GameObject[] WoHiraPoints;
    bool[] _woHiraFlags;

    /// <summary>
    /// n行
    /// </summary>
    /// [Header("a")]
    [Header("n")]
    public GameObject[] NnHiraPoints;
    bool[] _nnHiraFlags;


    /// <summary>
    /// a行
    /// </summary>
    [Header("a kata")]
    public GameObject[] AaKataPoints;
    bool[] _aaKataFlags;

    [Header("i kata")]
    public GameObject[] IiKataPoints;
    bool[] _iiKataFlags;

    [Header("u kata")]
    public GameObject[] UuKataPoints;
    bool[] _uuKataFlags;

    [Header("e kata")]
    public GameObject[] EeKataPoints;
    bool[] _eeKataFlags;

    [Header("o kata")]
    public GameObject[] OoKataPoints;
    bool[] _ooKataFlags;

    /// <summary>
    /// ka行
    /// </summary>
    [Header("ka kata")]
    public GameObject[] KaKataPoints;
    bool[] _kaKataFlags;

    [Header("ki kata")]
    public GameObject[] KiKataPoints;
    bool[] _kiKataFlags;

    [Header("ku kata")]
    public GameObject[] KuKataPoints;
    bool[] _kuKataFlags;

    [Header("ke kata")]
    public GameObject[] KeKataPoints;
    bool[] _keKataFlags;

    [Header("ko kata")]
    public GameObject[] KoKataPoints;
    bool[] _koKataFlags;

    /// <summary>
    /// sa行
    /// </summary>
    [Header("sa kata")]
    public GameObject[] SaKataPoints;
    bool[] _saKataFlags;

    [Header("si kata")]
    public GameObject[] ShiKataPoints;
    bool[] _shiKataFlags;

    [Header("su kata")]
    public GameObject[] SuKataPoints;
    bool[] _suKataFlags;

    [Header("se kata")]
    public GameObject[] SeKataPoints;
    bool[] _seKataFlags;

    [Header("so kata")]
    public GameObject[] SoKataPoints;
    bool[] _soKataFlags;

    /// <summary>
    /// ta行
    /// </summary>
    [Header("ta kata")]
    public GameObject[] TaKataPoints;
    bool[] _taKataFlags;

    [Header("chi kata")]
    public GameObject[] ChiKataPoints;
    bool[] _chiKataFlags;

    [Header("tsu kata")]
    public GameObject[] TsuKataPoints;
    bool[] _tsuKataFlags;

    [Header("te kata")]
    public GameObject[] TeKataPoints;
    bool[] _teKataFlags;

    [Header("to kata")]
    public GameObject[] ToKataPoints;
    bool[] _toKataFlags;

    /// <summary>
    /// ta行
    /// </summary>
    [Header("na kata")]
    public GameObject[] NaKataPoints;
    bool[] _naKataFlags;

    [Header("ni kata")]
    public GameObject[] NiKataPoints;
    bool[] _niKataFlags;

    [Header("nu kata")]
    public GameObject[] NuKataPoints;
    bool[] _nuKataFlags;

    [Header("ne kata")]
    public GameObject[] NeKataPoints;
    bool[] _neKataFlags;

    [Header("no kata")]
    public GameObject[] NoKataPoints;
    bool[] _noKataFlags;

    /// <summary>
    /// ha行
    /// </summary>
    [Header("Ha kata")]
    public GameObject[] HaKataPoints;
    bool[] _haKataFlags;

    [Header("hi kata")]
    public GameObject[] HiKataPoints;
    bool[] _hiKataFlags;

    [Header("fu kata")]
    public GameObject[] FuKataPoints;
    bool[] _fuKataFlags;

    [Header("he kata")]
    public GameObject[] HeKataPoints;
    bool[] _heKataFlags;

    [Header("ho kata")]
    public GameObject[] HoKataPoints;
    bool[] _hoKataFlags;

    /// <summary>
    /// ma行
    /// </summary>
    [Header("Ma kata")]
    public GameObject[] MaKataPoints;
    bool[] _maKataFlags;

    [Header("mi kata")]
    public GameObject[] MiKataPoints;
    bool[] _miKataFlags;

    [Header("mu kata")]
    public GameObject[] MuKataPoints;
    bool[] _muKataFlags;

    [Header("me kata")]
    public GameObject[] MeKataPoints;
    bool[] _meKataFlags;

    [Header("mo kata")]
    public GameObject[] MoKataPoints;
    bool[] _moKataFlags;

    /// <summary>
    /// ya行
    /// </summary>
    [Header("ya kata")]
    public GameObject[] YaKataPoints;
    bool[] _yaKataFlags;

    [Header("yu kata")]
    public GameObject[] YuKataPoints;
    bool[] _yuKataFlags;

    [Header("yo kata")]
    public GameObject[] YoKataPoints;
    bool[] _yoKataFlags;

    /// <summary>
    /// ra行
    /// </summary>
    [Header("ra kata")]
    public GameObject[] RaKataPoints;
    bool[] _raKataFlags;

    [Header("ri kata")]
    public GameObject[] RiKataPoints;
    bool[] _riKataFlags;

    [Header("ru kata")]
    public GameObject[] RuKataPoints;
    bool[] _ruKataFlags;

    [Header("re kata")]
    public GameObject[] ReKataPoints;
    bool[] _reKataFlags;

    [Header("ro kata")]
    public GameObject[] RoKataPoints;
    bool[] _roKataFlags;

    /// <summary>
    /// wa行
    /// </summary>
    /// [Header("a")]
    public GameObject[] WaKataPoints;
    bool[] _waKataFlags;

    [Header("wo kata")]
    public GameObject[] WoKataPoints;
    bool[] _woKataFlags;

    /// <summary>
    /// n行
    /// </summary>
    /// [Header("a")]
    [Header("n kata")]
    public GameObject[] NnKataPoints;
    bool[] _nnKataFlags;

    // Start is called before the first frame update
    void Start()
    {
        ///获取主摄像机
        _mainCamera = Camera.main;

        ///层遮罩
        _layerMask = LayerMask.GetMask(LayerName);

        //Debug.Log($"count:{AaHiraPoints.Count}");
        ///根据Points的数量为flags分配空间
        ///a
        InitFlagList(ref _aaHiraFlags, AaHiraPoints);
        InitFlagList(ref _iiHiraFlags, IiHiraPoints);
        InitFlagList(ref _uuHiraFlags, UuHiraPoints);
        InitFlagList(ref _eeHiraFlags, UuHiraPoints);
        InitFlagList(ref _ooHiraFlags, OoHiraPoints);
        ///ka
        InitFlagList(ref _kaHiraFlags, KaHiraPoints);
        InitFlagList(ref _kiHiraFlags, KiHiraPoints);
        InitFlagList(ref _kuHiraFlags, KuHiraPoints);
        InitFlagList(ref _keHiraFlags, KeHiraPoints);
        InitFlagList(ref _koHiraFlags, KoHiraPoints);
        ///sa
        InitFlagList(ref _saHiraFlags, SaHiraPoints);
        InitFlagList(ref _shiHiraFlags, ShiHiraPoints);
        InitFlagList(ref _suHiraFlags, SuHiraPoints);
        InitFlagList(ref _seHiraFlags, SeHiraPoints);
        InitFlagList(ref _soHiraFlags, SoHiraPoints);
        ///ta
        InitFlagList(ref _taHiraFlags, TaHiraPoints);
        InitFlagList(ref _chiHiraFlags, ChiHiraPoints);
        InitFlagList(ref _tsuHiraFlags, TsuHiraPoints);
        InitFlagList(ref _teHiraFlags, TeHiraPoints);
        InitFlagList(ref _toHiraFlags, ToHiraPoints);
        ///na
        InitFlagList(ref _naHiraFlags, NaHiraPoints);
        InitFlagList(ref _niHiraFlags, NiHiraPoints);
        InitFlagList(ref _nuHiraFlags, NuHiraPoints);
        InitFlagList(ref _neHiraFlags, NeHiraPoints);
        InitFlagList(ref _noHiraFlags, NoHiraPoints);
        ///ha
        InitFlagList(ref _haHiraFlags, HaHiraPoints);
        InitFlagList(ref _hiHiraFlags, HiHiraPoints);
        InitFlagList(ref _fuHiraFlags, FuHiraPoints);
        InitFlagList(ref _heHiraFlags, HeHiraPoints);
        InitFlagList(ref _hoHiraFlags, HoHiraPoints);
        ///ma
        InitFlagList(ref _maHiraFlags, MaHiraPoints);
        InitFlagList(ref _miHiraFlags, MiHiraPoints);
        InitFlagList(ref _muHiraFlags, MuHiraPoints);
        InitFlagList(ref _meHiraFlags, MeHiraPoints);
        InitFlagList(ref _moHiraFlags, MoHiraPoints);
        ///ya
        InitFlagList(ref _yaHiraFlags, YaHiraPoints);
        InitFlagList(ref _yuHiraFlags, YuHiraPoints);
        InitFlagList(ref _yoHiraFlags, YoHiraPoints);
        ///ra
        InitFlagList(ref _raHiraFlags, RaHiraPoints);
        InitFlagList(ref _riHiraFlags, RiHiraPoints);
        InitFlagList(ref _ruHiraFlags, RuHiraPoints);
        InitFlagList(ref _reHiraFlags, ReHiraPoints);
        InitFlagList(ref _roHiraFlags, RoHiraPoints);
        ///wa
        InitFlagList(ref _waHiraFlags, WaHiraPoints);
        InitFlagList(ref _woHiraFlags, WoHiraPoints);
        ///n
        InitFlagList(ref _nnHiraFlags, NnHiraPoints);

        ///初始化片假名的flags
        ///a
        InitFlagList(ref _aaKataFlags, AaKataPoints);
        InitFlagList(ref _iiKataFlags, IiKataPoints);
        InitFlagList(ref _uuKataFlags, UuKataPoints);
        InitFlagList(ref _eeKataFlags, EeKataPoints);
        InitFlagList(ref _ooKataFlags, OoKataPoints);
        ///ka
        InitFlagList(ref _kaKataFlags, KaKataPoints);
        InitFlagList(ref _kiKataFlags, KiKataPoints);
        InitFlagList(ref _kuKataFlags, KuKataPoints);
        InitFlagList(ref _keKataFlags, KeKataPoints);
        InitFlagList(ref _koKataFlags, KoKataPoints);
        ///sa
        InitFlagList(ref _saKataFlags, SaKataPoints);
        InitFlagList(ref _shiKataFlags, ShiKataPoints);
        InitFlagList(ref _suKataFlags, SuKataPoints);
        InitFlagList(ref _seKataFlags, SeKataPoints);
        InitFlagList(ref _soKataFlags, SoKataPoints);
        ///ta
        InitFlagList(ref _taKataFlags, TaKataPoints);
        InitFlagList(ref _chiKataFlags, ChiKataPoints);
        InitFlagList(ref _tsuKataFlags, TsuKataPoints);
        InitFlagList(ref _teKataFlags, TeKataPoints);
        InitFlagList(ref _toKataFlags, ToKataPoints);
        ///na
        InitFlagList(ref _naKataFlags, NaKataPoints);
        InitFlagList(ref _niKataFlags, NiKataPoints);
        InitFlagList(ref _nuKataFlags, NuKataPoints);
        InitFlagList(ref _neKataFlags, NeKataPoints);
        InitFlagList(ref _noKataFlags, NoKataPoints);
        ///ha
        InitFlagList(ref _haKataFlags, HaKataPoints);
        InitFlagList(ref _hiKataFlags, HiKataPoints);
        InitFlagList(ref _fuKataFlags, FuKataPoints);
        InitFlagList(ref _heKataFlags, HeKataPoints);
        InitFlagList(ref _hoKataFlags, HoKataPoints);
        ///ma
        InitFlagList(ref _maKataFlags, MaKataPoints);
        InitFlagList(ref _miKataFlags, MiKataPoints);
        InitFlagList(ref _muKataFlags, MuKataPoints);
        InitFlagList(ref _meKataFlags, MeKataPoints);
        InitFlagList(ref _moKataFlags, MoKataPoints);
        ///ya
        InitFlagList(ref _yaKataFlags, YaKataPoints);
        InitFlagList(ref _yuKataFlags, YuKataPoints);
        InitFlagList(ref _yoKataFlags, YoKataPoints);
        ///ra
        InitFlagList(ref _raKataFlags, RaKataPoints);
        InitFlagList(ref _riKataFlags, RiKataPoints);
        InitFlagList(ref _ruKataFlags, RuKataPoints);
        InitFlagList(ref _reKataFlags, ReKataPoints);
        InitFlagList(ref _roKataFlags, RoKataPoints);
        ///wa
        InitFlagList(ref _waKataFlags, WaKataPoints);
        InitFlagList(ref _woKataFlags, WoKataPoints);
        ///n
        InitFlagList(ref _nnKataFlags, NnKataPoints);
    }

    // Update is called once per frame
    void Update()
    {
        var lmb = Input.GetMouseButton(0);
        if (lmb)
        {
            ///获取鼠标的世界坐标
            var mouseWorldPos = _mainCamera.ScreenToWorldPoint(Input.mousePosition);
            ///在鼠标的坐标位置发出射线
            var hit2d = Physics2D.Raycast(mouseWorldPos, Vector2.zero, 0, _layerMask);


            ///如果碰撞到系列的第一个点
            ///平假名
            ///a
            HitFirstToMark(hit2d.collider, ref AaHiraPoints, ref _aaHiraFlags);
            ///i
            HitFirstToMark(hit2d.collider, ref IiHiraPoints, ref _iiHiraFlags);
            ///u
            HitFirstToMark(hit2d.collider, ref UuHiraPoints, ref _uuHiraFlags);
            ///e
            HitFirstToMark(hit2d.collider, ref EeHiraPoints, ref _eeHiraFlags);
            ///o
            HitFirstToMark(hit2d.collider, ref OoHiraPoints, ref _ooHiraFlags);

            ///ka
            HitFirstToMark(hit2d.collider, ref KaHiraPoints, ref _kaHiraFlags);
            ///ki
            HitFirstToMark(hit2d.collider, ref KiHiraPoints, ref _kiHiraFlags);
            ///ku
            HitFirstToMark(hit2d.collider, ref KuHiraPoints, ref _kuHiraFlags);
            ///ke
            HitFirstToMark(hit2d.collider, ref KeHiraPoints, ref _keHiraFlags);
            ///ko
            HitFirstToMark(hit2d.collider, ref KoHiraPoints, ref _koHiraFlags);

            ///sa
            HitFirstToMark(hit2d.collider, ref SaHiraPoints, ref _saHiraFlags);
            ///shi
            HitFirstToMark(hit2d.collider, ref ShiHiraPoints, ref _shiHiraFlags);
            ///su
            HitFirstToMark(hit2d.collider, ref SuHiraPoints, ref _suHiraFlags);
            ///se
            HitFirstToMark(hit2d.collider, ref SeHiraPoints, ref _seHiraFlags);
            ///so
            HitFirstToMark(hit2d.collider, ref SoHiraPoints, ref _soHiraFlags);

            ///ta
            HitFirstToMark(hit2d.collider, ref TaHiraPoints, ref _taHiraFlags);
            ///chi
            HitFirstToMark(hit2d.collider, ref ChiHiraPoints, ref _chiHiraFlags);
            ///tsu
            HitFirstToMark(hit2d.collider, ref TsuHiraPoints, ref _tsuHiraFlags);
            ///te
            HitFirstToMark(hit2d.collider, ref TeHiraPoints, ref _teHiraFlags);
            ///to
            HitFirstToMark(hit2d.collider, ref ToHiraPoints, ref _toHiraFlags);

            ///na
            HitFirstToMark(hit2d.collider, ref NaHiraPoints, ref _naHiraFlags);
            ///ni
            HitFirstToMark(hit2d.collider, ref NiHiraPoints, ref _niHiraFlags);
            ///nu
            HitFirstToMark(hit2d.collider, ref NuHiraPoints, ref _nuHiraFlags);
            ///ne
            HitFirstToMark(hit2d.collider, ref NeHiraPoints, ref _neHiraFlags);
            ///no
            HitFirstToMark(hit2d.collider, ref NoHiraPoints, ref _noHiraFlags);

            ///ha
            HitFirstToMark(hit2d.collider, ref HaHiraPoints, ref _haHiraFlags);
            ///hi
            HitFirstToMark(hit2d.collider, ref HiHiraPoints, ref _hiHiraFlags);
            ///fu
            HitFirstToMark(hit2d.collider, ref FuHiraPoints, ref _fuHiraFlags);
            ///he
            HitFirstToMark(hit2d.collider, ref HeHiraPoints, ref _heHiraFlags);
            ///ho
            HitFirstToMark(hit2d.collider, ref HoHiraPoints, ref _hoHiraFlags);

            ///ma
            HitFirstToMark(hit2d.collider, ref MaHiraPoints, ref _maHiraFlags);
            ///mi
            HitFirstToMark(hit2d.collider, ref MiHiraPoints, ref _miHiraFlags);
            ///mu
            HitFirstToMark(hit2d.collider, ref MuHiraPoints, ref _muHiraFlags);
            ///me
            HitFirstToMark(hit2d.collider, ref MeHiraPoints, ref _meHiraFlags);
            ///mo
            HitFirstToMark(hit2d.collider, ref MoHiraPoints, ref _moHiraFlags);

            ///ya
            HitFirstToMark(hit2d.collider, ref YaHiraPoints, ref _yaHiraFlags);
            ///yu
            HitFirstToMark(hit2d.collider, ref YuHiraPoints, ref _yuHiraFlags);
            ///yo
            HitFirstToMark(hit2d.collider, ref YoHiraPoints, ref _yoHiraFlags);

            ///ra
            HitFirstToMark(hit2d.collider, ref RaHiraPoints, ref _raHiraFlags);
            ///ri
            HitFirstToMark(hit2d.collider, ref RiHiraPoints, ref _riHiraFlags);
            ///ru
            HitFirstToMark(hit2d.collider, ref RuHiraPoints, ref _ruHiraFlags);
            ///re
            HitFirstToMark(hit2d.collider, ref ReHiraPoints, ref _reHiraFlags);
            ///ro
            HitFirstToMark(hit2d.collider, ref RoHiraPoints, ref _roHiraFlags);

            ///wa
            HitFirstToMark(hit2d.collider, ref WaHiraPoints, ref _waHiraFlags);
            ///wo
            HitFirstToMark(hit2d.collider, ref WoHiraPoints, ref _woHiraFlags);

            ///n
            HitFirstToMark(hit2d.collider, ref NnHiraPoints, ref _nnHiraFlags);

            ///===片假名===
            ///a
            HitFirstToMark(hit2d.collider, ref AaKataPoints, ref _aaKataFlags);
            ///i
            HitFirstToMark(hit2d.collider, ref IiKataPoints, ref _iiKataFlags);
            ///u
            HitFirstToMark(hit2d.collider, ref UuKataPoints, ref _uuKataFlags);
            ///e
            HitFirstToMark(hit2d.collider, ref EeKataPoints, ref _eeKataFlags);
            ///o
            HitFirstToMark(hit2d.collider, ref OoKataPoints, ref _ooKataFlags);

            ///ka
            HitFirstToMark(hit2d.collider, ref KaKataPoints, ref _kaKataFlags);
            ///ki
            HitFirstToMark(hit2d.collider, ref KiKataPoints, ref _kiKataFlags);
            ///ku
            HitFirstToMark(hit2d.collider, ref KuKataPoints, ref _kuKataFlags);
            ///ke
            HitFirstToMark(hit2d.collider, ref KeKataPoints, ref _keKataFlags);
            ///ko
            HitFirstToMark(hit2d.collider, ref KoKataPoints, ref _koKataFlags);

            ///sa
            HitFirstToMark(hit2d.collider, ref SaKataPoints, ref _saKataFlags);
            ///shi
            HitFirstToMark(hit2d.collider, ref ShiKataPoints, ref _shiKataFlags);
            ///su
            HitFirstToMark(hit2d.collider, ref SuKataPoints, ref _suKataFlags);
            ///se
            HitFirstToMark(hit2d.collider, ref SeKataPoints, ref _seKataFlags);
            ///so
            HitFirstToMark(hit2d.collider, ref SoKataPoints, ref _soKataFlags);

            ///ta
            HitFirstToMark(hit2d.collider, ref TaKataPoints, ref _taKataFlags);
            ///chi
            HitFirstToMark(hit2d.collider, ref ChiKataPoints, ref _chiKataFlags);
            ///tsu
            HitFirstToMark(hit2d.collider, ref TsuKataPoints, ref _tsuKataFlags);
            ///te
            HitFirstToMark(hit2d.collider, ref TeKataPoints, ref _teKataFlags);
            ///to
            HitFirstToMark(hit2d.collider, ref ToKataPoints, ref _toKataFlags);

            ///na
            HitFirstToMark(hit2d.collider, ref NaKataPoints, ref _naKataFlags);
            ///ni
            HitFirstToMark(hit2d.collider, ref NiKataPoints, ref _niKataFlags);
            ///nu
            HitFirstToMark(hit2d.collider, ref NuKataPoints, ref _nuKataFlags);
            ///ne
            HitFirstToMark(hit2d.collider, ref NeKataPoints, ref _neKataFlags);
            ///no
            HitFirstToMark(hit2d.collider, ref NoKataPoints, ref _noKataFlags);

            ///ha
            HitFirstToMark(hit2d.collider, ref HaKataPoints, ref _haKataFlags);
            ///hi
            HitFirstToMark(hit2d.collider, ref HiKataPoints, ref _hiKataFlags);
            ///fu
            HitFirstToMark(hit2d.collider, ref FuKataPoints, ref _fuKataFlags);
            ///he
            HitFirstToMark(hit2d.collider, ref HeKataPoints, ref _heKataFlags);
            ///ho
            HitFirstToMark(hit2d.collider, ref HoKataPoints, ref _hoKataFlags);

            ///ma
            HitFirstToMark(hit2d.collider, ref MaKataPoints, ref _maKataFlags);
            ///mi
            HitFirstToMark(hit2d.collider, ref MiKataPoints, ref _miKataFlags);
            ///mu
            HitFirstToMark(hit2d.collider, ref MuKataPoints, ref _muKataFlags);
            ///me
            HitFirstToMark(hit2d.collider, ref MeKataPoints, ref _meKataFlags);
            ///mo
            HitFirstToMark(hit2d.collider, ref MoKataPoints, ref _moKataFlags);

            ///ya
            HitFirstToMark(hit2d.collider, ref YaKataPoints, ref _yaKataFlags);
            ///yu
            HitFirstToMark(hit2d.collider, ref YuKataPoints, ref _yuKataFlags);
            ///yo
            HitFirstToMark(hit2d.collider, ref YoKataPoints, ref _yoKataFlags);

            ///ra
            HitFirstToMark(hit2d.collider, ref RaKataPoints, ref _raKataFlags);
            ///ri
            HitFirstToMark(hit2d.collider, ref RiKataPoints, ref _riKataFlags);
            ///ru
            HitFirstToMark(hit2d.collider, ref RuKataPoints, ref _ruKataFlags);
            ///re
            HitFirstToMark(hit2d.collider, ref ReKataPoints, ref _reKataFlags);
            ///ro
            HitFirstToMark(hit2d.collider, ref RoKataPoints, ref _roKataFlags);

            ///wa
            HitFirstToMark(hit2d.collider, ref WaKataPoints, ref _waKataFlags);
            ///wo
            HitFirstToMark(hit2d.collider, ref WoKataPoints, ref _woKataFlags);

            ///n
            HitFirstToMark(hit2d.collider, ref NnKataPoints, ref _nnKataFlags);
        }
    }

    void HitFirstToMark(Collider2D hit2dCollider, ref GameObject[] points, ref bool[] flags)
    {
        if (hit2dCollider == null)
        {
            if (!flags.First())
            {
                ///重置flags
                Array.Clear(flags, 0, flags.Length);
            }

            return;
        }

        var hitObject = hit2dCollider.gameObject;

        var index = -1;
        for (var i = 0; i < points.Length; i++)
        {
            if (points[i] == hitObject)
            {
                index = i;
                i = points.Length;
            }
        }

        if (index < 0)
        {
            return;
        }

        //Debug.Log($"hit {hitObject}");

        ///如果碰撞了系列的第一个点
        if (hitObject == points.First())
        {
            ///则标记第一点
            flags[0] = true;
        }
        else
        ///如果碰撞了系列的最后一个点，则检查是否标记过系列所有点，如果标记过，表示完成了书写练习，如果没标记，则没完成
        ///无论结果，都重置flags
        if (hitObject == points.Last())
        {
            flags[index] = true;

            var count = flags.Count(el => el);
            /*
            for (var i = 0; i < flags.Length; i++)
            {
                if (!flags[i])
                {
                    Debug.LogWarning($"NOT true: {i}");
                }
            }
            */

            //Debug.Log($"count: {count}, flags length: {flags.Length}");
            ///检查是否全部碰撞标记是否都为真
            if (count == flags.Length)
            {
                练习书写完成();
            }

            ///重置flags
            Array.Clear(flags, 0, flags.Length);
        }
        ///如果碰撞的是其他点（可能不是这个系列的），标记该位置
        else
        {
            flags[index] = true;
        }
    }

    void InitFlagList(ref bool[] flags, GameObject[] points)
    {
        flags = new bool[points.Length];

        /*
        for (var i = 0; i < points.Length; i++)
        {
            flags.(false);
        }
        flags.
            */
    }

    void 练习书写完成()
    {
        Debug.Log("练习书写完成");
    }
}

using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class OneNformB03
{
    public int Id { get; set; }

    /// <summary>
    /// 表單名稱
    /// </summary>
    public string FormName { get; set; } = null!;

    /// <summary>
    /// 年分
    /// </summary>
    public string Year { get; set; } = null!;

    public int SchoolCtrl001id { get; set; }

    /// <summary>
    /// 案名
    /// </summary>
    public string CaseName { get; set; } = null!;

    /// <summary>
    /// 所屬系學類
    /// </summary>
    public string DepartmentNum { get; set; } = null!;

    /// <summary>
    /// 領域別
    /// </summary>
    public string AreaName { get; set; } = null!;

    /// <summary>
    /// 招生學制
    /// </summary>
    public string Enrollment { get; set; } = null!;

    /// <summary>
    /// 所屬學院
    /// </summary>
    public string College { get; set; } = null!;

    /// <summary>
    /// 授予學位名稱
    /// </summary>
    public string DegreeName { get; set; } = null!;

    /// <summary>
    /// 送審類別(主領域)
    /// </summary>
    public string MainField { get; set; } = null!;

    /// <summary>
    /// 送審類別(副領域)
    /// </summary>
    public string? SubField { get; set; }

    /// <summary>
    /// 技專校院設有與本申請案名相關系所學位學程之參考資料
    /// </summary>
    public string RelatedDegreeData { get; set; } = null!;

    /// <summary>
    /// 本案是否為第一次申請
    /// </summary>
    public bool IsFirstApply { get; set; }

    /// <summary>
    /// 否&gt;前次申請之增設學年度
    /// </summary>
    public string? LastApplyYear { get; set; }

    /// <summary>
    /// 是否已經校務會議決議通過
    /// </summary>
    public bool IsPassed { get; set; }

    /// <summary>
    /// 校務會議日期
    /// </summary>
    public string? ConferenceDate { get; set; }

    /// <summary>
    /// 校務會議提案編號
    /// </summary>
    public string? ProposalNum { get; set; }

    /// <summary>
    /// 尚未經校務會議通過-&gt;預計會議日期
    /// </summary>
    public string? ConferenceExpectDate { get; set; }

    /// <summary>
    /// 申請單位主管姓名
    /// </summary>
    public string ManagerName { get; set; } = null!;

    /// <summary>
    /// 申請單位主管職稱
    /// </summary>
    public string ManagerJobTitle { get; set; } = null!;

    /// <summary>
    /// 申請單位主管連絡電話
    /// </summary>
    public string ManagerPhone { get; set; } = null!;

    /// <summary>
    /// 申請單位主管電子郵件
    /// </summary>
    public string ManagerMail { get; set; } = null!;

    /// <summary>
    /// 申請單位連絡人姓名
    /// </summary>
    public string? ApplicantName { get; set; }

    /// <summary>
    /// 申請單位連絡人職稱
    /// </summary>
    public string? ApplicantJobTitle { get; set; }

    /// <summary>
    /// 申請單位連絡人連絡電話
    /// </summary>
    public string? ApplicantPhone { get; set; }

    /// <summary>
    /// 申請單位連絡人電子郵件
    /// </summary>
    public string? ApplicantMail { get; set; }

    /// <summary>
    /// &quot;設立理由
    /// (200字)&quot;
    /// </summary>
    public string Comment001 { get; set; } = null!;

    /// <summary>
    /// &quot;發展定位
    /// (200字)&quot;
    /// </summary>
    public string Comment002 { get; set; } = null!;

    /// <summary>
    /// &quot;培育目標
    /// (200字)&quot;
    /// </summary>
    public string Comment003 { get; set; } = null!;

    /// <summary>
    /// &quot;課程規劃
    /// (200字)&quot;
    /// </summary>
    public string Comment004 { get; set; } = null!;

    /// <summary>
    /// &quot;畢業後就業方向
    /// (200字)&quot;
    /// </summary>
    public string Comment005 { get; set; } = null!;

    /// <summary>
    /// &quot;就業領域之目的事業主管機關
    /// (200字)&quot;
    /// </summary>
    public string Comment006 { get; set; } = null!;

    /// <summary>
    /// 全校日夜生師比值(%)
    /// </summary>
    public decimal TeacherPupilPer001 { get; set; }

    /// <summary>
    /// 全校日間生師比值(%)
    /// </summary>
    public decimal TeacherPupilPer002 { get; set; }

    /// <summary>
    /// 全校研究生生師比值(%)
    /// </summary>
    public decimal TeacherPupilPer003 { get; set; }

    /// <summary>
    /// 全校專任助理教授以上師資結構(%)
    /// </summary>
    public decimal TeacherPupilPer004 { get; set; }

    /// <summary>
    /// 是否有過評鑑結果
    /// </summary>
    public bool EvaluationIsPassed { get; set; }

    /// <summary>
    /// &quot;評鑑成績
    /// 評鑑名稱&quot;
    /// </summary>
    public string? EvaluationName { get; set; }

    /// <summary>
    /// &quot;評鑑成績
    /// 評鑑年度&quot;
    /// </summary>
    public string? EvaluationYear { get; set; }

    /// <summary>
    /// &quot;評鑑成績
    /// 評鑑結果&quot;
    /// </summary>
    public string? EvaluationResult { get; set; }

    /// <summary>
    /// 申請增設日間碩士班/碩士在職專班
    /// </summary>
    public string ApplyOption { get; set; } = null!;

    /// <summary>
    /// 系增設之學年度
    /// </summary>
    public string? DepartmentEstablishedTime { get; set; }

    /// <summary>
    /// 系增設已滿滿_年
    /// </summary>
    public string? DepartmentEstablishedYears { get; set; }

    /// <summary>
    /// 申請碩在職-&gt;已設立之日間碩士班名稱
    /// </summary>
    public string? MasterDayName { get; set; }

    /// <summary>
    /// 設立日間碩士班於_年
    /// </summary>
    public string? MasterDayEstablishedTime { get; set; }

    /// <summary>
    /// 已設立滿_年
    /// </summary>
    public string? MasterDayEstablishedYears { get; set; }

    /// <summary>
    /// 專任師資人數實聘教授
    /// </summary>
    public string FullTimeTeacher001 { get; set; } = null!;

    /// <summary>
    /// 專任師資人數擬聘教授
    /// </summary>
    public string FullTimeTeacher002 { get; set; } = null!;

    /// <summary>
    /// 專任師資人數實聘副教授
    /// </summary>
    public string FullTimeTeacher003 { get; set; } = null!;

    /// <summary>
    /// 專任師資人數擬聘副教授
    /// </summary>
    public string FullTimeTeacher004 { get; set; } = null!;

    /// <summary>
    /// 專任師資人數實聘助理教授
    /// </summary>
    public string FullTimeTeacher005 { get; set; } = null!;

    /// <summary>
    /// 專任師資人數擬聘助理教授
    /// </summary>
    public string FullTimeTeacher006 { get; set; } = null!;

    /// <summary>
    /// 專任師資人數講師實聘
    /// </summary>
    public string FullTimeTeacher007 { get; set; } = null!;

    /// <summary>
    /// 專任師資人數講師擬聘
    /// </summary>
    public string FullTimeTeacher008 { get; set; } = null!;

    /// <summary>
    /// 專任師資人數實聘合計
    /// </summary>
    public string FullTimeTeacherTotal1 { get; set; } = null!;

    /// <summary>
    /// 專任師資人數擬聘合計
    /// </summary>
    public string FullTimeTeacherTotal2 { get; set; } = null!;

    /// <summary>
    /// 填報目前流程狀態
    /// </summary>
    public int OneNformState { get; set; }

    /// <summary>
    /// 執行編輯之使用者id
    /// </summary>
    public int EditAuth001 { get; set; }

    /// <summary>
    /// 執行編輯之時間
    /// </summary>
    public DateTime EditTime { get; set; }

    /// <summary>
    /// 提醒文字
    /// </summary>
    public string? Remind { get; set; }

    /// <summary>
    /// 匯出檔案名稱
    /// </summary>
    public string? ExportFileName { get; set; }

    /// <summary>
    /// 修正後主領域
    /// </summary>
    public string? MainFieldEdited { get; set; }

    /// <summary>
    /// 修正後副領域
    /// </summary>
    public string? SubFieldEdited { get; set; }

    /// <summary>
    /// 送審否
    /// </summary>
    public bool? ExamineEnabled { get; set; }

    /// <summary>
    /// 核定最終結果
    /// </summary>
    public bool? ApprovedResult { get; set; }

    /// <summary>
    /// 審查結果字號
    /// </summary>
    public string? ExamineResultNum { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string? Notes { get; set; }

    public string? Comment007 { get; set; }
}

using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class OneExamine002
{
    /// <summary>
    /// PK
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// FK_OneExamine001Id 第一階段審查分配進度表 編號
    /// </summary>
    public int OneExamine001Id { get; set; }

    /// <summary>
    /// 1=審查招集人，2=審查委員
    /// </summary>
    public int ExamineNum { get; set; }

    /// <summary>
    /// FK_Auth001 審查者
    /// </summary>
    public int WriterAuth001Id { get; set; }

    /// <summary>
    /// 開設理由、開設必要性
    /// </summary>
    public string? ExamineContent11 { get; set; }

    public string? ExamineContent12 { get; set; }

    public string? ExamineContent13 { get; set; }

    public string? ExamineContent14 { get; set; }

    public string? ExamineContent15 { get; set; }

    /// <summary>
    /// 課程規劃
    /// </summary>
    public string? ExamineContent21 { get; set; }

    public string? ExamineContent22 { get; set; }

    public string? ExamineContent23 { get; set; }

    public string? ExamineContent24 { get; set; }

    public string? ExamineContent25 { get; set; }

    /// <summary>
    /// 師資規劃
    /// </summary>
    public string? ExamineContent31 { get; set; }

    public string? ExamineContent32 { get; set; }

    public string? ExamineContent33 { get; set; }

    public string? ExamineContent34 { get; set; }

    public string? ExamineContent35 { get; set; }

    /// <summary>
    /// 產學合作學術表現
    /// </summary>
    public string? ExamineContent41 { get; set; }

    public string? ExamineContent42 { get; set; }

    public string? ExamineContent43 { get; set; }

    public string? ExamineContent44 { get; set; }

    public string? ExamineContent45 { get; set; }

    /// <summary>
    /// 圖書、儀器、設備與空間規劃
    /// </summary>
    public string? ExamineContent51 { get; set; }

    public string? ExamineContent52 { get; set; }

    public string? ExamineContent53 { get; set; }

    public string? ExamineContent54 { get; set; }

    public string? ExamineContent55 { get; set; }

    /// <summary>
    /// 其他
    /// </summary>
    public string? ExamineContent61 { get; set; }

    public string? ExamineContent62 { get; set; }

    public string? ExamineContent63 { get; set; }

    public string? ExamineContent64 { get; set; }

    public string? ExamineContent65 { get; set; }

    public string? ExamineContent71 { get; set; }

    public string? ExamineContent72 { get; set; }

    public string? ExamineContent73 { get; set; }

    public string? ExamineContent74 { get; set; }

    public string? ExamineContent75 { get; set; }

    /// <summary>
    /// 綜合審查意見/非碩士班增設時之審查意見欄位
    /// </summary>
    public string? ExamineContentTotal1 { get; set; }

    public string? ExamineContentTotal2 { get; set; }

    public string? ExamineContentTotal3 { get; set; }

    public string? ExamineContentTotal4 { get; set; }

    public string? ExamineContentTotal5 { get; set; }

    /// <summary>
    /// 審查結果(推薦/不推薦)
    /// </summary>
    public string? ExamineContentResult { get; set; }

    /// <summary>
    /// 審查狀態
    /// </summary>
    public int ExamineState002 { get; set; }

    /// <summary>
    /// 審查到期時間
    /// </summary>
    public string? ExamineDeadLine { get; set; }

    /// <summary>
    /// 審查完成時間
    /// </summary>
    public string? ExamineFinishDate { get; set; }

    /// <summary>
    /// FK_Auth001 創建/編輯
    /// </summary>
    public int? EditAuth001Id { get; set; }

    /// <summary>
    /// 創建/編輯時間
    /// </summary>
    public DateTime EditTime { get; set; }
}

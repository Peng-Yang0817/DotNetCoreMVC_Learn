using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class OneExamine001
{
    /// <summary>
    /// PK
    /// </summary>
    public int Id { get; set; }

    public int? ExamineYear { get; set; }

    /// <summary>
    /// FK_OneNFormTypeId 一階表件分類
    /// </summary>
    public int? OneNformTypeId { get; set; }

    /// <summary>
    /// FK_OneNFormId 一階表件編號
    /// </summary>
    public int OneNformId { get; set; }

    /// <summary>
    /// 序號，提供總量整理文件參考用，由總量人員決定&amp;輸入
    /// </summary>
    public string? SerialName { get; set; }

    public int? SchoolCtrl001id { get; set; }

    public string? CaseName { get; set; }

    public string? OneNformAdjustment { get; set; }

    /// <summary>
    /// FK_Auth001 審查招集人
    /// </summary>
    public int? RecruitAuth001Id { get; set; }

    /// <summary>
    /// FK_Auth001 審查委員01
    /// </summary>
    public int? Examine01Auth001Id { get; set; }

    /// <summary>
    /// FK_Auth001 審查委員02
    /// </summary>
    public int? Examine02Auth001Id { get; set; }

    /// <summary>
    /// FK_Auth001 審查委員03
    /// </summary>
    public int? Examine03Auth001Id { get; set; }

    /// <summary>
    /// FK_Auth001 審查委員04
    /// </summary>
    public int? Examine04Auth001Id { get; set; }

    /// <summary>
    /// FK_Auth001 審查委員05
    /// </summary>
    public int? Examine05Auth001Id { get; set; }

    /// <summary>
    /// 審查進度狀態
    /// </summary>
    public int ExamineState001 { get; set; }

    /// <summary>
    /// FK_Auth001 創建/編輯
    /// </summary>
    public int EditAuth001Id { get; set; }

    /// <summary>
    /// 創建/編輯時間
    /// </summary>
    public DateTime EditTime { get; set; }
}

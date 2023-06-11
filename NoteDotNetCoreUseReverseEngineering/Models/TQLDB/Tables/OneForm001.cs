using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class OneForm001
{
    /// <summary>
    /// PK 表1 編碼
    /// </summary>
    public string Id { get; set; } = null!;

    /// <summary>
    /// FK SchoolCtrl001 學校 編碼
    /// </summary>
    public int SchoolCtrl001Id { get; set; }

    /// <summary>
    /// 學年度
    /// </summary>
    public string Year { get; set; } = null!;

    /// <summary>
    /// 表1計畫書 申請案名稱
    /// </summary>
    public string ProjectName { get; set; } = null!;

    /// <summary>
    /// FK State011 增設/申請類別 編碼
    /// </summary>
    public int State011Id { get; set; }

    /// <summary>
    /// FK State012 招生學制 編碼
    /// </summary>
    public int State012Id { get; set; }

    /// <summary>
    /// FK SchoolCtrl002 學院 編碼
    /// </summary>
    public int SchoolCtrl002Id { get; set; }

    /// <summary>
    /// 授予學位名稱
    /// </summary>
    public string DegreeName { get; set; } = null!;

    /// <summary>
    /// FK State013 建議送審類別 編碼
    /// </summary>
    public int State013Id { get; set; }

    /// <summary>
    /// FK State014 本案是否曾申請過 編碼
    /// </summary>
    public int State014Id { get; set; }

    /// <summary>
    /// 本案曾申請未通過，前次申請之增設學年度
    /// </summary>
    public string? State014Year { get; set; }

    /// <summary>
    /// FK State015 系所類別 編碼
    /// </summary>
    public int State015Id { get; set; }

    /// <summary>
    /// 申請聯絡人1
    /// </summary>
    public string Applicant1 { get; set; } = null!;

    /// <summary>
    /// 職稱/單位1
    /// </summary>
    public string Job1 { get; set; } = null!;

    /// <summary>
    /// 電話1
    /// </summary>
    public string Phone1 { get; set; } = null!;

    /// <summary>
    /// E-mail1
    /// </summary>
    public string Email1 { get; set; } = null!;

    /// <summary>
    /// 申請聯絡人2
    /// </summary>
    public string? Applicant2 { get; set; }

    /// <summary>
    /// 職稱/單位2
    /// </summary>
    public string? Job2 { get; set; }

    /// <summary>
    /// 電話2
    /// </summary>
    public string? Phone2 { get; set; }

    /// <summary>
    /// E-mail2
    /// </summary>
    public string? Email2 { get; set; }

    /// <summary>
    /// 申請聯絡人3
    /// </summary>
    public string? Applicant3 { get; set; }

    /// <summary>
    /// 職稱/單位2
    /// </summary>
    public string? Job3 { get; set; }

    /// <summary>
    /// 電話2
    /// </summary>
    public string? Phone3 { get; set; }

    /// <summary>
    /// E-mail3
    /// </summary>
    public string? Email3 { get; set; }

    /// <summary>
    /// 全校日夜生師比值
    /// </summary>
    public double C1 { get; set; }

    /// <summary>
    /// 全校日間生師比值
    /// </summary>
    public double C2 { get; set; }

    /// <summary>
    /// 全校研究生生師比值
    /// </summary>
    public double C3 { get; set; }

    /// <summary>
    /// 全校專任助理教授以上師資結構
    /// </summary>
    public double C4 { get; set; }

    /// <summary>
    /// FK 上傳pdf檔案 編碼
    /// </summary>
    public string? OneFormUploadId { get; set; }

    /// <summary>
    /// 創建/修改時間
    /// </summary>
    public DateTime EditTime { get; set; }

    /// <summary>
    /// 創建/修改者
    /// </summary>
    public int EditAuth001 { get; set; }
}

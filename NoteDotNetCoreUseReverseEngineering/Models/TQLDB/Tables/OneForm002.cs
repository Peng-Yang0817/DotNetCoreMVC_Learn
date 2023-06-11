using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class OneForm002
{
    /// <summary>
    /// PK 表2 編碼
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// FK SchoolCtrl001 學校 編碼
    /// </summary>
    public int SchoolCtrl001Id { get; set; }

    /// <summary>
    /// 學年度
    /// </summary>
    public string Year { get; set; } = null!;

    /// <summary>
    /// 表2計畫書 申請案名稱
    /// </summary>
    public string ProjectName { get; set; } = null!;

    /// <summary>
    /// 申請別
    /// </summary>
    public int State011Id { get; set; }

    /// <summary>
    /// 本系所科系現有招生學制
    /// </summary>
    public string C1 { get; set; } = null!;

    /// <summary>
    /// 本所系科增設之學年度
    /// </summary>
    public string C2 { get; set; } = null!;

    /// <summary>
    /// 最近三學年度（105~107學年度）是否曾核定改名、整併過
    /// </summary>
    public int? State018Id { get; set; }

    /// <summary>
    /// 是。學年度
    /// </summary>
    public string? C3 { get; set; }

    /// <summary>
    /// 是。原名稱
    /// </summary>
    public string? C4 { get; set; }

    /// <summary>
    /// 評鑑學年度
    /// </summary>
    public string C5 { get; set; } = null!;

    /// <summary>
    /// 評鑑名稱
    /// </summary>
    public string C6 { get; set; } = null!;

    /// <summary>
    /// 評鑑結果
    /// </summary>
    public string C7 { get; set; } = null!;

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
    /// 申請聯絡人2
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

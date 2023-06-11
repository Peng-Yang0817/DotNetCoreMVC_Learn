using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class OneForm005
{
    /// <summary>
    /// PK 表5 編碼
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
    /// 增設別
    /// </summary>
    public int State011Id { get; set; }

    /// <summary>
    /// 擬開設學制
    /// </summary>
    public string C1 { get; set; } = null!;

    /// <summary>
    /// 所屬學院
    /// </summary>
    public string C2 { get; set; } = null!;

    /// <summary>
    /// 校內相關領域系所
    /// </summary>
    public string? C3 { get; set; }

    /// <summary>
    /// 開設學位學程之全部支援系所
    /// </summary>
    public string? C4 { get; set; }

    /// <summary>
    /// 設立理由
    /// </summary>
    public string C5 { get; set; } = null!;

    /// <summary>
    /// 發展重點及課程規劃
    /// </summary>
    public string C6 { get; set; } = null!;

    /// <summary>
    /// 是否已經校務會議決議通過
    /// </summary>
    public int? State018Id { get; set; }

    /// <summary>
    /// 會議日期
    /// </summary>
    public string? C7 { get; set; }

    /// <summary>
    /// 校內相關程序說明
    /// </summary>
    public string C8 { get; set; } = null!;

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

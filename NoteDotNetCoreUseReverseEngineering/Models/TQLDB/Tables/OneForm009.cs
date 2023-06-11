using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class OneForm009
{
    /// <summary>
    /// PK 表9 技專校院108學年度「非特殊項目之院系科學士學位學程之任一學制增設」申請案清單 編碼
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
    /// 院系科學位學程名稱
    /// </summary>
    public string? DepartmentName { get; set; }

    /// <summary>
    /// 擬增設之學制及
    /// 招生名額
    /// </summary>
    public int? C1 { get; set; }

    /// <summary>
    /// 擬增設學制之招生名額來源
    /// 或說明事項
    /// </summary>
    public string? C2 { get; set; }

    /// <summary>
    /// 107學年度
    /// 核定學制
    /// </summary>
    public string? C3 { get; set; }

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

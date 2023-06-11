using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class OneForm007
{
    /// <summary>
    /// PK 表7 院所系科學位學程之「分組增設」、「部分學制增加分組」及「分組改名」申請清單 編碼
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
    /// 第1案選填 所系科名稱
    /// </summary>
    public string DepartmentName1 { get; set; } = null!;

    /// <summary>
    /// 所系科分組 名稱
    /// </summary>
    public string C1 { get; set; } = null!;

    /// <summary>
    /// FK State011 增設/申請類別/調整別 編碼
    /// </summary>
    public int State011Id1 { get; set; }

    /// <summary>
    /// 學年度之核定學制
    /// </summary>
    public string C2 { get; set; } = null!;

    /// <summary>
    /// 分組擬 招生學制
    /// </summary>
    public string C3 { get; set; } = null!;

    /// <summary>
    /// 申請理由、師資及課程規劃
    /// </summary>
    public string C4 { get; set; } = null!;

    /// <summary>
    /// 第2案選填 所系科名稱
    /// </summary>
    public string? DepartmentName2 { get; set; }

    /// <summary>
    /// 所系科分組 名稱
    /// </summary>
    public string? C5 { get; set; }

    /// <summary>
    /// FK State011 增設/申請類別/調整別 編碼
    /// </summary>
    public int? State011Id2 { get; set; }

    /// <summary>
    /// 學年度之核定學制
    /// </summary>
    public string? C6 { get; set; }

    /// <summary>
    /// 分組擬 招生學制
    /// </summary>
    public string? C7 { get; set; }

    /// <summary>
    /// 申請理由、師資及課程規劃
    /// </summary>
    public string? C8 { get; set; }

    /// <summary>
    /// 第3案選填 所系科名稱
    /// </summary>
    public string? DepartmentName3 { get; set; }

    /// <summary>
    /// 所系科分組 名稱
    /// </summary>
    public string? C9 { get; set; }

    /// <summary>
    /// FK State011 增設/申請類別/調整別 編碼
    /// </summary>
    public int? State011Id3 { get; set; }

    /// <summary>
    /// 學年度之核定學制
    /// </summary>
    public string? C10 { get; set; }

    /// <summary>
    /// 分組擬 招生學制
    /// </summary>
    public string? C11 { get; set; }

    /// <summary>
    /// 申請理由、師資及課程規劃
    /// </summary>
    public string? C12 { get; set; }

    /// <summary>
    /// 第4案選填 所系科名稱
    /// </summary>
    public string? DepartmentName4 { get; set; }

    /// <summary>
    /// 所系科分組 名稱
    /// </summary>
    public string? C13 { get; set; }

    /// <summary>
    /// FK State011 增設/申請類別/調整別 編碼
    /// </summary>
    public int? State011Id4 { get; set; }

    /// <summary>
    /// 學年度之核定學制
    /// </summary>
    public string? C14 { get; set; }

    /// <summary>
    /// 分組擬 招生學制
    /// </summary>
    public string? C15 { get; set; }

    /// <summary>
    /// 申請理由、師資及課程規劃
    /// </summary>
    public string? C16 { get; set; }

    /// <summary>
    /// 第5案選填 所系科名稱
    /// </summary>
    public string? DepartmentName5 { get; set; }

    /// <summary>
    /// 所系科分組 名稱
    /// </summary>
    public string? C17 { get; set; }

    /// <summary>
    /// FK State011 增設/申請類別/調整別 編碼
    /// </summary>
    public int? State011Id5 { get; set; }

    /// <summary>
    /// 學年度之核定學制
    /// </summary>
    public string? C18 { get; set; }

    /// <summary>
    /// 分組擬 招生學制
    /// </summary>
    public string? C19 { get; set; }

    /// <summary>
    /// 申請理由、師資及課程規劃
    /// </summary>
    public string? C20 { get; set; }

    /// <summary>
    /// 第6案選填 所系科名稱
    /// </summary>
    public string? DepartmentName6 { get; set; }

    /// <summary>
    /// 所系科分組 名稱
    /// </summary>
    public string? C21 { get; set; }

    /// <summary>
    /// FK State011 增設/申請類別/調整別 編碼
    /// </summary>
    public int? State011Id6 { get; set; }

    /// <summary>
    /// 學年度之核定學制
    /// </summary>
    public string? C22 { get; set; }

    /// <summary>
    /// 分組擬 招生學制
    /// </summary>
    public string? C23 { get; set; }

    /// <summary>
    /// 申請理由、師資及課程規劃
    /// </summary>
    public string? C24 { get; set; }

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

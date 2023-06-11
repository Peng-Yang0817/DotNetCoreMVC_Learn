using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class OneForm004
{
    /// <summary>
    /// PK 表4 編碼
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
    /// 表4說明表申請案名稱
    /// </summary>
    public string ProjectName { get; set; } = null!;

    /// <summary>
    /// 當學年度核定名額
    /// </summary>
    public int C1 { get; set; }

    /// <summary>
    /// 停招理由
    /// </summary>
    public string C2 { get; set; } = null!;

    /// <summary>
    /// 停招符合條件-擬停招之學制系科:測驗中心已核准公告取消考科之系科。
    /// </summary>
    public bool C3 { get; set; }

    /// <summary>
    /// 停招符合條件-擬停招之學制系科:該學制系科之招生人數大於（或相近）報名人數。
    /// </summary>
    public bool C4 { get; set; }

    /// <summary>
    /// 停招符合條件-擬停招之學制系科:系科停招之名額，調整於重點人才培育之系科，或與產學合作密切相關之系科。
    /// </summary>
    public bool C5 { get; set; }

    /// <summary>
    /// 已研提配套措施，不致影響師生權益-本校仍有其他具可替代性之招生管道、學制
    /// </summary>
    public bool C6 { get; set; }

    /// <summary>
    /// 已研提配套措施，不致影響師生權益-其他國立學校仍設有相近領域且具可替代性之學制系科
    /// </summary>
    public bool C7 { get; set; }

    /// <summary>
    /// 佐證說明
    /// </summary>
    public string? C8 { get; set; }

    /// <summary>
    /// 停招後之學生就學配套措施-是否已對停招所系科之學生妥善溝通與宣導:是/否
    /// </summary>
    public int? State018Id1 { get; set; }

    /// <summary>
    /// 日期
    /// </summary>
    public DateTime? C9 { get; set; }

    /// <summary>
    /// 停招後之學生就學配套措施-對尚未畢業學生之輔導與其他配套措施規劃：
    /// </summary>
    public string? C10 { get; set; }

    /// <summary>
    /// 原有師資調整計劃
    /// </summary>
    public string? C11 { get; set; }

    /// <summary>
    /// 停招名額之流用規劃
    /// </summary>
    public string? C12 { get; set; }

    /// <summary>
    /// 本所系科現有學制及核定招生名額-學制:
    /// </summary>
    public string? State012Id1 { get; set; }

    /// <summary>
    /// 本所系科現有學制及核定招生名額-107學年度核定招生名額： 名
    /// </summary>
    public int? C13 { get; set; }

    /// <summary>
    /// 本所系科現有學制及核定招生名額-學制:
    /// </summary>
    public string? State012Id2 { get; set; }

    /// <summary>
    /// 本所系科現有學制及核定招生名額-107學年度核定招生名額： 名
    /// </summary>
    public int? C14 { get; set; }

    /// <summary>
    /// 本所系科現有學制及核定招生名額-學制:
    /// </summary>
    public string? State012Id3 { get; set; }

    /// <summary>
    /// 本所系科現有學制及核定招生名額-107學年度核定招生名額： 名
    /// </summary>
    public int? C15 { get; set; }

    /// <summary>
    /// 本所系科停招學制近三學年新生註冊率（小數點第一位四捨五入）-106學年度，核定招生名額 名
    /// </summary>
    public int? C16 { get; set; }

    /// <summary>
    /// 本所系科停招學制近三學年新生註冊率（小數點第一位四捨五入）-106學年度，新生註冊人數 人
    /// </summary>
    public int? C17 { get; set; }

    /// <summary>
    /// 本所系科停招學制近三學年新生註冊率（小數點第一位四捨五入）-106學年度，新生註冊率 ％。
    /// </summary>
    public double? C18 { get; set; }

    /// <summary>
    /// 本所系科停招學制近三學年新生註冊率（小數點第一位四捨五入）-105學年度，核定招生名額 名
    /// </summary>
    public int? C19 { get; set; }

    /// <summary>
    /// 本所系科停招學制近三學年新生註冊率（小數點第一位四捨五入）-105學年度，新生註冊人數 人
    /// </summary>
    public int? C20 { get; set; }

    /// <summary>
    /// 本所系科停招學制近三學年新生註冊率（小數點第一位四捨五入）-105學年度，新生註冊率 ％。
    /// </summary>
    public double? C21 { get; set; }

    /// <summary>
    /// 本所系科停招學制近三學年新生註冊率（小數點第一位四捨五入）-104學年度，核定招生名額 名
    /// </summary>
    public int? C22 { get; set; }

    /// <summary>
    /// 本所系科停招學制近三學年新生註冊率（小數點第一位四捨五入）-104學年度，新生註冊人數 人
    /// </summary>
    public int? C23 { get; set; }

    /// <summary>
    /// 本所系科停招學制近三學年新生註冊率（小數點第一位四捨五入）-104學年度，新生註冊率 ％。
    /// </summary>
    public double? C24 { get; set; }

    /// <summary>
    /// 本所系科停招學制近三學年報名及錄取人數-106學年度，報名人數 名
    /// </summary>
    public int? C25 { get; set; }

    /// <summary>
    /// 本所系科停招學制近三學年報名及錄取人數-106學年度，錄取人數 名
    /// </summary>
    public int? C26 { get; set; }

    /// <summary>
    /// 本所系科停招學制近三學年報名及錄取人數-105學年度，報名人數 名
    /// </summary>
    public int? C27 { get; set; }

    /// <summary>
    /// 本所系科停招學制近三學年報名及錄取人數-105學年度，錄取人數 名
    /// </summary>
    public int? C28 { get; set; }

    /// <summary>
    /// 本所系科停招學制近三學年報名及錄取人數-104學年度，報名人數 名
    /// </summary>
    public int? C29 { get; set; }

    /// <summary>
    /// 本所系科停招學制近三學年報名及錄取人數-104學年度，錄取人數 名
    /// </summary>
    public int? C30 { get; set; }

    /// <summary>
    /// 105〜107學年度所系科停招核定情形
    /// </summary>
    public string? C31 { get; set; }

    /// <summary>
    /// 校內審查及行政流程簡述-是否已經校務會議決議通過：是/否
    /// </summary>
    public int? State018Id2 { get; set; }

    /// <summary>
    /// 會議日期
    /// </summary>
    public DateTime? C32 { get; set; }

    /// <summary>
    /// 校內相關程序說明：
    /// </summary>
    public string? C33 { get; set; }

    /// <summary>
    /// 本所系科現有學制及核定招生名額
    /// </summary>
    public string? C99 { get; set; }

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

using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class OneForm003
{
    /// <summary>
    /// PK 表3編碼
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
    /// 申請之所科系
    /// </summary>
    public string DepartmentName { get; set; } = null!;

    /// <summary>
    /// FK State011 增設/申請類別 編碼
    /// </summary>
    public int State011Id1 { get; set; }

    /// <summary>
    /// FK State011 增設/申請類別 編碼
    /// </summary>
    public int State011Id2 { get; set; }

    /// <summary>
    /// FK State012 學制 編碼
    /// </summary>
    public int State012Id1 { get; set; }

    /// <summary>
    /// 申請學制名額
    /// </summary>
    public int C1 { get; set; }

    /// <summary>
    /// 申請學制及名額，核定招生名額
    /// </summary>
    public int? C2 { get; set; }

    /// <summary>
    /// 現有招生規模
    /// </summary>
    public string? C3 { get; set; }

    /// <summary>
    /// 現有在學學生總人數
    /// </summary>
    public int E1 { get; set; }

    /// <summary>
    /// 申請增招之所系科之現有在學學生數
    /// </summary>
    public int? E2 { get; set; }

    /// <summary>
    /// 現在專任師資人數，教授
    /// </summary>
    public int F1 { get; set; }

    /// <summary>
    /// 現在專任師資人數，副教授
    /// </summary>
    public int F2 { get; set; }

    /// <summary>
    /// 現在專任師資人數，助理教授
    /// </summary>
    public int F3 { get; set; }

    /// <summary>
    /// 現在專任師資人數，講師
    /// </summary>
    public int F4 { get; set; }

    /// <summary>
    /// 申請時師生比值
    /// </summary>
    public double G1 { get; set; }

    /// <summary>
    /// 師生比值，預估
    /// </summary>
    public double G2 { get; set; }

    /// <summary>
    /// 擬增招／任一學制增設之既有學制註冊率，106核定招生名額
    /// </summary>
    public int H1 { get; set; }

    /// <summary>
    /// 106新生註冊人數
    /// </summary>
    public int H2 { get; set; }

    /// <summary>
    /// 106新生註冊率
    /// </summary>
    public double H3 { get; set; }

    /// <summary>
    /// 105核定招生名額
    /// </summary>
    public int H4 { get; set; }

    /// <summary>
    /// 105新生註冊人數
    /// </summary>
    public int H5 { get; set; }

    /// <summary>
    /// 105新生註冊率
    /// </summary>
    public double H6 { get; set; }

    /// <summary>
    /// 104核定招生名額
    /// </summary>
    public int H7 { get; set; }

    /// <summary>
    /// 104新生註冊人數
    /// </summary>
    public int H8 { get; set; }

    /// <summary>
    /// 104新生註冊率
    /// </summary>
    public double H9 { get; set; }

    /// <summary>
    /// 本所系科總註冊率，106核定招生名額
    /// </summary>
    public int H10 { get; set; }

    /// <summary>
    /// 106新生註冊人數
    /// </summary>
    public int H11 { get; set; }

    /// <summary>
    /// 106新生註冊率
    /// </summary>
    public double H12 { get; set; }

    /// <summary>
    /// 105核定招生名額
    /// </summary>
    public int H13 { get; set; }

    /// <summary>
    /// 105新生註冊人數
    /// </summary>
    public int H14 { get; set; }

    /// <summary>
    /// 105新生註冊率
    /// </summary>
    public double H15 { get; set; }

    /// <summary>
    /// 104核定招生名額
    /// </summary>
    public int H16 { get; set; }

    /// <summary>
    /// 104新生註冊人數
    /// </summary>
    public int H17 { get; set; }

    /// <summary>
    /// 104新生註冊率
    /// </summary>
    public double H18 { get; set; }

    /// <summary>
    /// 106證照考取率
    /// </summary>
    public double I1 { get; set; }

    /// <summary>
    /// 105證照考取率
    /// </summary>
    public double I2 { get; set; }

    /// <summary>
    /// 104證照考取率
    /// </summary>
    public double I3 { get; set; }

    /// <summary>
    /// 評鑑學年度
    /// </summary>
    public string J1 { get; set; } = null!;

    /// <summary>
    /// 評鑑名稱
    /// </summary>
    public string J2 { get; set; } = null!;

    /// <summary>
    /// 評鑑結果
    /// </summary>
    public string J3 { get; set; } = null!;

    /// <summary>
    /// FK State012 學制 編碼 107學年度增招情形
    /// </summary>
    public int? State012Id4 { get; set; }

    /// <summary>
    /// 107學年度核定增招名額
    /// </summary>
    public int? K1 { get; set; }

    /// <summary>
    /// FK State012 學制 編碼 106學年度增招情形
    /// </summary>
    public int? State012Id5 { get; set; }

    /// <summary>
    /// 106學年度核定增招名額
    /// </summary>
    public int? K2 { get; set; }

    /// <summary>
    /// FK State012 學制 編碼 105學年度增招情形
    /// </summary>
    public int? State012Id6 { get; set; }

    /// <summary>
    /// 105學年度核定增招名額
    /// </summary>
    public int? K3 { get; set; }

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

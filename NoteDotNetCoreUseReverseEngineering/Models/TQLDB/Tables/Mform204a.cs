using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Mform204a
{
    /// <summary>
    /// PK
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 學年度
    /// </summary>
    public int Year { get; set; }

    /// <summary>
    /// 學期
    /// </summary>
    public string? Semester { get; set; }

    /// <summary>
    /// 校基庫學校代碼
    /// </summary>
    public string SchoolNum { get; set; } = null!;

    /// <summary>
    /// 學校名稱
    /// </summary>
    public string SchoolName { get; set; } = null!;

    /// <summary>
    /// 建築名稱
    /// </summary>
    public string? BuildingName { get; set; }

    /// <summary>
    /// 是否經法院公證(有)
    /// </summary>
    public string? Notarization { get; set; }

    /// <summary>
    /// 法院公證證明字號(有)
    /// </summary>
    public string? NotarizationNum { get; set; }

    /// <summary>
    /// 是否有合約(有)
    /// </summary>
    public string? Contract { get; set; }

    /// <summary>
    /// 合約期限-租約始日
    /// </summary>
    public string? ContractStart { get; set; }

    /// <summary>
    /// 合約期限-租約結束
    /// </summary>
    public string? ContractEnd { get; set; }

    /// <summary>
    /// 面積數
    /// </summary>
    public double? AreaNum { get; set; }

    /// <summary>
    /// 修改項目(增加、修改(刪除))
    /// </summary>
    public string? EditNote { get; set; }

    public string? Note { get; set; }

    public DateTime EditTime { get; set; }
}

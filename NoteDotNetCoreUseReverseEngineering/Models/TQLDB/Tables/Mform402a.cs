using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Mform402a
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
    /// 校基庫學校代碼
    /// </summary>
    public string SchoolNum { get; set; } = null!;

    /// <summary>
    /// 學校名稱
    /// </summary>
    public string SchoolName { get; set; } = null!;

    /// <summary>
    /// 系所代碼
    /// </summary>
    public string DepartmentNum { get; set; } = null!;

    /// <summary>
    /// 開課系所(限學院、學位學程)
    /// </summary>
    public string? OpenDegree { get; set; }

    /// <summary>
    /// 學制別
    /// </summary>
    public string? Degree { get; set; }

    /// <summary>
    /// 開課教師-專任現職教師-教授
    /// </summary>
    public int? XianZhiPhD { get; set; }

    /// <summary>
    /// 開課教師-專任現職教師-副教授
    /// </summary>
    public int? XianZhiAssocProf { get; set; }

    /// <summary>
    /// 開課教師-專任現職教師-助理教授
    /// </summary>
    public int? XianZhiTa { get; set; }

    /// <summary>
    /// 開課教師-專任現職教師--講師
    /// </summary>
    public int? XianZhiLecturer { get; set; }

    /// <summary>
    /// 開課教師-專任現職教師-講座或客座教授
    /// </summary>
    public int? XianZhiJiang { get; set; }

    /// <summary>
    /// 開課教師-專任現職教師--舊制助教
    /// </summary>
    public int? XianZhiJiuZhiTa { get; set; }

    /// <summary>
    /// 開課教師-專業技術教師-教授
    /// </summary>
    public int? JiShuPhD { get; set; }

    /// <summary>
    /// 開課教師-專業技術教師-副教授
    /// </summary>
    public int? JiShuAssocProf { get; set; }

    /// <summary>
    /// 開課教師-專業技術教師-助理教授
    /// </summary>
    public int? JiShuTa { get; set; }

    /// <summary>
    /// 開課教師-專業技術教師-講師
    /// </summary>
    public int? JiShuLecturer { get; set; }

    /// <summary>
    /// 開課教師-軍護教師及護理臨床教師-教官
    /// </summary>
    public int? JiaoGuan { get; set; }

    /// <summary>
    /// 開課教師-軍護教師及護理臨床教師-部派護理老師
    /// </summary>
    public int? Rn { get; set; }

    /// <summary>
    /// 開課教師-軍護教師及護理臨床教師-護理臨床指導教師
    /// </summary>
    public int? Advisor { get; set; }

    /// <summary>
    /// 支援開課教師之主聘系所
    /// </summary>
    public string? ChuPinXiSuo { get; set; }

    /// <summary>
    /// 修改項目
    /// </summary>
    public string? EditNote { get; set; }

    /// <summary>
    /// 修改註記
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// 修改時間
    /// </summary>
    public DateTime EditTime { get; set; }
}

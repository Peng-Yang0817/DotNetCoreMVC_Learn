using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class MformT01a
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
    /// 校基庫代碼
    /// </summary>
    public string SchoolNum { get; set; } = null!;

    /// <summary>
    /// 學校名稱
    /// </summary>
    public string SchoolName { get; set; } = null!;

    /// <summary>
    /// 系所類別代碼
    /// </summary>
    public string CategyDepartmentNum { get; set; } = null!;

    /// <summary>
    /// 系所類別
    /// </summary>
    public string CategyDepartment { get; set; } = null!;

    /// <summary>
    /// 系所代碼
    /// </summary>
    public string DepartmentNum { get; set; } = null!;

    /// <summary>
    /// 系所名稱
    /// </summary>
    public string DepartmentName { get; set; } = null!;

    /// <summary>
    /// 在學學生數-扣除全年校外實習-博士班
    /// </summary>
    public double? InSchoolPhD { get; set; }

    /// <summary>
    /// 在學學生數-扣除全年校外實習-日間碩士班
    /// </summary>
    public double? InSchoolMaster { get; set; }

    /// <summary>
    /// 在學學生數-扣除全年校外實習-碩士在職專班
    /// </summary>
    public double? InSchoolOtjmaster { get; set; }

    /// <summary>
    /// 在學學生數-扣除全年校外實習-日間學士班
    /// </summary>
    public double? InSchoolDegree { get; set; }

    /// <summary>
    /// 在學學生數-扣除全年校外實習-進修學士班
    /// </summary>
    public double? InSchoolNightDegree { get; set; }

    /// <summary>
    /// 在學學生數-扣除全年校外實習-日間五專
    /// </summary>
    public double? InSchoolCollege { get; set; }

    /// <summary>
    /// 在學學生數-扣除全年校外實習-日間二專
    /// </summary>
    public double? InSchoolJuniorCollege { get; set; }

    /// <summary>
    /// 在學學生數-扣除全年校外實習-進修二專
    /// </summary>
    public double? InSchoolNightJuniorCollege { get; set; }

    /// <summary>
    /// 延畢人數-扣除全年校外實習-博士班
    /// </summary>
    public double? DeferGraeutionPhD { get; set; }

    /// <summary>
    /// 延畢人數-扣除全年校外實習-日間碩士班
    /// </summary>
    public double? DeferGraeutionMaster { get; set; }

    /// <summary>
    /// 延畢人數-扣除全年校外實習-碩士在職專班
    /// </summary>
    public double? DeferGraeutionOtjmaster { get; set; }

    /// <summary>
    /// 延畢人數-扣除全年校外實習-日間學士班
    /// </summary>
    public double? DeferGraeutionDegree { get; set; }

    /// <summary>
    /// 延畢人數-扣除全年校外實習-進修學士班
    /// </summary>
    public double? DeferGraeutionNightDegree { get; set; }

    /// <summary>
    /// 延畢人數-扣除全年校外實習-日間五專
    /// </summary>
    public double? DeferGraeutionCollege { get; set; }

    /// <summary>
    /// 延畢人數-扣除全年校外實習-日間二專
    /// </summary>
    public double? DeferGraeutionJuniorCollege { get; set; }

    /// <summary>
    /// 延畢人數-扣除全年校外實習-進修二專
    /// </summary>
    public double? DeferGraeutionNightJuniorCollege { get; set; }

    /// <summary>
    /// 所系科教師數-現職教授
    /// </summary>
    public double? DegreeProf { get; set; }

    /// <summary>
    /// 所系科教師數-現職副教授
    /// </summary>
    public double? DegreeAssocProf { get; set; }

    /// <summary>
    /// 所系科教師數-現職助理教授
    /// </summary>
    public double? DegreeTa { get; set; }

    /// <summary>
    /// 所系科教師數-現職講師
    /// </summary>
    public double? DegreeLecturer { get; set; }

    /// <summary>
    /// 所系科教師數-部派護理老師
    /// </summary>
    public double? DegreeRn { get; set; }

    /// <summary>
    /// 所系科教師數-護理臨床指導教師
    /// </summary>
    public double? DegreeAdvisor { get; set; }

    /// <summary>
    /// 所系科教師數-兼任教授
    /// </summary>
    public double? DegreePtporf { get; set; }

    /// <summary>
    /// 所系科教師數-兼任副教授
    /// </summary>
    public double? DegreePtassocProf { get; set; }

    /// <summary>
    /// 所系科教師數-兼任助教
    /// </summary>
    public double? DegreePtta { get; set; }

    /// <summary>
    /// 所系科教師數-兼任講師
    /// </summary>
    public double? DegreePtlecturer { get; set; }

    /// <summary>
    /// 碩士班核定招生名額(日、夜合計)
    /// </summary>
    public double? Total { get; set; }

    /// <summary>
    /// 增設停招年度
    /// </summary>
    public string? Asy { get; set; }

    /// <summary>
    /// 檢核及修正
    /// </summary>
    public string? EditNote { get; set; }

    /// <summary>
    /// 修改時間
    /// </summary>
    public DateTime EditTime { get; set; }
}

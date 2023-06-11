using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class MformT02a
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
    public string CategoryDepartmentNum { get; set; } = null!;

    /// <summary>
    /// 系所類別
    /// </summary>
    public string CategoryDepartment { get; set; } = null!;

    /// <summary>
    /// 系所代碼
    /// </summary>
    public string DepartmentNum { get; set; } = null!;

    /// <summary>
    /// 學程、學院名稱
    /// </summary>
    public string CollegeName { get; set; } = null!;

    /// <summary>
    /// 在學學生數-扣除全年校外實習(本學程)-博士班
    /// </summary>
    public double? InSchoolPhD { get; set; }

    /// <summary>
    /// 在學學生數-扣除全年校外實習(本學程)-日間碩士班
    /// </summary>
    public double? InSchoolMaster { get; set; }

    /// <summary>
    /// 在學學生數-扣除全年校外實習(本學程)-碩士在職專班
    /// </summary>
    public double? InSchoolOtjmaster { get; set; }

    /// <summary>
    /// 在學學生數-扣除全年校外實習(本學程)-日間學士班
    /// </summary>
    public double? InSchoolDegree { get; set; }

    /// <summary>
    /// 在學學生數-扣除全年校外實習(本學程)-進修學士班
    /// </summary>
    public double? InSchoolNightDegree { get; set; }

    /// <summary>
    /// 在學學生數-扣除全年校外實習(本學程)-日間五專
    /// </summary>
    public double? InSchoolCollege { get; set; }

    /// <summary>
    /// 在學學生數-扣除全年校外實習(本學程)-日間二專
    /// </summary>
    public double? InSchoolJuniorCollege { get; set; }

    /// <summary>
    /// 在學學生數-扣除全年校外實習(本學程)-進修二專
    /// </summary>
    public double? InSchoolNightJuniorCollege { get; set; }

    /// <summary>
    /// 延畢人數-扣除全年校外實習(本學程)-博士班
    /// </summary>
    public double? DeferGraeutionPhD { get; set; }

    /// <summary>
    /// 延畢人數-扣除全年校外實習(本學程)-日間碩士班
    /// </summary>
    public double? DeferGraeutionMaster { get; set; }

    /// <summary>
    /// 延畢人數-扣除全年校外實習(本學程)-碩士在職專班
    /// </summary>
    public double? DeferGraeutionOtjmaster { get; set; }

    /// <summary>
    /// 延畢人數-扣除全年校外實習(本學程)-日間學士班
    /// </summary>
    public double? DeferGraeutionDegree { get; set; }

    /// <summary>
    /// 延畢人數-扣除全年校外實習(本學程)-進修學士班
    /// </summary>
    public double? DeferGraeutionNightDegree { get; set; }

    /// <summary>
    /// 延畢人數-扣除全年校外實習(本學程)-日間五專
    /// </summary>
    public double? DeferGraeutionCollege { get; set; }

    /// <summary>
    /// 延畢人數-扣除全年校外實習(本學程)-日間二專
    /// </summary>
    public double? DeferGraeutionJuniorCollege { get; set; }

    /// <summary>
    /// 延畢人數-扣除全年校外實習(本學程)-進修二專
    /// </summary>
    public double? DeferGraeutionNightJuniorCollege { get; set; }

    /// <summary>
    /// 支援開課教師人數(含本學程主聘)-現職教授
    /// </summary>
    public double? SupportProf { get; set; }

    /// <summary>
    /// 支援開課教師人數(含本學程主聘)-現職副教授
    /// </summary>
    public double? SupportAssocProf { get; set; }

    /// <summary>
    /// 支援開課教師人數(含本學程主聘)-現職助理教授
    /// </summary>
    public double? SupportTa { get; set; }

    /// <summary>
    /// 支援開課教師人數(含本學程主聘)-現職講師
    /// </summary>
    public double? SupportLecturer { get; set; }

    /// <summary>
    /// 支援開課教師人數(含本學程主聘)-部派護理老師
    /// </summary>
    public double? SupportRn { get; set; }

    /// <summary>
    /// 支援開課教師人數(含本學程主聘)-護理臨床指導教師
    /// </summary>
    public double? SupportAdvisor { get; set; }

    /// <summary>
    /// 本學程主聘教師數
    /// </summary>
    public double? EmployTeacherNum { get; set; }

    /// <summary>
    /// 支援開辦支系所-在學學生數總計
    /// </summary>
    public double? SupportStudentTotal { get; set; }

    /// <summary>
    /// 支援開辦支系所-延畢生總計
    /// </summary>
    public double? SupportDeferTotal { get; set; }

    /// <summary>
    /// 支援開辦支系所-專任教師總計
    /// </summary>
    public double? SupportTeacherTotal { get; set; }

    /// <summary>
    /// 支援開辦之系所
    /// </summary>
    public string? SupportOpen { get; set; }

    /// <summary>
    /// 增設停招年度
    /// </summary>
    public string? Asy { get; set; }

    /// <summary>
    /// 檢核修正註記
    /// </summary>
    public string? EditNote { get; set; }

    /// <summary>
    /// 修改時間
    /// </summary>
    public DateTime EditTime { get; set; }
}

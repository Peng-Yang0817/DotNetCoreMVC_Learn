using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Mform301a20180705
{
    public int Id { get; set; }

    public int Year { get; set; }

    public string Semester { get; set; } = null!;

    public string SchoolNum { get; set; } = null!;

    public string SchoolName { get; set; } = null!;

    public string DepartmentNum { get; set; } = null!;

    public string? ZhuPinXiSuo { get; set; }

    public string? TeacherNum { get; set; }

    public string? TeacherName { get; set; }

    public string? GongPinXiSuo { get; set; }

    public string? PinRenDate { get; set; }

    public string? JuanJianRen { get; set; }

    public string? ShouKeShiShu { get; set; }

    public string? Classification { get; set; }

    public string? JinXiuTeacher { get; set; }

    public string? PinShuZhiJi { get; set; }

    public string? ChengShuZhiJi { get; set; }

    public string? ChengShuNum { get; set; }

    public string? LieJiZhiJi { get; set; }

    public string? EditNote { get; set; }

    public string? Note { get; set; }

    public DateTime EditTime { get; set; }
}

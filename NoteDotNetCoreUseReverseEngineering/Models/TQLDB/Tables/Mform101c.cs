using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Mform101c
{
    public int Year { get; set; }

    public string Semester { get; set; } = null!;

    public string SchoolNum { get; set; } = null!;

    public string SchoolName { get; set; } = null!;

    public double? TotalPhD { get; set; }

    public double? TotalMaster { get; set; }

    public double? TotalOjtMaster { get; set; }

    public double? TotalErJiRiJian { get; set; }

    public double? TotalSiJiRiJian { get; set; }

    public double? TotalErJiJinXiu { get; set; }

    public double? TotalSiJiJinXiu { get; set; }

    public double? TotalJiJinXiuYuan { get; set; }

    public double? TotalSiJiZaiZhiZhuanBan { get; set; }

    public double? TotalErZhuanRiJian { get; set; }

    public double? TotalWuZhuanRiJian { get; set; }

    public double? TotalErZhuanYeJian { get; set; }

    public double? TotalJinXiuZhuanXiao { get; set; }

    public double? TotalZaiZhiZhuan { get; set; }

    public double? Total { get; set; }
}

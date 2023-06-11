using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Mform107b
{
    public int Year { get; set; }

    public string Semester { get; set; } = null!;

    public string SchoolNum { get; set; } = null!;

    public string SchoolName { get; set; } = null!;

    public string DepartmentNum { get; set; } = null!;

    public string DepartmentName { get; set; } = null!;

    public double? Ph { get; set; }

    public double? Master { get; set; }

    public double? Ojtmaster { get; set; }

    public double? ErJiRiJian { get; set; }

    public double? SiJiRiJian { get; set; }

    public double? ErJiJinXiu { get; set; }

    public double? SiJiJinXiu { get; set; }

    public double? JiJinXiuYuan { get; set; }

    public double? SiJiZaiZhiZhuanBan { get; set; }

    public double? ErZhuanRiJian { get; set; }

    public double? WuZhuanRiJian { get; set; }

    public double? ErZhuanYeJian { get; set; }

    public double? JinXiuZhuanXiao { get; set; }

    public double? ZaiZhiZhuan { get; set; }

    public double? Sum { get; set; }
}

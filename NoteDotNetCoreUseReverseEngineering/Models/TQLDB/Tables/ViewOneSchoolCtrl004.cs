using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class ViewOneSchoolCtrl004
{
    public int Id { get; set; }

    public string SchoolName { get; set; } = null!;

    public string Tclnum { get; set; } = null!;

    public string SchoolNum { get; set; } = null!;

    public int SchoolCtrl002Id { get; set; }

    public string CollegeName { get; set; } = null!;

    public int SchoolCtrl004Id { get; set; }

    public string ShuoBoShrBanName { get; set; } = null!;

    public string? ClassName { get; set; }

    public string? GroupName { get; set; }

    public string? CategoryName { get; set; }
}

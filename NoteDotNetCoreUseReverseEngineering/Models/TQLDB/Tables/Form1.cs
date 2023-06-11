using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Form1
{
    public string? SchoolName { get; set; }

    public int? SchoolCtrl001Id { get; set; }

    public string? CollegeName { get; set; }

    public int? SchoolCtrl002Id { get; set; }

    public string? TotalName { get; set; }

    public string ShuoBoShrBanName { get; set; } = null!;

    public string? ClassName { get; set; }

    public string? GroupName { get; set; }

    public string? DepartmentAreaName { get; set; }

    public int SchoolCtrl004Id { get; set; }

    public string BoShiBanState { get; set; } = null!;

    public string ShuoShrBanState { get; set; } = null!;

    public string ShuoShiZaiZhiZhuanBanState { get; set; } = null!;

    public int? NewBoShiBanJqs { get; set; }

    public int? NewBoShiBanDeposit { get; set; }

    public int? NewBoShiBanDepositRecover { get; set; }

    public int? NewShuoShiBanJqs { get; set; }

    public int? NewShuoShiBanDeposit { get; set; }

    public int? NewShuoShiBanDepositRecover { get; set; }

    public int? NewShuoShiZaiZhiZhuanBanJqs { get; set; }

    public int? NewShuoShiZaiZhiZhuanBanDeposit { get; set; }

    public int? NewShuoShiZaiZhiZhuanBanDepositRecover { get; set; }

    public int? OldBoShiBanJqs { get; set; }

    public int? OldShuoShiBanJqs { get; set; }

    public int? OldShuoShiZaiZhiZhuanBanJqs { get; set; }

    public int? SumBoShiBanDeposit { get; set; }

    public int? SumShuoShiBanDeposit { get; set; }

    public int? SumShuoShiZaiZhiZhuanBanDeposit { get; set; }
}

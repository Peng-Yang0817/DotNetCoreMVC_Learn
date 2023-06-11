using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Nform033AgainDeposit
{
    public string? SchoolName { get; set; }

    public int? SchoolCtrl001Id { get; set; }

    public string? TotalName { get; set; }

    public string JuanKeBuName { get; set; } = null!;

    public string? ClassName { get; set; }

    public string? GroupName { get; set; }

    public string? DepartmentAreaName { get; set; }

    public int SchoolCtrl007Id { get; set; }

    public string ErZhuanRiJianBuState { get; set; } = null!;

    public int? NewErZhuanRiJianBuJqs { get; set; }

    public int? NewErZhuanRiJianBuDeposit { get; set; }

    public int? NewErZhuanRiJianBuDepositRecover { get; set; }

    public int? OldErZhuanRiJianBuJqs { get; set; }

    public int? SumErZhuanRiJianBuDeposit { get; set; }

    public int? ErZhuanRiJianBuTolalShortfall { get; set; }

    public int? ErZhuanRiJianBuAgainDeposit { get; set; }
}

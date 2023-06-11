using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class NformAnnex7Step2
{
    public int Id { get; set; }

    public int? Year { get; set; }

    public int? SchoolCtrl001Id { get; set; }

    public string? DepartmentName { get; set; }

    /// <summary>
    /// 博士班擴充名額
    /// </summary>
    public string? BoShiBanQuota { get; set; }

    /// <summary>
    /// 博士班學制是否存在
    /// </summary>
    public bool? BoShiBanExist { get; set; }

    /// <summary>
    /// 碩士班擴充名額
    /// </summary>
    public string? ShuoShiBanQuota { get; set; }

    /// <summary>
    /// 碩士班學制是否存在
    /// </summary>
    public bool? ShuoShiBanExist { get; set; }

    /// <summary>
    /// 碩士在職專班擴充名額
    /// </summary>
    public string? ShuoShiZaiZhiZhuanBanQuota { get; set; }

    /// <summary>
    /// 碩士在職專班學制是否存在
    /// </summary>
    public bool? ShuoShiZaiZhiZhuanBanExist { get; set; }

    /// <summary>
    /// 四技日間部-高職生擴充名額
    /// </summary>
    public string? GauJrShengAquota { get; set; }

    /// <summary>
    /// 四技日間部-高職生學制是否存在
    /// </summary>
    public bool? GauJrShengAexist { get; set; }

    /// <summary>
    /// 四技日間部-高中生擴充名額
    /// </summary>
    public string? GauJungShengQuota { get; set; }

    /// <summary>
    /// 四技日間部-高中生學制是否存在
    /// </summary>
    public bool? GauJungShengExist { get; set; }

    /// <summary>
    /// 四技進修部擴充名額
    /// </summary>
    public string? SiJiJinXiuBuQuota { get; set; }

    /// <summary>
    /// 四技進修部學制是否存在
    /// </summary>
    public bool? SiJiJinXiuBuExist { get; set; }

    /// <summary>
    /// 四技在職專班擴充名額
    /// </summary>
    public string? SiJiZaiZhiZhuanBanQuota { get; set; }

    /// <summary>
    /// 四技在職專班學制是否存在
    /// </summary>
    public bool? SiJiZaiZhiZhuanBanExist { get; set; }

    /// <summary>
    /// 二技日間部擴充名額
    /// </summary>
    public string? ErJiRiJianBuQuota { get; set; }

    /// <summary>
    /// 二技日間部學制是否存在
    /// </summary>
    public bool? ErJiRiJianBuExist { get; set; }

    /// <summary>
    /// 二技進修部擴充名額
    /// </summary>
    public string? ErJiJinXiuBuQuota { get; set; }

    /// <summary>
    /// 二技進修部學制是否存在
    /// </summary>
    public bool? ErJiJinXiuBuExist { get; set; }

    /// <summary>
    /// 進修學院擴充名額
    /// </summary>
    public string? ErJiJinXiuXueYuanQuota { get; set; }

    /// <summary>
    /// 進修學院學制是否存在
    /// </summary>
    public bool? ErJiJinXiuXueYuanExist { get; set; }

    /// <summary>
    /// 系所生師比値
    /// </summary>
    public decimal? NformAnnex7A7 { get; set; }

    /// <summary>
    /// 最多可再外加名額數(加權後)
    /// </summary>
    public string? NformAnnex7C8 { get; set; }

    public int? StateStep02 { get; set; }
}

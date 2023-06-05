using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Auth001
{
    /// <summary>
    /// PK
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 使用者帳號
    /// </summary>
    [Display(Name = "使用者帳號")]
    public string Username { get; set; } = null!;

    /// <summary>
    /// 使用者密碼
    /// </summary>
    [Display(Name = "使用者密碼")]
    public string Password { get; set; } = null!;

    /// <summary>
    /// 使用者 E-Mail
    /// </summary>
    [Display(Name = "使用者 E-Mail")]
    public string Email { get; set; } = null!;

    /// <summary>
    /// 使用者姓名
    /// </summary>
    [Display(Name = "使用者姓名")]
    public string Name { get; set; } = null!;

    /// <summary>
    /// SysCtrl002 roleRange
    /// </summary>
    [Display(Name = "使用者權限")]
    public string RoleRange { get; set; } = null!;

    /// <summary>
    /// SchoolCtrl001 FK
    /// </summary>
    [Display(Name = "SchoolCtrl001 FK")]
    public int? SchoolCtrl001Id { get; set; }

    /// <summary>
    /// 使用者單位
    /// </summary>
    [Display(Name = "使用者單位")]
    public string? Office { get; set; }

    /// <summary>
    /// 使用者電話
    /// </summary>
    [Display(Name = "使用者電話")]
    public string? Phone { get; set; }

    /// <summary>
    /// 使用者手機
    /// </summary>
    [Display(Name = "使用者手機")]
    public string? Cellphone { get; set; }

    /// <summary>
    /// 使用者傳真號碼
    /// </summary>
    [Display(Name = "使用者傳真號碼")]
    public string? Fax { get; set; }

    /// <summary>
    /// 使用者狀態(開啟,關閉)
    /// </summary>
    [Display(Name = "使用者狀態(開啟,關閉)")]
    public int State006Id { get; set; }

    /// <summary>
    /// 使用者建立時間
    /// </summary>
    [Display(Name = "使用者建立時間")]
    public DateTime CreateTime { get; set; }

    public bool IsChangeInfo { get; set; }

    /// <summary>
    /// 審查委員負責之送審領域
    /// </summary>
    [Display(Name = "審查委員負責之送審領域")]
    public int? State013Id { get; set; }

    public string? JobTitle { get; set; }

    public string? Specialty { get; set; }

    public string? Education { get; set; }

    public string? Address { get; set; }

    /// <summary>
    /// 辦公處所
    /// </summary>
    [Display(Name = "辦公處所")]
    public string? DepartmentName { get; set; }
    /// <summary>
    /// 辦公處所
    /// </summary>
    [Display(Name = "是否開啟狀態")]
    public bool? IsChangePassword { get; set; }
    /// <summary>
    /// 辦公處所
    /// </summary>
    [Display(Name = "是否開啟使用")]
    public bool? IsEncrypted { get; set; }
}

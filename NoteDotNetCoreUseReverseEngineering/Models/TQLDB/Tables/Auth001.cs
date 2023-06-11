using System;
using System.Collections.Generic;

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
    public string Username { get; set; } = null!;

    /// <summary>
    /// 使用者密碼
    /// </summary>
    public string Password { get; set; } = null!;

    /// <summary>
    /// 使用者 E-Mail
    /// </summary>
    public string Email { get; set; } = null!;

    /// <summary>
    /// 使用者姓名
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// SysCtrl002 roleRange
    /// </summary>
    public string RoleRange { get; set; } = null!;

    /// <summary>
    /// SchoolCtrl001 FK
    /// </summary>
    public int? SchoolCtrl001Id { get; set; }

    /// <summary>
    /// 使用者單位
    /// </summary>
    public string? Office { get; set; }

    /// <summary>
    /// 使用者電話
    /// </summary>
    public string? Phone { get; set; }

    /// <summary>
    /// 使用者手機
    /// </summary>
    public string? Cellphone { get; set; }

    /// <summary>
    /// 使用者傳真號碼
    /// </summary>
    public string? Fax { get; set; }

    /// <summary>
    /// 使用者狀態(開啟,關閉)
    /// </summary>
    public int State006Id { get; set; }

    /// <summary>
    /// 使用者建立時間
    /// </summary>
    public DateTime CreateTime { get; set; }

    public bool IsChangeInfo { get; set; }

    /// <summary>
    /// 審查委員負責之送審領域
    /// </summary>
    public int? State013Id { get; set; }

    public string? JobTitle { get; set; }

    public string? Specialty { get; set; }

    public string? Education { get; set; }

    public string? Address { get; set; }

    public string? DepartmentName { get; set; }

    public bool? IsChangePassword { get; set; }

    public bool? IsEncrypted { get; set; }
}

using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class PasswordSmtp
{
    public int Id { get; set; }

    public string? MsgTitle { get; set; }

    public string? MsgBody { get; set; }

    public string? MsgValidUrl { get; set; }

    public string? MsgValidNum { get; set; }

    public bool? MsgValidState { get; set; }

    public bool? MsgSendState { get; set; }

    public string? MsgReceiver { get; set; }

    public DateTime? MsgDeadLineTime { get; set; }

    public int? Auth001Id { get; set; }

    public DateTime? CreateTime { get; set; }
}

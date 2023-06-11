using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class ViewOneFormUpload
{
    public string Id { get; set; } = null!;

    public string Year { get; set; } = null!;

    public int SchoolCtrl001Id { get; set; }

    public string SchoolName { get; set; } = null!;

    public string Tclnum { get; set; } = null!;

    public string SchoolNum { get; set; } = null!;

    public int OneForm000Id { get; set; }

    public string FormName { get; set; } = null!;

    public string FormFileNum { get; set; } = null!;

    public string FileName { get; set; } = null!;

    public DateTime EditTime { get; set; }

    public int EditAuth001Id { get; set; }

    public string Username { get; set; } = null!;

    public string Name { get; set; } = null!;
}

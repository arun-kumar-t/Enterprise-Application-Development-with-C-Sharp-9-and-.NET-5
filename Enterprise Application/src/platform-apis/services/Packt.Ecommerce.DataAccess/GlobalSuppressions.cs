﻿// "//-----------------------------------------------------------------------".
// <copyright file="GlobalSuppressions.cs" company="Packt">
// Copyright (c) 2020 Packt Corporation. All rights reserved.
// </copyright>
// "//-----------------------------------------------------------------------".
// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Design", "CA1052:Static holder types should be Static or NotInheritable", Justification = "Program class", Scope = "type", Target = "~T:Packt.Ecommerce.DataAccess.Program")]
[assembly: SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "Startup class", Scope = "member", Target = "~M:Packt.Ecommerce.DataAccess.Startup.Configure(Microsoft.AspNetCore.Builder.IApplicationBuilder,Microsoft.AspNetCore.Hosting.IWebHostEnvironment)")]
[assembly: SuppressMessage("Major Code Smell", "S1118:Utility classes should not have public constructors", Justification = "Program class", Scope = "type", Target = "~T:Packt.Ecommerce.DataAccess.Program")]

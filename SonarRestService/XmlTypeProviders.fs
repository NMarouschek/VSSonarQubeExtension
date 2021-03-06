﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="XmlTypeProviders.fs" company="Trimble Navigation Limited">
//     Copyright (C) 2013 [Jorge Costa, Jorge.Costa@trimble.com]
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
// This program is free software; you can redistribute it and/or modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 2 of the License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty
// of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details. 
// You should have received a copy of the GNU General Public License along with this program; if not, write to the Free
// Software Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA
// --------------------------------------------------------------------------------------------------------------------

namespace SonarRestService

open System.Xml.Linq
open FSharp.Data

type UserSettingsXml = XmlProvider<"""<?xml version="1.0" encoding="utf-8"?>
<Project DefaultTargets="Build" ToolsVersion="4.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
        <PropertyGroup>
        <UserSourceDir>path</UserSourceDir> 
        <UserOutputDir>path</UserOutputDir>
        <UserTSExeDir>path</UserTSExeDir>
        <UserApplicationsDir>path</UserApplicationsDir>
        <UserSRCDir>path</UserSRCDir>
        <UserOBJDir>path</UserOBJDir>
        <UserBINDir>path</UserBINDir>
    </PropertyGroup>
  <PropertyGroup Condition="'$(COND)'=='version'">
	<UserSRCDir>path1</UserSRCDir>
	<UserOBJDir>path1</UserOBJDir> 
	<UserBINDir>path2</UserBINDir> 
  </PropertyGroup>
</Project>""">

type DupsData = XmlProvider<""" <duplications>
<g>
    <b s="46" l="90" r="com.tekla.bim:Tekla.WPF:Composition/ImportMany.cs"/>
    <b s="46" l="90" r="com.tekla.bim:Tekla.WPF:Composition/Import.cs"/>
</g>
<g>
    <b s="91" l="38" r="com.tekla.bim:Tekla.WPF:Composition/Placeholder.cs"/>
    <b s="78" l="38" r="com.tekla.bim:Tekla.WPF:Composition/ImportMany.cs"/>
    <b s="78" l="38" r="com.tekla.bim:Tekla.WPF:Composition/Import.cs"/>
</g>
<g>
    <b s="101" l="26" r="com.tekla.bim:Tekla.WPF:Composition/Placeholder.cs"/>
    <b s="95" l="25" r="com.tekla.bim:Tekla.Common.UI.Wpf:Composition/Placeholder.cs"/>
    <b s="88" l="26" r="com.tekla.bim:Tekla.WPF:Composition/ImportMany.cs"/>
    <b s="88" l="26" r="com.tekla.bim:Tekla.WPF:Composition/Import.cs"/></g>
<g>
    <b s="99" l="26" r="com.tekla.bim:Tekla.Common.UI.Wpf:Composition/ImportMany.cs"/>
    <b s="101" l="24" r="com.tekla.bim:Tekla.WPF:Composition/Placeholder.cs"/>
    <b s="99" l="26" r="com.tekla.bim:Tekla.Common.UI.Wpf:Composition/Import.cs"/>
    <b s="95" l="24" r="com.tekla.bim:Tekla.Common.UI.Wpf:Composition/Placeholder.cs"/>
    <b s="88" l="24" r="com.tekla.bim:Tekla.WPF:Composition/ImportMany.cs"/>
    <b s="88" l="24" r="com.tekla.bim:Tekla.WPF:Composition/Import.cs"/></g>
</duplications> """>
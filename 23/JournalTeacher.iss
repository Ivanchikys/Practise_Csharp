; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Электронный журнал"
#define MyAppVersion "1.5.2"
#define MyAppPublisher "GGKTTiD"
#define MyAppExeName "WpfApp6.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application. Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{475FB630-2F6A-4FD9-AE47-B673C67F0765}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
DefaultDirName={autopf}\{#MyAppName}
UninstallDisplayIcon={app}\{#MyAppExeName}
; "ArchitecturesAllowed=x64compatible" specifies that Setup cannot run
; on anything but x64 and Windows 11 on Arm.
ArchitecturesAllowed=x64compatible
; "ArchitecturesInstallIn64BitMode=x64compatible" requests that the
; install be done in "64-bit mode" on x64 or Windows 11 on Arm,
; meaning it should use the native 64-bit Program Files directory and
; the 64-bit view of the registry.
ArchitecturesInstallIn64BitMode=x64compatible
DefaultGroupName={#MyAppName}
AllowNoIcons=yes
; Uncomment the following line to run in non administrative install mode (install for current user only).
;PrivilegesRequired=lowest
OutputBaseFilename=mysetup
SolidCompression=yes
WizardStyle=modern

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "russian"; MessagesFile: "compiler:Languages\Russian.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\{#MyAppExeName}"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\System.Text.Encodings.Web.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\System.Text.Json.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\WpfApp6.application"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\WpfApp6.deps.json"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\WpfApp6.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\WpfApp6.dll.manifest"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\WpfApp6.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\WpfApp6.runtimeconfig.json"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\cs\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\de\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\es\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\fr\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\it\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\ja\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\ko\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\pl\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\pt-BR\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\ru\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\runtimes\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\tr\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\zh-Hans\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\zh-Hant\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\Humanizer.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\Microsoft.Bcl.AsyncInterfaces.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\Microsoft.Build.Locator.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\Microsoft.CodeAnalysis.CSharp.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\Microsoft.CodeAnalysis.CSharp.Workspaces.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\Microsoft.CodeAnalysis.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\Microsoft.CodeAnalysis.Workspaces.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\Microsoft.CodeAnalysis.Workspaces.MSBuild.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\Microsoft.Data.Sqlite.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\Microsoft.EntityFrameworkCore.Abstractions.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\Microsoft.EntityFrameworkCore.Design.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\Microsoft.EntityFrameworkCore.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\Microsoft.EntityFrameworkCore.Relational.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\Microsoft.EntityFrameworkCore.Sqlite.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\Microsoft.Extensions.Caching.Abstractions.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\Microsoft.Extensions.Caching.Memory.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\Microsoft.Extensions.Configuration.Abstractions.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\Microsoft.Extensions.DependencyInjection.Abstractions.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\Microsoft.Extensions.DependencyInjection.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\Microsoft.Extensions.DependencyModel.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\Microsoft.Extensions.Logging.Abstractions.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\Microsoft.Extensions.Logging.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\Microsoft.Extensions.Options.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\Microsoft.Extensions.Primitives.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\Mono.TextTemplating.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\SQLitePCLRaw.batteries_v2.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\SQLitePCLRaw.core.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\SQLitePCLRaw.provider.e_sqlite3.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\System.Composition.AttributedModel.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\System.Composition.Convention.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\System.Composition.Hosting.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\System.Composition.Runtime.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\System.Composition.TypedParts.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\System.Diagnostics.DiagnosticSource.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Labaratornie\C#\Практика\19\WpfApp7\bin\Release\net8.0-windows\System.IO.Pipelines.dll"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent


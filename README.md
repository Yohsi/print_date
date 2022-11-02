# Minimal project to reproduce Godot crash

## How to get the crash

- Download Godot for linux server v3.5.1-mono (https://downloads.tuxfamily.org/godotengine/3.5.1/mono/Godot_v3.5.1-stable_mono_linux_server_64.zip)
- Export a PCK file from this project
- Run `/path/to/Godot_v3.5.1-stable_mono_linux_server_64 --main-pack out/print_date.pck`

## My setup

- Ubuntu 22.04
- Mono version 6.12.0.182 (installed following these instructions: https://www.mono-project.com/download/stable/)
- dotnet version 6.0.110 (installed with `sudo apt install dotnet6`)

## Logs during the crash

Console output:
```
System.TypeInitializationException: The type initializer for 'Sys' threw an exception. ---> System.DllNotFoundException: System.Native assembly:<unknown assembly> type:<unknown type> member:(null)
  at (wrapper managed-to-native) Interop+Sys.LChflagsCanSetHiddenFlag()
  at Interop+Sys..cctor () [0x00000] in <02071a39c8a34187bdd1f58e4be38764>:0 
   --- End of inner exception stack trace ---
  at System.IO.FileSystem.FileExists (System.ReadOnlySpan`1[T] fullPath, System.Int32 fileType, Interop+ErrorInfo& errorInfo) [0x00007] in <02071a39c8a34187bdd1f58e4be38764>:0 
  at System.IO.FileSystem.FileExists (System.ReadOnlySpan`1[T] fullPath) [0x00006] in <02071a39c8a34187bdd1f58e4be38764>:0 
  at System.IO.File.Exists (System.String path) [0x00043] in <02071a39c8a34187bdd1f58e4be38764>:0 
  at System.TimeZoneInfo.TryLoadTzFile (System.String tzFilePath, System.Byte[]& rawData, System.String& id) [0x00000] in <02071a39c8a34187bdd1f58e4be38764>:0 
  at System.TimeZoneInfo.TryGetLocalTzFile (System.Byte[]& rawData, System.String& id) [0x0000f] in <02071a39c8a34187bdd1f58e4be38764>:0 
  at System.TimeZoneInfo.GetLocalTimeZoneFromTzFile () [0x00000] in <02071a39c8a34187bdd1f58e4be38764>:0 
  at System.TimeZoneInfo.GetLocalTimeZone (System.TimeZoneInfo+CachedData cachedData) [0x00000] in <02071a39c8a34187bdd1f58e4be38764>:0 
  at System.TimeZoneInfo+CachedData.CreateLocal () [0x00018] in <02071a39c8a34187bdd1f58e4be38764>:0 
  at System.TimeZoneInfo+CachedData.get_Local () [0x0000c] in <02071a39c8a34187bdd1f58e4be38764>:0 
  at System.TimeZoneInfo.get_Local () [0x00000] in <02071a39c8a34187bdd1f58e4be38764>:0 
  at System.TimeZoneInfo.GetDateTimeNowUtcOffsetFromUtc (System.DateTime time, System.Boolean& isAmbiguousLocalDst) [0x00000] in <02071a39c8a34187bdd1f58e4be38764>:0 
  at System.DateTime.get_Now () [0x00008] in <02071a39c8a34187bdd1f58e4be38764>:0 
  at PrintDate._Ready () [0x00000] in <3dd98c360c43422ca4c94e6dd2f20860>:0 
```

Mono logs:
```
DllImport unable to load library 'System.Native'. (in domain Mono, warning)
DllImport unable to load library 'System.Native'. (in domain Mono, warning)
DllImport unable to load library 'System.Native'. (in domain Mono, warning)
DllImport unable to load library 'System.Native'. (in domain Mono, warning)
DllImport unable to load library 'System.Native'. (in domain Mono, warning)
```

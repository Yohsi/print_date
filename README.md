# Minimal project to reproduce Godot crash

## How to get the crash

- Download Godot for linux server v3.5.1-mono (https://downloads.tuxfamily.org/godotengine/3.5.1/mono/Godot_v3.5.1-stable_mono_linux_server_64.zip)
- Export a PCK file from this project
- Run `/path/to/Godot_v3.5.1-stable_mono_linux_server_64 --main-pack out/print_date.pck`

## My setup

- Ubuntu 22.04
- Mono version 6.12.0.182 (installed following these instructions: https://www.mono-project.com/download/stable/)
- dotnet version 6.0.110 (installed with `sudo apt install dotnet6`)

#!/bin/bash

set -e

src=`dirname "$0"`
out="/c/Program Files (x86)/Steam/steamapps/common/ONINAKI/ONINAKI_Data"

dotnet build "${src}"
echo

set -x

cp "${src}/../../Assets/common/masterdata.modded" "${out}/StreamingAssets/STEAM/common/masterdata"
cp "${src}/../Assembly-CSharp.dll" "${out}/Managed"
cp "${src}/bin/Debug/Oninaki.Reincarnation.dll" "${out}/Managed"

cmd.exe //c start //D "C:\\Program Files (x86)\\Steam\\steamapps\\common\\ONINAKI" "ONINAKI.exe"

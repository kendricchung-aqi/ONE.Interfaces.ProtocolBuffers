﻿# remove flat folder with no prompot
rmdir -r ./flat
mkdir -Force ./flat

Get-ChildItem ./claros -Recurse -Filter "*.proto" | Copy-Item -destination ./flat

cd ./flat
$files = Get-ChildItem . -Filter "*.proto" 

$dirs = "cpp","csharp" # "java", "js", "objc", "php", "python", "ruby"

# Create Output Directories
foreach($dir in $dirs) {
    mkdir -Force ./out/$dir
}

$flags = @()
foreach ($dir in $dirs){
    $flags += "--$dir" +"_out=./out/$dir"
}
$flags = [String]::Join(" ", $flags)
$flags

$logName =  (Get-Date -DisplayHint Time).ToString().Replace(":","_").Replace("/","_").Replace(" ", "-")+".log"

$commandPath = Split-Path $MyInvocation.MyCommand.Path -Parent

# Start-Transcript $logName
foreach($file in $files)
{
    $Command = "$commandPath\protoc\tool\protoc $flags $file"
    echo `n$Command

    Invoke-Expression -Command $Command
}
# Stop-Transcript
cd ..

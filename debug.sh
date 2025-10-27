#!/bin/bash
echo "=== Checking WebGL Build Dependencies ==="
echo "Python:"
which python3 && python3 --version

echo -e "\nNode:"
which node && node --version

echo -e "\nEmscripten (emcc):"
which emcc && emcc --version

echo -e "\nUnity WebGL Support:"
ls -la /Volumes/2020_3_49f1/Unity.app/Contents/PlaybackEngines/WebGLSupport/BuildTools/Emscripten*/

echo -e "\nPATH:"
echo $PATH
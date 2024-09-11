dotnet tool install --global autosdk.cli --prerelease

autosdk init \
  Mystic \
  MysticApi \
  https://www.mystic.ai/openapi.json \
  tryAGI \
  --output .
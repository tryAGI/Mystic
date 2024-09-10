dotnet tool install --global openapigenerator.cli --prerelease

oag init \
  SolutionName \
  SomeApi \
  https://raw.githubusercontent.com/api/openapi.json \
  CompanyName \
  --output .
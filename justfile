test:
    dotnet test test
docs:
    docfx docs/docfx.json --serve
commit:
    npx git-cz
prepare:
    npx husky

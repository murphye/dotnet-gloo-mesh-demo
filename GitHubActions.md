# GitHub Actions for .NET Applications

https://blog.kritner.com/2021/11/29/cicd-for-net6-with-github-actions/




## Run Locally (Optional)

Run GitHub Actions locally with [Act](https://github.com/nektos/act).

Note: Act requires Docker to be running locally.

### Homebrew (Mac)
```
brew install act
```

### Chocolatey (Windows)
```
choco install act-cli
```

```
cd code/pet-store-service
act -W .github/workflows/ci.yaml
```
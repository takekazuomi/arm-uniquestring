# ARM uniqueString Function that runs locally

Inside, we are using the Azure.Deployments.Expression package.
<https://www.nuget.org/packages/Azure.Deployments.Expression/>

For how to use the package, I referred to the code below.
<https://cs.github.com/Azure/bicep/blob/6afa660cba723c79181b98b80f9965234e94857e/src/Bicep.Core/Emit/ScopeHelper.cs#L205>

## local build

build and run

```sh
$ make 
$ ./out/uniqueString test
rbgf3xv4ufgzg
```

## docker build

build and run

```sh
$ make build
$ docker run -it --rm local/uniquestring test
rbgf3xv4ufgzg
```

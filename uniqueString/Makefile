local-build:
	dotnet publish -r linux-x64 -p:PublishSingleFile=true --self-contained true -p:PublishTrimmed=true -o out

build:
	docker build -t uniquestring .
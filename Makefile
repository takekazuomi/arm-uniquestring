CR	= local/
TAG	= 0.0.1

local-build:
	dotnet publish -r linux-x64 -p:PublishSingleFile=true --self-contained true -p:PublishTrimmed=true -o out

build:
	docker build -t $(CR)uniquestring:$(TAG) ./uniqueString/
	docker tag $(CR)uniquestring:$(TAG)  $(CR)uniquestring:latest